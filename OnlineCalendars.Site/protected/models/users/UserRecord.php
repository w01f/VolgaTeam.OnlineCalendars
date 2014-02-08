<?php

	/**
	 * @property string login
	 * @property string password
	 * @property string email
	 */
	class UserRecord extends CActiveRecord
	{
		public static function model($className = __CLASS__)
		{
			return parent::model($className);
		}

		public function tableName()
		{
			return '{{user}}';
		}

		/**
		 * @param string $password
		 * @return bool
		 */
		public function validatePassword($password)
		{
			return self::hashPassword($password) === $this->password;
		}

		/**
		 * @param $email
		 * @return bool
		 */
		public function validateEmail($email)
		{
			return strtolower($this->email) == strtolower($email);
		}

		/**
		 * @param bool $isNewUser
		 * @param bool $sendEmail
		 */
		public function changePassword($isNewUser, $sendEmail)
		{
			$password = self::generatePassword();
			$this->password = self::hashPassword($password);
			$this->save();

			$resetPassword = ResetPasswordRecord::model()->findByPk($this->login);
			if (!isset($resetPassword))
			{
				$resetPassword = new ResetPasswordRecord();
				$resetPassword->login = $this->login;
			}
			$resetPassword->initial_date = date(Yii::app()->params['mysqlDateFormat'], strtotime(date('y:m:d')));
			$resetPassword->save();

			if ($sendEmail)
			{
				$message = Yii::app()->email;
				$message->to = $this->email;
				if (Yii::app()->params['email']['copy_enabled'])
					$message->cc = Yii::app()->params['email']['copy'];
				$message->subject = $isNewUser ? Yii::app()->params['email']['new_user']['subject'] : ('Password Reset for ' . Yii::app()->getBaseUrl(true));
				$message->from = Yii::app()->params['email']['from'];
				$message->viewVars = array('fullName' => ($this->first_name . ' ' . $this->last_name), 'login' => $this->login, 'password' => $password, 'site' => Yii::app()->name);
				$message->view = $isNewUser ? 'newUser' : 'existedUser';
				$message->send();
			}
		}

		public function deleteWithRelations()
		{
			ResetPasswordRecord::model()->deleteAll('LOWER(login)=?', array(strtolower($this->login)));
			$this->delete();
		}

		/**
		 * @param string $password
		 * @return string
		 */
		public static function hashPassword($password)
		{
			return md5($password);
		}

		/**
		 * @return string
		 */
		public static function generatePassword()
		{
			$pass = '';
			if (Yii::app()->params['login']['complex_password'])
				$pass = self::generateStrongPassword();
			else
			{
				$alphabet = "abcdefghijklmnopqrstuwxyz0123456789";
				for ($i = 0; $i < 5; $i++)
				{
					$n = rand(0, strlen($alphabet) - 1);
					$pass[$i] = $alphabet[$n];
				}
				$pass = implode($pass);
			}
			return $pass;
		}

		/**
		 * @return string
		 */
		private static function generateStrongPassword()
		{
			$out = '';
			$l = 10;
			$c = 2;
			$n = 2;
			$s = 2;
			// get count of all required minimum special chars
			$count = $c + $n + $s;

			// change these strings if you want to include or exclude possible password characters
			$chars = "abcdefghijklmnopqrstuvwxyz";
			$caps = strtoupper($chars);
			$nums = "0123456789";
			$syms = "!@#$%^&*()-+?";

			// build the base password of all lower-case letters
			for ($i = 0; $i < $l; $i++)
			{
				$out .= substr($chars, mt_rand(0, strlen($chars) - 1), 1);
			}

			// create arrays if special character(s) required
			if ($count)
			{
				// split base password to array; create special chars array
				$tmp1 = str_split($out);
				$tmp2 = array();

				// add required special character(s) to second array
				for ($i = 0; $i < $c; $i++)
				{
					array_push($tmp2, substr($caps, mt_rand(0, strlen($caps) - 1), 1));
				}
				for ($i = 0; $i < $n; $i++)
				{
					array_push($tmp2, substr($nums, mt_rand(0, strlen($nums) - 1), 1));
				}
				for ($i = 0; $i < $s; $i++)
				{
					array_push($tmp2, substr($syms, mt_rand(0, strlen($syms) - 1), 1));
				}

				// hack off a chunk of the base password array that's as big as the special chars array
				$tmp1 = array_slice($tmp1, 0, $l - $count);
				// merge special character(s) array with base password array
				$tmp1 = array_merge($tmp1, $tmp2);
				// mix the characters up
				shuffle($tmp1);
				// convert to string for output
				$out = implode('', $tmp1);
			}
			return $out;
		}
	}
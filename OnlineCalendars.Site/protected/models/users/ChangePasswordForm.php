<?php
	class ChangePasswordForm extends CFormModel
	{
		public $login;
		public $oldPassword;
		public $rememberMe;
		public $newInitialPassword;
		public $newRepeatPassword;

		public function rules()
		{
			return array(
				array('newInitialPassword, newRepeatPassword', 'required'),
				array('newInitialPassword, newRepeatPassword', 'validatePassword'),
			);
		}

		public function attributeLabels()
		{
			return array();
		}

		public function validatePassword()
		{
			$result = true;
			if ($this->newInitialPassword == '' || $this->newRepeatPassword == '')
			{
				$this->addError('newInitialPassword', 'You need to type password and confirm it.');
				$result = false;
			}
			else if ($this->newInitialPassword != $this->newRepeatPassword)
			{
				$this->addError('newRepeatPassword', 'You need to type same password twice.');
				$result = false;
			}
			else if (Yii::app()->params['login']['complex_password'])
			{
				$conditionPass = 0;
				$pwd = $this->newInitialPassword;
				if (strlen($pwd) >= 8)
					$conditionPass++;
				if (preg_match("#[0-9]+#", $pwd))
					$conditionPass++;
				if (preg_match("#[a-z]+#", $pwd))
					$conditionPass++;
				if (preg_match("#[A-Z]+#", $pwd))
					$conditionPass++;
				if (preg_match("#\W+#", $pwd))
					$conditionPass++;
				if ($conditionPass <= 3)
				{
					$result = false;
					$this->addError('newInitialPassword', 'Password must be min 8 characters and contain at least 3 of these 4 conditions below:' . '<br>' .
						'Password must include at least one character in lower case' . '<br>' .
						'Password must include at least one number' . '<br>' .
						'Password must include at least one CAPS' . '<br>' .
						'Password must include at least one symbol');
				}
			}
			return $result;
		}

		public function changePassword()
		{
			$identity = new UserIdentity($this->login, $this->oldPassword);
			if ($identity->changePassword($this->newInitialPassword))
			{
				$identity = new UserIdentity($this->login, $this->newInitialPassword);
				if ($identity->authenticate())
				{
					$duration = $this->rememberMe ? 3600 * 24 * 30 : 0; // 30 days
					Yii::app()->user->login($identity, $duration);
					return true;
				}
			}
			$this->addError('newInitialPassword', 'Error while changing password. Please contact to technical support');
			return false;
		}

	}
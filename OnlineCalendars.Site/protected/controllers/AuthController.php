<?php

	class AuthController extends AppController
	{
		public $defaultAction = 'index';

		public function getViewPath()
		{
			return YiiBase::getPathOfAlias($this->pathPrefix . 'auth');
		}


		public function actionLogin()
		{
			$loginModel = new LoginForm();

			$attributes = Yii::app()->request->getPost('LoginForm');
			if (isset($attributes))
			{
				$loginModel->attributes = $attributes;
				if ($loginModel->validate() && $loginModel->login())
				{
					if ($loginModel->needToResetPassword)
					{
						$this->redirect($this->createUrl('auth/changePassword', array(
							'login' => $loginModel->login,
							'password' => $loginModel->password,
							'rememberMe' => $loginModel->rememberMe
						)));
					}
					else
						$this->redirect(Yii::app()->user->returnUrl);
				}
			}
			$this->pageTitle = Yii::app()->name . ' - Login';
			$this->render('login', array('formData' => $loginModel));
		}

		public function actionLogout()
		{
			Yii::app()->user->logout();
			Yii::app()->end();
		}

		public function actionChangePassword()
		{
			$changePasswordModel = new ChangePasswordForm();
			$attributes = Yii::app()->request->getPost('ChangePasswordForm');
			$this->pageTitle = Yii::app()->name . ' - Change Password';
			if (isset($attributes))
			{
				$changePasswordModel->attributes = $attributes;
				$changePasswordModel->login = $attributes['login'];
				$changePasswordModel->oldPassword = $attributes['oldPassword'];
				$changePasswordModel->rememberMe = $attributes['rememberMe'];
				if ($changePasswordModel->validate() && $changePasswordModel->changePassword())
				{
					$this->redirect(Yii::app()->user->returnUrl);
				}
				else
					$this->render('changePassword', array('formData' => $changePasswordModel));
			}
			else
			{
				$login = Yii::app()->request->getQuery('login');
				$oldPassword = Yii::app()->request->getQuery('password');
				$rememberMe = Yii::app()->request->getQuery('rememberMe', false);
				if (isset($login) && isset($oldPassword))
				{
					$changePasswordModel->login = $login;
					$changePasswordModel->oldPassword = $oldPassword;
					$changePasswordModel->rememberMe = $rememberMe;
					$this->render('changePassword', array('formData' => $changePasswordModel));
				}
			}
		}

		public function actionRecoverPasswordDialog()
		{
			$this->renderPartial('recoverPassword', array(), false, true);
		}

		public function actionRecoverPasswordDialogSuccess()
		{
			$this->renderPartial('successDialog', array('header' => 'Password Recovery', 'content' => 'A temporary password has been sent<br>Check your inbox of junk mail filter'), false, true);
		}

		public function actionValidateUserByEmail()
		{
			$login = Yii::app()->request->getPost('login');
			$email = Yii::app()->request->getPost('email');
			$result = 'Error while validating user. Try again or contact to technical support';
			if (isset($login) && isset($email))
			{
				/* @var $user UserRecord */
				$user = UserRecord::model()->find('login=?', array($login));
				if (isset($user))
					$result = $user->validateEmail($email) ? '' : 'Email address ' . $email . ' is not correct for user ' . $login;
				else
					$result = 'User with name "' . $login . '" is not registered';
			}
			echo $result;
		}

		public function actionRecoverPassword()
		{
			$login = Yii::app()->request->getPost('login');
			if (isset($login))
			{
				/* @var $user UserRecord */
				$user = UserRecord::model()->find('login=?', array($login));
				if (isset($user))
					$user->changePassword(false, true);
			}
		}

		public function actionDisclaimerWarning()
		{
			$this->renderPartial('disclaimerWarning', array('content' => Yii::app()->params['login']['disclaimerWarningText']), false, true);
		}
	}

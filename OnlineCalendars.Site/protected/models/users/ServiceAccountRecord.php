<?php

	/**
	 * ServiceAccountRecord is the class to store Service Account entity in DB.
	 */
	class ServiceAccountRecord extends CActiveRecord
	{
		public static function model($className = __CLASS__)
		{
			return parent::model($className);
		}

		public function tableName()
		{
			return '{{service_account}}';
		}

		/**
		 * Check if account with password existed in DB
		 * @param string $login
		 * @param string $password
		 * @return boolean
		 */
		public static function checkAccount($login, $password)
		{
			$hash = md5($password);
			$accountRecord = self::model()->find('login=? and password=?', array($login, $hash));
			return isset($accountRecord);
		}
	}

<?php

	/**
	 * @property string login
	 * @property string initial_date
	 */
	class ResetPasswordRecord extends CActiveRecord
	{
		public static function model($className = __CLASS__)
		{
			return parent::model($className);
		}

		public function tableName()
		{
			return '{{reset_password}}';
		}
	}
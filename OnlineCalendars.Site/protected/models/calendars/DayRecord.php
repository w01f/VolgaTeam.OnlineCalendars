<?php

	/**
	 * DayRecord is the class to store Day Entity in DB.
	 * @property mixed id
	 * @property string id_calendar
	 * @property string date
	 * @property string comment
	 */
	class DayRecord extends CActiveRecord
	{
		public static function model($className = __CLASS__)
		{
			return parent::model($className);
		}

		public function tableName()
		{
			return '{{day}}';
		}

		/**
		 * Returns Day Model based on DayRecord
		 * @return DayModel
		 */
		public function getModel()
		{
			$model = new DayModel();
			$model->load($this);
			return $model;
		}

		/**
		 * Updates data in DB
		 * @param string $calendarId
		 * @param DayModel $day
		 * @return void
		 */
		public static function updateData($calendarId, $day)
		{
			$dayRecord = new DayRecord();
			$dayRecord->id = $day->id;
			$dayRecord->id_calendar = $calendarId;
			$dayRecord->date = date(Yii::app()->params['mysqlDateFormat'], strtotime($day->date));
			$dayRecord->comment = $day->comment;
			$dayRecord->save();
		}

		/**
		 * Clear selected calendar days from DB
		 * @param string $calendarId
		 * @return void
		 */
		public static function clearCalendarData($calendarId)
		{
			self::model()->deleteAll('id_calendar=?', array($calendarId));
		}
	}

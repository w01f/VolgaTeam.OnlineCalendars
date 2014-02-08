<?php

	/**
	 * CalendarRecord is the class to store Calendar Entity in DB.
	 * @property mixed id
	 * @property string name
	 * @property string date_start
	 * @property string date_end
	 * @property DayRecord[] days
	 */
	class CalendarRecord extends CActiveRecord
	{
		public static function model($className = __CLASS__)
		{
			return parent::model($className);
		}

		public function tableName()
		{
			return '{{calendar}}';
		}

		public function relations()
		{
			return array(
				'days' => array(self::HAS_MANY, 'DayRecord', 'id_calendar'),
			);
		}

		/**
		 * Returns Calendar Model based on CalendarRecord
		 * @return CalendarModel
		 */
		public function getModel()
		{
			$model = new CalendarModel();
			$model->load($this);
			return $model;
		}

		/**
		 * Returns Calendar Model based on CalendarRecord without days loading
		 * @return CalendarModel
		 */
		public function getModelLight()
		{
			$model = new CalendarModel();
			$model->load($this, false);
			return $model;
		}

		/**
		 * Updates data in DB
		 * @param CalendarModel $calendar
		 * @return void
		 */
		public static function updateData($calendar)
		{
			$needToUpdate = false;
			$needToCreate = false;
			$calendarRecord = self::model()->findByPk($calendar->id);
			$lastModify = date(Yii::app()->params['mysqlDateFormat'], strtotime($calendar->lastModified));
			if (isset($calendarRecord))
				$needToUpdate = isset($calendarRecord->last_change_date) && $calendarRecord->last_change_date != $lastModify;
			else
			{
				$calendarRecord = new CalendarRecord();
				$needToCreate = true;
			}
			if ($needToCreate || $needToUpdate)
			{
				$calendarRecord->id = $calendar->id;
				$calendarRecord->name = $calendar->name;
				$calendarRecord->date_start = date(Yii::app()->params['mysqlDateFormat'], strtotime($calendar->dateStart));
				$calendarRecord->date_end = date(Yii::app()->params['mysqlDateFormat'], strtotime($calendar->dateEnd));
				$calendarRecord->last_change_date = date(Yii::app()->params['mysqlDateFormat'], strtotime($calendar->lastModified));
				$calendarRecord->save();

				DayRecord::clearCalendarData($calendar->id);

				foreach ($calendar->days as $day)
					DayRecord::updateData($calendar->id, $day);
			}
		}

		/**
		 * Returns all calendar records from DB
		 * @return CalendarModel[]
		 */
		public static function getCalendarList()
		{
			$calendars = array();
			/* @var $calendarRecords CalendarRecord[] */
			$calendarRecords = self::model()->findAll();
			foreach ($calendarRecords as $calendarRecord)
				$calendars[] = $calendarRecord->getModelLight();
			return $calendars;
		}
	}

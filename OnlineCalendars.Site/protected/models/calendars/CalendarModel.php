<?php

	/**
	 * CalendarModel is the class to represent Calendar Entity.
	 */
	class CalendarModel
	{
		/**
		 * @var string
		 * @soap
		 */
		public $id;
		/**
		 * @var string
		 * @soap
		 */
		public $name;
		/**
		 * @var string
		 * @soap
		 */
		public $dateStart;
		/**
		 * @var string
		 * @soap
		 */
		public $dateEnd;
		/**
		 * @var string
		 * @soap
		 */
		public $lastModified;
		/**
		 * @var DayModel[]
		 * @soap
		 */
		public $days;

		/**
		 * Initializes model from DB record
		 * @param CalendarRecord $calendarRecord
		 * @param bool $loadDays
		 * @return void
		 */
		public function load($calendarRecord, $loadDays = true)
		{
			$this->id = $calendarRecord->id;
			$this->name = $calendarRecord->name;
			$this->dateStart = $calendarRecord->date_start;
			$this->dateEnd = $calendarRecord->date_end;

			if ($loadDays)
				foreach ($calendarRecord->days as $dayRecord)
					$this->days[] = $dayRecord->getModel();
		}

		/**
		 * Returns calendars date range
		 * @return string
		 */
		public function getRange()
		{
			return date(Yii::app()->params['outputDateFormat'], strtotime($this->dateStart)) .
			' - ' .
			date(Yii::app()->params['outputDateFormat'], strtotime($this->dateEnd));
		}

		/**
		 * Returns calendar events array
		 * @return mixed[]
		 */
		public function getEvents()
		{
			$events = array();
			foreach ($this->days as $day)
				$events[] = $day->getEvent();
			return $events;
		}
	}

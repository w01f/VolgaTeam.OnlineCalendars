<?php

	/**
	 * DayModel is the class to represent Day Entity.
	 */
	class DayModel
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
		public $date;
		/**
		 * @var string
		 * @soap
		 */
		public $comment;

		/**
		 * Initializes model from DB record
		 * @param DayRecord $dayRecord
		 * @return void
		 */
		public function load($dayRecord)
		{
			$this->id = $dayRecord->id;
			$this->date = $dayRecord->date;
			$this->comment = $dayRecord->comment;
		}

		/**
		 * Returns day date as event array
		 * @return string
		 */
		public function getEvent()
		{
			return array('title' => $this->comment, 'start' => date('Y-m-d', strtotime($this->date)), 'className' => 'event-blue');
		}
	}

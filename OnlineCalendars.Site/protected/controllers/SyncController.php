<?php

	class SyncController extends CController
	{
		public function actions()
		{
			return array(
				'quote' => array(
					'class' => 'CWebServiceAction',
					'classMap' => array(
						'Calendar' => 'CalendarModel',
						'Day' => 'DayModel',
					),
				),
			);
		}

		private function authenticateBySession($sessionKey)
		{
			$data = Yii::app()->cacheDB->get($sessionKey);
			if ($data !== FALSE)
				return TRUE;
			else
				return FALSE;
		}

		/**
		 * @param string $login
		 * @param string $password
		 * @return string session key
		 * @soap
		 */
		public function getSessionKey($login, $password)
		{
			if (ServiceAccountRecord::checkAccount($login, $password))
			{
				$sessionKey = strval(md5(mt_rand()));
				Yii::app()->cacheDB->set($sessionKey, $login, (60 * 60 * 24 * 7));
				return $sessionKey;
			}
			else
				return '';
		}

		/**
		 * @param string $sessionKey
		 * @param CalendarModel[] $calendars
		 * @soap
		 */
		public function updateCalendars($sessionKey, $calendars)
		{
			if ($this->authenticateBySession($sessionKey))
			{
				$calendarRecords = CalendarRecord::model()->findAll();
				foreach ($calendarRecords as $calendarRecord)
					$existedCalendarIds[] = $calendarRecord->id;

				foreach ($calendars as $calendar)
				{
					CalendarRecord::updateData($calendar);
					$newCalendarIds[] = $calendar->id;
				}

				if (isset($existedCalendarIds) && isset($newCalendarIds))
					foreach ($existedCalendarIds as $existedCalendarId)
					{
						if (!isset($newCalendarIds) || !in_array($existedCalendarId, $newCalendarIds))
						{
							DayRecord::clearCalendarData($existedCalendarId);
							CalendarRecord::model()->deleteByPk($existedCalendarId);
						}
					}
			}
		}
	}

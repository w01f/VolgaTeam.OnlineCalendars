<?php

	class CalendarsController extends AppController
	{
		public function getViewPath()
		{
			return YiiBase::getPathOfAlias($this->pathPrefix . 'calendars');
		}

		public function actionGetList()
		{
			$selectedCalendarId = isset(Yii::app()->request->cookies['selectedCalendarId']) ? Yii::app()->request->cookies['selectedCalendarId']->value : null;
			$calendars = CalendarRecord::getCalendarList();
			if (count($calendars) > 0 && !isset($selectedCalendarId))
				$selectedCalendarId = $calendars[0]->id;
			$this->renderPartial('calendarList', array('calendars' => $calendars, 'selectedCalendarId' => $selectedCalendarId), false, true);
		}

		public function actionGetCalendar()
		{
			$calendarId = Yii::app()->request->getPost('calendarId');
			if (isset($calendarId))
			{
				/* @var $calendarRecord CalendarRecord */
				$calendarRecord = CalendarRecord::model()->findByPk($calendarId);
				$calendar = $calendarRecord->getModel();
				$this->renderPartial('calendarView', array('calendar' => $calendar), false, true);
			}
		}
	}

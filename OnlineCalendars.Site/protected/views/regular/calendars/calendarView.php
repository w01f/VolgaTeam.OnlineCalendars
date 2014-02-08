<? /* @var $calendar CalendarModel */ ?>
<div class="calendar-data">
	<? echo CJSON::encode($calendar->getEvents()); ?>
</div>
<div class="box">
	<div class="box-header">
		<div class="title"><? echo $calendar->name; ?></div>
	</div>
	<div class="box-content">
		<div class="full-calendar-demo fc fc-ltr">
		</div>
	</div>
</div>
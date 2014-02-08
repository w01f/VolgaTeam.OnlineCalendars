<?
	/* @var $calendars CalendarModel[] */
	/* @var $selectedCalendarId string */
?>
<ul class="nav nav-stacked">
	<? foreach ($calendars as $calendar): ?>
		<li id="calendar<? echo $calendar->id; ?>" class="calendar<? echo $selectedCalendarId == $calendar->id ? ' active' : ''; ?>">
			<a href="#"> <i class="icon-calendar"></i>
				<span class="title">
					<div><? echo $calendar->name; ?></div>
					<div class="sub"><? echo $calendar->getRange(); ?></div>
				</span>
			</a>
		</li>
	<? endforeach ?>
</ul>
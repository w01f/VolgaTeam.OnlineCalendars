(function ($)
{
	var CalendarManager;
	CalendarManager = function ()
	{
		var currentItem = null;
		var currentCalendar = null;

		var loadItems;
		loadItems = function ()
		{
			var list = $('#main-nav').find('.navigation ul');
			initList(list);
			var selectedCalendarItem = list.find('li.active');
			if (selectedCalendarItem.length > 0)
				openCalendar(selectedCalendarItem);
		};

		var initList;
		initList = function (itemList)
		{
			var isScrolling;
			itemList.find('li.calendar')
				.off('click').on('click', function (event)
				{
					openCalendar($(this));
					event.stopPropagation();
				});
		};

		var openCalendar;
		openCalendar = function (listItem)
		{
			currentItem = listItem;
			currentCalendar = null;
			var list = $('#main-nav').find('.navigation ul');
			list.find('li').removeClass('active');

			var calendarView = $('#content').find('.container');
			calendarView.html('');

			if (currentItem == null) return;
			currentItem.addClass('active');

			var calendarId = currentItem.attr('id').replace('calendar', '');
			$.cookie("selectedCalendarId", calendarId, {
				expires: (60 * 60 * 24 * 7)
			});
			$.ajax({
				type: "POST",
				url: "calendars/getCalendar",
				data: {
					calendarId: calendarId
				},
				beforeSend: function ()
				{
					$.showOverlay();
				},
				complete: function ()
				{
					$.hideOverlay();
				},
				success: function (msg)
				{
					currentCalendar = new Calendar(calendarId, '<div>' + msg + '</div>');
					currentCalendar.run();
				},
				async: true,
				dataType: 'html'
			});
		};

		this.refreshCalendar = function ()
		{
			if (currentCalendar != null)
				currentCalendar.refresh();
		};

		this.init = function ()
		{
			var listContainer = $('#main-nav').find('.navigation');
			$.ajax({
				type: "POST",
				url: "calendars/getList",
				beforeSend: function ()
				{
					listContainer.html('');
					$.showOverlay();
				},
				complete: function ()
				{
					$.hideOverlay();
				},
				success: function (msg)
				{
					listContainer.html(msg);
					loadItems();
				},
				async: true,
				dataType: 'html'
			});
		};
	};

	var Calendar = function (id, content)
	{
		var contentObject = $(content);
		var view = contentObject.find('.box');
		var events = $.parseJSON(contentObject.find('.calendar-data').html());
		var calendarArea = view.find(".full-calendar-demo");

		this.run = function ()
		{
			var calendarView = $('#content').find('.container');
			calendarView.html('');
			calendarView.append(view);
			calendarArea.fullCalendar({
				height: getCalendarHeight(),
				header: {
					center: "title",
					left: "basicWeek,month",
					right: "prev,today,next"
				},
				buttonText: {
					prev: "<span class=\"icon-chevron-left\"></span>",
					next: "<span class=\"icon-chevron-right\"></span>",
					today: "Today",
					basicWeek: "Week",
					month: "Month"
				},
				events: events
			});
		};

		this.refresh = function ()
		{
			calendarArea.fullCalendar('render');
		};

		var getCalendarHeight;
		getCalendarHeight = function ()
		{
			return $(window).height() - 140;
		};
	};

	$(document).ready(function ()
	{
		$.CalendarManager = new CalendarManager();
		$.CalendarManager.init();
	});
})(jQuery);
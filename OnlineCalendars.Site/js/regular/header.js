(function ()
{
	$(document).ready(function ()
	{
		var body, click_event, content, nav, nav_toggler;
		nav_toggler = $("header .toggle-nav");
		nav = $("#main-nav");
		content = $("#content");
		body = $("body");
		click_event = (jQuery.support.touch ? "tap" : "click");
		if (jQuery.support.touch)
		{
			nav.on("swiperight", function (e)
			{
				return $(document).trigger("nav-open");
			});
			nav.on("swipeleft", function (e)
			{
				return $(document).trigger("nav-close");
			});
		}
		nav_toggler.on(click_event, function ()
		{
			if (nav_open())
			{
				$(document).trigger("nav-close");
			}
			else
			{
				$(document).trigger("nav-open");
			}
			return false;
		});
		$(document).on("nav-close", function (event, params)
		{
			var nav_open;
			body.removeClass("main-nav-opened").addClass("main-nav-closed");
			$.CalendarManager.refreshCalendar();
			return nav_open = false;
		});

		$('#logout').off('click').on('click', $.AuthController.logout);

		return $(document).on("nav-open", function (event, params)
		{
			var nav_open;
			body.addClass("main-nav-opened").removeClass("main-nav-closed");
			$.CalendarManager.refreshCalendar();
			return nav_open = true;
		});
	});
	this.nav_open = function ()
	{
		return $("body").hasClass("main-nav-opened") || $("#main-nav").width() > 50;
	};
}).call(this);
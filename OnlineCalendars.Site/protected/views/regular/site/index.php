<?php
	$version = '3.0';
	$cs = Yii::app()->clientScript;
	$cs->registerCssFile(Yii::app()->clientScript->getCoreScriptUrl() . '/jui/css/base/jquery-ui.css');
	$cs->registerCssFile(Yii::app()->baseUrl . '/vendor/bootstrap/css/bootstrap.min.css?' . $version);
	$cs->registerCssFile(Yii::app()->baseUrl . '/vendor/fancybox/source/jquery.fancybox.css?' . $version);
	$cs->registerCssFile(Yii::app()->baseUrl . '/vendor/fancybox/source/helpers/jquery.fancybox-thumbs.css?' . $version);
	$cs->registerCssFile(Yii::app()->baseUrl . '/vendor/flatty/css/light-theme.css?' . $version);
	$cs->registerCssFile(Yii::app()->baseUrl . '/vendor/flatty/css/theme-colors.css?' . $version);
	$cs->registerCssFile(Yii::app()->baseUrl . '/vendor/fullcalendar/fullcalendar.css?' . $version);
	$cs->registerCssFile(Yii::app()->baseUrl . '/css/regular/main-panel.css?' . $version);
	$cs->registerCssFile(Yii::app()->baseUrl . '/css/regular/calendar-list.css?' . $version);
	$cs->registerCssFile(Yii::app()->baseUrl . '/css/regular/content.css?' . $version);
	$cs->registerCoreScript('jquery.ui');
	$cs->registerCoreScript('cookie');
	$cs->registerScriptFile(Yii::app()->baseUrl . '/vendor/json/jquery.json-2.3.min.js', CClientScript::POS_END);
	$cs->registerScriptFile(Yii::app()->baseUrl . '/vendor/bootstrap/js/bootstrap.min.js?' . $version, CClientScript::POS_END);
	$cs->registerScriptFile(Yii::app()->baseUrl . '/vendor/fancybox/source/jquery.fancybox.js?' . $version, CClientScript::POS_END);
	$cs->registerScriptFile(Yii::app()->baseUrl . '/vendor/fancybox/lib/jquery.mousewheel-3.0.6.pack.js', CClientScript::POS_END);
	$cs->registerScriptFile(Yii::app()->baseUrl . '/vendor/fancybox/source/helpers/jquery.fancybox-thumbs.js', CClientScript::POS_END);
	$cs->registerScriptFile(Yii::app()->baseUrl . '/vendor/fullcalendar/fullcalendar.min.js', CClientScript::POS_END);
	$cs->registerScriptFile(Yii::app()->baseUrl . '/vendor/touchpunch/jquery.ui.touch-punch.min.js', CClientScript::POS_END);
	$cs->registerScriptFile(Yii::app()->baseUrl . '/js/regular/overlay.js?' . $version, CClientScript::POS_END);
	$cs->registerScriptFile(Yii::app()->baseUrl . '/js/regular/calendars.js?' . $version, CClientScript::POS_END);
	$cs->registerScriptFile(Yii::app()->baseUrl . '/js/regular/auth.js', CClientScript::POS_END);
	$cs->registerScriptFile(Yii::app()->baseUrl . '/js/regular/header.js?' . $version, CClientScript::POS_END);
?>
<header>
	<nav class="navbar navbar-default">
		<a class="navbar-brand" href="#">Calendars</a>
		<a class="toggle-nav btn pull-left" href="#"> <i class="icon-reorder"></i> </a>
		<ul class="nav">
			<li class="dropdown light user-menu">
				<a class="dropdown-toggle" data-toggle="dropdown" href="#">
					<span class="user-name"><? echo Yii::app()->user->firstName . ' ' . Yii::app()->user->lastName; ?></span>
					<b class="caret"></b>
				</a>
				<ul class="dropdown-menu">
					<li>
						<a href="#" id="logout">
							<i class="icon-signout"></i>
							Sign out
						</a>
					</li>
				</ul>
			</li>
		</ul>
	</nav>
</header>
<div id="wrapper">
	<div id="main-nav-bg"></div>
	<nav id="main-nav">
		<div class="navigation">
		</div>
	</nav>
	<section id="content">
		<div class="container">
		</div>
	</section>
</div>

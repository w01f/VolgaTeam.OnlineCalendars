<?php
	/**
         * Released as Contao extension "browserdetection" 
         * Copyright (c) 2011 by Jan Theofel, jan@theofel.de 2010,2011 by ETES GmbH www.etes.de 
	 */

 if(version_compare(VERSION . '.' . BUILD, '2.10.0', '<'))
 {

	$GLOBALS['BROWSERDETECTION']['lists']['browsernames'][Browser::BROWSER_AMAYA]		= 'amaya';
	$GLOBALS['BROWSERDETECTION']['lists']['browsernames'][Browser::BROWSER_ANDROID]		= 'android';
	$GLOBALS['BROWSERDETECTION']['lists']['browsernames'][Browser::BROWSER_BLACKBERRY]	= 'blackberry';
	$GLOBALS['BROWSERDETECTION']['lists']['browsernames'][Browser::BROWSER_CHROME]		= 'chrome';
	$GLOBALS['BROWSERDETECTION']['lists']['browsernames'][Browser::BROWSER_FIREBIRD]	= 'firebird';
	$GLOBALS['BROWSERDETECTION']['lists']['browsernames'][Browser::BROWSER_FIREFOX]		= 'firefox';
	$GLOBALS['BROWSERDETECTION']['lists']['browsernames'][Browser::BROWSER_GOOGLEBOT]	= 'googlebot';
	$GLOBALS['BROWSERDETECTION']['lists']['browsernames'][Browser::BROWSER_ICAB]		= 'icab';
	$GLOBALS['BROWSERDETECTION']['lists']['browsernames'][Browser::BROWSER_ICECAT]		= 'icecat';
	$GLOBALS['BROWSERDETECTION']['lists']['browsernames'][Browser::BROWSER_ICEWEASEL]	= 'iceweasel';
	$GLOBALS['BROWSERDETECTION']['lists']['browsernames'][Browser::BROWSER_IE]		= 'ie';
	$GLOBALS['BROWSERDETECTION']['lists']['browsernames'][Browser::BROWSER_IPAD]		= 'ipad';
	$GLOBALS['BROWSERDETECTION']['lists']['browsernames'][Browser::BROWSER_IPHONE]		= 'iphone';
	$GLOBALS['BROWSERDETECTION']['lists']['browsernames'][Browser::BROWSER_IPOD]		= 'ipod';
	$GLOBALS['BROWSERDETECTION']['lists']['browsernames'][Browser::BROWSER_KONQUEROR]	= 'konqueror';
	$GLOBALS['BROWSERDETECTION']['lists']['browsernames'][Browser::BROWSER_LYNX]		= 'lynx';
	$GLOBALS['BROWSERDETECTION']['lists']['browsernames'][Browser::BROWSER_MOZILLA]		= 'mozilla';
	$GLOBALS['BROWSERDETECTION']['lists']['browsernames'][Browser::BROWSER_MSNBOT]		= 'msnbot';
	$GLOBALS['BROWSERDETECTION']['lists']['browsernames'][Browser::BROWSER_MSN]		= 'msn';
	$GLOBALS['BROWSERDETECTION']['lists']['browsernames'][Browser::BROWSER_NOKIA]		= 'nokia';
	$GLOBALS['BROWSERDETECTION']['lists']['browsernames'][Browser::BROWSER_NOKIA_S60]	= 's60nokia';
	$GLOBALS['BROWSERDETECTION']['lists']['browsernames'][Browser::BROWSER_OMNIWEB]		= 'omniweb';
	$GLOBALS['BROWSERDETECTION']['lists']['browsernames'][Browser::BROWSER_OPERA_MINI]	= 'operamini';
	$GLOBALS['BROWSERDETECTION']['lists']['browsernames'][Browser::BROWSER_OPERA]		= 'opera';
	$GLOBALS['BROWSERDETECTION']['lists']['browsernames'][Browser::BROWSER_POCKET_IE]	= 'iepocket';
	$GLOBALS['BROWSERDETECTION']['lists']['browsernames'][Browser::BROWSER_SAFARI]		= 'safari';
	$GLOBALS['BROWSERDETECTION']['lists']['browsernames'][Browser::BROWSER_SHIRETOKO]	= 'shiretoko';
	$GLOBALS['BROWSERDETECTION']['lists']['browsernames'][Browser::BROWSER_SLURP]		= 'slurp';
	$GLOBALS['BROWSERDETECTION']['lists']['browsernames'][Browser::BROWSER_W3CVALIDATOR]	= 'w3c';
	$GLOBALS['BROWSERDETECTION']['lists']['browsernames'][Browser::BROWSER_WEBTV]		= 'webtv';

	$GLOBALS['BROWSERDETECTION']['lists']['systemnames'][Browser::PLATFORM_ANDROID]		= 'android';
	$GLOBALS['BROWSERDETECTION']['lists']['systemnames'][Browser::PLATFORM_APPLE]		= 'apple';
	$GLOBALS['BROWSERDETECTION']['lists']['systemnames'][Browser::PLATFORM_BEOS]		= 'beos';
	$GLOBALS['BROWSERDETECTION']['lists']['systemnames'][Browser::PLATFORM_BLACKBERRY]	= 'blackberry';
	$GLOBALS['BROWSERDETECTION']['lists']['systemnames'][Browser::PLATFORM_FREEBSD]		= 'freebsd';
	$GLOBALS['BROWSERDETECTION']['lists']['systemnames'][Browser::PLATFORM_IPAD]		= 'ipad';
	$GLOBALS['BROWSERDETECTION']['lists']['systemnames'][Browser::PLATFORM_IPHONE]		= 'iphone';
	$GLOBALS['BROWSERDETECTION']['lists']['systemnames'][Browser::PLATFORM_IPOD]		= 'ipod';
	$GLOBALS['BROWSERDETECTION']['lists']['systemnames'][Browser::PLATFORM_LINUX]		= 'linux';
	$GLOBALS['BROWSERDETECTION']['lists']['systemnames'][Browser::PLATFORM_NETBSD]		= 'netbsd';
	$GLOBALS['BROWSERDETECTION']['lists']['systemnames'][Browser::PLATFORM_NOKIA]		= 'nokia';
	$GLOBALS['BROWSERDETECTION']['lists']['systemnames'][Browser::PLATFORM_OPENBSD]		= 'openbsd';
	$GLOBALS['BROWSERDETECTION']['lists']['systemnames'][Browser::PLATFORM_OPENSOLARIS]	= 'opensolaris';
	$GLOBALS['BROWSERDETECTION']['lists']['systemnames'][Browser::PLATFORM_OS2]		= 'os2';
	$GLOBALS['BROWSERDETECTION']['lists']['systemnames'][Browser::PLATFORM_SUNOS]		= 'sunos';
	$GLOBALS['BROWSERDETECTION']['lists']['systemnames'][Browser::PLATFORM_WINDOWS_CE]	= 'windowsce';
	$GLOBALS['BROWSERDETECTION']['lists']['systemnames'][Browser::PLATFORM_WINDOWS]		= 'windows';
 }
 else
 {
   $GLOBALS['TL_HOOKS']['outputFrontendTemplate'][] = array('Browser', 'obsolete');
 }

?>

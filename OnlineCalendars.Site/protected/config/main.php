<?php
	return array(
		'basePath' => dirname(__FILE__) . DIRECTORY_SEPARATOR . '..',
		'name' => 'Calbookit',
		'defaultController' => 'site',
		'preload' => array('log', 'browser'),
		'import' => array(
			'application.models.*',
			'application.models.calendars.*',
			'application.models.users.*',
			'application.components.*',
			'application.components.widgets.*',
			'application.components.core.*',
		),
		'components' => array(
			'session' => array(
				'autoStart' => true,
			),
			'user' => array(
				'loginUrl' => array('auth/login'),
				'allowAutoLogin' => true,
			),
			'errorHandler' => array(
				'errorAction' => 'site/error',
			),
			'urlManager' => array(
				'urlFormat' => 'path',
				'showScriptName' => false,
				'rules' => array(
					'<controller:\w+>/<id:\d+>' => '<controller>/view',
					'<controller:\w+>/<action:\w+>' => '<controller>/<action>',
				)
			),
			'log' => array(
				'class' => 'CLogRouter',
				'routes' => array(
					array(
						'class' => 'CFileLogRoute',
						'levels' => 'error, warning',
					),
				),
			),
			'browser' => array(
				'class' => 'application.extensions.browser.CBrowserComponent',
			),
			'cacheDB' => array(
				'class' => 'system.caching.CDbCache',
				'connectionID' => 'db',
				'autoCreateCacheTable' => true,
				'cacheTableName' => 'tbl_cache',
			),
			'email' => array(
				'class' => 'application.extensions.email.Email',
				'delivery' => 'php',
			),
		),
		'params' => require(dirname(__FILE__) . '/params.php'),
	);
<?php
return array(
    'basePath' => dirname(__FILE__) . DIRECTORY_SEPARATOR . '..',
    'name' => 'Calbookit Cron Daemon',
    'preload' => array('log'),
    'import' => array(
        'application.commands.*',
        'application.models.*',
		'application.models.calendars.*',
		'application.models.users.*',
        'application.components.*',
        'application.components.core.*',
    ),
    'components' => array(
        'db' => array(
            'connectionString' => 'mysql:host=localhost;dbname=calendars',
            'emulatePrepare' => true,
            'username' => 'root',
            'password' => 'root',
            'charset' => 'utf8',
            'autoConnect' => true,
            'tablePrefix' => 'tbl_',
            'schemaCachingDuration' => 3600,
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

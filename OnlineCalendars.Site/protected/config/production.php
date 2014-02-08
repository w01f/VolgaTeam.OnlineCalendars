<?php
return CMap::mergeArray(
        require(dirname(__FILE__) . '/main.php'), array(
        'behaviors' => array(
            'onBeginRequest' => array(
                'class' => 'application.components.core.RequireLogin'
            )
        ),
        'components' => array(
            'db' => array(
                'connectionString' => 'mysql:host=127.0.0.1;dbname=calendars',
                'emulatePrepare' => true,
                'charset' => 'utf8',
                'tablePrefix' => 'tbl_',
                'schemaCachingDuration' => 3600,
            ),
        ),
        )
);

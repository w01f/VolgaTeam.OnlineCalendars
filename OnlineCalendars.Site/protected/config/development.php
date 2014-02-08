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
                'connectionString' => 'mysql:host=localhost;dbname=calendars',
                'emulatePrepare' => true,
                'username' => 'root',
                'password' => 'root',
                'charset' => 'utf8',
                'autoConnect' => true,
                'tablePrefix' => 'tbl_',
                'schemaCachingDuration' => 3600,
            ),
        ),
        )
);

<?php
$webRoot = dirname(__FILE__);

ini_set("soap.wsdl_cache_dir",$webRoot."/protected/runtime");

if ($_SERVER['HTTP_HOST'] == 'localhost')
{
    define('YII_DEBUG', true);
    require_once($webRoot . '/yii/framework/yii.php');
}
else
{
    define('YII_DEBUG', false);
    require_once($webRoot . '/yii/framework/yii.php');
}
$app = Yii::createWebApplication($webRoot . '/configuration.php')->run();

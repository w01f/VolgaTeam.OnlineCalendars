<!DOCTYPE html>
<html>
    <head>
        <meta name="viewport" content="width=device-width, initial-scale=1.0" />
        <?php
        $cs = Yii::app()->clientScript;
        $cs->registerCoreScript('jquery');
        ?>
		<title><?php echo $this->pageTitle; ?></title>
    </head>
    <body>
        <?php echo $content; ?>
    </body>
</html>
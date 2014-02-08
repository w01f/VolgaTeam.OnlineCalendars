<? /* @var $content string */ ?>
<!DOCTYPE html>
<html>
<head>
	<meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=0"/>
	<?php Yii::app()->clientScript->registerCoreScript('jquery'); ?>
	<script type="text/javascript">
		BASE_URL = '<?php echo Yii::app()->getBaseUrl(true); ?>';
	</script>
	<title><?php echo $this->pageTitle; ?></title>
</head>
<body class="contrast-fb<? if (isset(Yii::app()->browser) && Yii::app()->browser->isMobile()): ?> mobile-body<? endif; ?>">
<?php echo $content; ?>
</body>
</html>
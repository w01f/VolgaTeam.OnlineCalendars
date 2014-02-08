<?
	/* @var $body string */
	/* @var $login string */
	/* @var $password string */
?>
<?php echo $body; ?>
	<br><br>
<?php
	echo Yii::app()->createAbsoluteUrl('auth/changePassword', array(
		'login' => $login,
		'password' => $password,
		'rememberMe' => false
	))
?>
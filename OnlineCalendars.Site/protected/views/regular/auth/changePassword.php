<?
	/* @var $formData ChangePasswordForm */
	/* @var $selectedCalendarId string */

	$version = '1.0';
	$cs = Yii::app()->clientScript;
	$cs->registerCssFile(Yii::app()->baseUrl . '/vendor/bootstrap/css/bootstrap.min.css?' . $version);
	$cs->registerCssFile(Yii::app()->baseUrl . '/vendor/fancybox/source/jquery.fancybox.css?' . $version);
	$cs->registerCssFile(Yii::app()->baseUrl . '/css/regular/popup-dialog.css?' . $version);
	$cs->registerCssFile(Yii::app()->baseUrl . '/css/regular/auth.css?' . $version);
	$cs->registerScriptFile(Yii::app()->baseUrl . '/vendor/bootstrap/js/bootstrap.js?' . $version, CClientScript::POS_END);
	$cs->registerScriptFile(Yii::app()->baseUrl . '/vendor/fancybox/source/jquery.fancybox.pack.js', CClientScript::POS_END);
	$cs->registerScriptFile(Yii::app()->baseUrl . '/js/regular/overlay.js?' . $version, CClientScript::POS_END);
	$cs->registerScriptFile(Yii::app()->baseUrl . '/js/regular/auth.js?' . $version, CClientScript::POS_END);

	/* @var $form CActiveForm */
	$form = $this->beginWidget('CActiveForm', array('action' => Yii::app()->createUrl('auth/changePassword'),
		'htmlOptions' => array(
			'role' => 'form')));
?>
<table id="form-login">
	<tr>
		<td colspan="2">
			<img src="<?php echo Yii::app()->baseUrl . '/images/common/logo.png'; ?>"/>
		</td>
	</tr>
	<tr>
		<td colspan="2">
			<br> You are logged as: <?php echo $formData->login ?>
			<br><b>Create your NEW Password for the site:</b>
			<?php
				echo $form->textField($formData, 'login'
					, array(
						'input type' => 'hidden',
						'class' => 'edit-field')
				);
				echo $form->textField($formData, 'oldPassword'
					, array(
						'input type' => 'hidden',
						'class' => 'edit-field')
				);
				echo $form->textField($formData, 'rememberMe'
					, array(
						'input type' => 'hidden',
						'class' => 'edit-field')
				);
			?>
		</td>
	</tr>
	<tr>
		<td colspan="2">
			<div class="form-group">
				<label>New Password:</label>
				<?php
					echo $form->textField($formData, 'newInitialPassword'
						, array(
							'input type' => 'Password',
							'id' => 'edit-field-password',
							'class' => 'form-control edit-field')
					);
				?>
			</div>
		</td>
	</tr>
	<tr>
		<td colspan="2">
			<div class="form-group">
				<label>Type Password Again:</label>
				<?php
					echo $form->textField($formData, 'newRepeatPassword'
						, array(
							'input type' => 'Password',
							'id' => 'edit-field-password-confirm',
							'class' => 'form-control edit-field')
					);
				?>
			</div>
		</td>
	</tr>
	<tr>
		<td colspan="2">
			<?php
				echo $form->error($formData, 'newInitialPassword'
					, array('class' => 'text-danger')
				);
				echo $form->error($formData, 'newRepeatPassword'
					, array('class' => 'text-danger')
				);
			?>
			<br>
		</td>
	</tr>
	<tr>
		<? if (Yii::app()->params['login']['complex_password']): ?>
			<td>
				<a id="password-requirements" class="btn btn-link">Password Requirements</a>
			</td>
		<? endif; ?>
		<td <? if (!Yii::app()->params['login']['complex_password']): ?>colspan="2"<? endif; ?>>
			<?php
				echo CHtml::submitButton('Save', array('id' => 'button-change-password', 'class' => 'btn btn-primary'));
			?>
		</td>
	</tr>
</table>
<?php $this->endWidget(); ?>


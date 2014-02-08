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
?>
<div id="content">
	<? if (Yii::app()->params['login']['forgotPasswordField']): ?>
		<a id="recover-password-link" href="#view-dialog-container">
			<img src="<?php echo Yii::app()->baseUrl . '/images/auth/forgot-password.png'; ?>" alt="Forgot Password?">
		</a>
	<? endif; ?>
	<?
		/* @var $form CActiveForm */
		$form = $this->beginWidget('CActiveForm', array(
			'action' => Yii::app()->createUrl('auth/login'),
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
				<div class="form-group">
					<?
						echo $form->textField($formData, 'login'
							, array(
								'placeholder' => 'Username',
								'id' => 'field-login',
								'class' => 'form-control edit-field')
						);
					?>
					<?php if (Yii::app()->browser->getBrowser() == 'Internet Explorer'): ?>
						<label for="field-login">Username:</label>
					<?php endif; ?>
				</div>
			</td>
		</tr>
		<tr>
			<td colspan="2">
				<div class="form-group">
					<?php
						echo $form->textField($formData, 'password'
							, array(
								'placeholder' => 'Password',
								'input type' => 'Password',
								'id' => 'field-password',
								'class' => 'form-control edit-field')
						);
					?>
					<?php if (Yii::app()->browser->getBrowser() == 'Internet Explorer'): ?>
						<label for="field-password">Password:</label>
					<?php endif; ?>
				</div>
			</td>
		</tr>
		<tr>
			<td colspan="2">
				<?php
					echo $form->error($formData, 'login'
						, array('class' => 'text-danger')
					);
					echo $form->error($formData, 'password'
						, array('class' => 'text-danger')
					);
				?>
				<br>
			</td>
		</tr>
		<? if (Yii::app()->params['login']['complex_password']): ?>
			<td colspan="2">
				<button id="password-requirements" class="btn btn-link">Password Requirements</button>
				<br><br>
			</td>
		<? endif; ?>
		<?php if (Yii::app()->params['login']['disclaimer']): ?>
			<tr>
				<td colspan="2">
					<div id="disclaimer-container" class="checkbox">
						<label class="checkbox"> <input id="disclaimer" type="checkbox" value="">
							<?php echo Yii::app()->params['login']['disclaimerText']; ?>
						</label>
					</div>
					<br> <br>
				</td>
			</tr>
		<?php endif; ?>
		<tr>
			<?php if (Yii::app()->params['login']['rememberMeField']): ?>
				<td>
					<div class="checkbox">
						<?
							echo $form->checkBox($formData, 'rememberMe'
								, array(
									'id' => 'field-remember')
							);
							echo $form->labelEx($formData, 'rememberMe',
								array(
									'id' => 'label-remember'));
						?>
					</div>
				</td>
			<?php endif; ?>
			<td>
				<?php
					echo CHtml::submitButton('Log In'
						, array('id' => 'button-login',
							'class' => 'btn btn-primary'
						));
				?>
			</td>
		</tr>
	</table>
	<?php $this->endWidget(); ?>
</div>
<div id="content-overlay">
</div>
<div id="view-dialog-wrapper">
	<div id="view-dialog-container">
	</div>
</div>



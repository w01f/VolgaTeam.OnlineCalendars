<table class="popup-dialog">
	<tr>
		<td>
			<legend>Password Recovery</legend>
		</td>
	</tr>
	<tr>
		<td>
			<div class="form-group">
				<label class="control-label" for="login">Enter your username:</label>
				<input type="text" class="form-control input-block-level" id="login" value="">
			</div>
		</td>
	</tr>
	<tr>
		<td>
			<div class="form-group">
				<label class="control-label" for="email">Enter your email address:</label>
				<input type="email" class="form-control input-block-level" id="email" value="">
			</div>
		</td>
	</tr>
	<tr>
		<td class="error-message text-danger">
		</td>
	</tr>
	<tr>
		<td class="buttons-area">
			<button class="btn btn-default" id="accept-button" type="button">Accept</button>
			<button class="btn btn-default" id="cancel-button" type="button">Cancel</button>
		</td>
	</tr>
	<tr>
		<td style="text-align: center;">
			<br><a href="mailto:<?php echo Yii::app()->params['email']['help_request_address']; ?>?subject=Site Help Request - <? echo Yii::app()->request->serverName; ?>"><b>Click Here</b></a> if you are
			<b>NOT</b> receiving<br>your site login email or to contact support.
		</td>
	</tr>
</table>
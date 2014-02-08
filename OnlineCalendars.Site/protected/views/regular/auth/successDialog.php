<?
	/**
	 * @var $content string
	 * @var $header string
	 */
?>
<table class="popup-dialog">
	<tr>
		<td colspan="2">
			<legend><?php echo $header; ?></legend>
			<div><?php echo $content; ?></div>
		</td>
	</tr>
	<tr>
		<td colspan="2" class="buttons-area">
			<button class="btn btn-primary" id="accept-button" type="button">OK</button>
		</td>
	</tr>
</table>
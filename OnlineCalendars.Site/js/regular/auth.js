(function ($)
{
	var AuthController = function ()
	{
		this.updateLoginBodyPosition = function ()
		{
			var formLogin = $('#form-login');
			var top = ($(window).height() - formLogin.height()) / 2;
			var left = ($(window).width() - formLogin.width()) / 2;
			formLogin.css({
				'left': left + 'px'
			});
			formLogin.css({
				'top': top + 'px'
			});
		};

		this.checkComplexPassword = function (password)
		{
			if (password.length < 8)
				return false;
			var conditionPass = 0;
			if (password.match(/.*[0-9]+/))
				conditionPass++;
			if (password.match(/.*[a-z]+/))
				conditionPass++;
			if (password.match(/.*[A-Z]+/))
				conditionPass++;
			if (password.match(/.*\W+/))
				conditionPass++;
			return conditionPass >= 3;
		};

		this.logout = function ()
		{
			$.ajax({
				type: "POST",
				url: BASE_URL+"/auth/logout",
				data: {
				},
				beforeSend: function ()
				{
					$.showOverlayLight();
				},
				complete: function ()
				{
				},
				success: function ()
				{
					location.reload();
				},
				error: function ()
				{
				},
				async: true,
				dataType: 'html'
			});
		};

		this.recoverPassword = function ()
		{
			$.ajax({
				type: "POST",
				url: BASE_URL+"/auth/recoverPasswordDialog",
				data: {},
				beforeSend: function ()
				{
					$.showOverlay();
				},
				complete: function ()
				{
					$.hideOverlay();
				},
				success: function (msg)
				{
					var content = $(msg);
					content.find('#accept-button').off('click').on('click', function ()
					{
						$.ajax({
							type: "POST",
							url: BASE_URL+"/auth/validateUserByEmail",
							data: {
								login: content.find('#login').val(),
								email: content.find('#email').val()
							},
							beforeSend: function ()
							{
								$.showOverlay();
							},
							complete: function ()
							{
								$.hideOverlay();
							},
							success: function (msg)
							{
								if (msg != '')
									content.find('.error-message').html(msg);
								else
								{
									$.ajax({
										type: "POST",
										url: BASE_URL+"/auth/recoverPassword",
										data: {
											login: content.find('#login').val()
										},
										success: function ()
										{
											$.fancybox.close();
											$.ajax({
												type: "POST",
												url: BASE_URL+"/auth/recoverPasswordDialogSuccess",
												data: {},
												beforeSend: function ()
												{
													$.showOverlay();
												},
												complete: function ()
												{
													$.hideOverlay();
												},
												success: function (msg)
												{
													var content = $(msg);
													content.find('#accept-button').off('click');
													content.find('#accept-button').on('click', function ()
													{
														$.fancybox.close();
													});
													$.fancybox({
														content: content,
														title: 'Password recovery',
														openEffect: 'none',
														closeEffect: 'none'
													});
												},
												error: function ()
												{
												},
												async: true,
												dataType: 'html'
											});
										},
										async: true,
										dataType: 'html'
									});
								}
							},
							error: function ()
							{
								content.find('#error-message').html('Error while validating user. Try again or contact to technical support');
							},
							async: true,
							dataType: 'html'
						});
					});
					content.find('#cancel-button').off('click');
					content.find('#cancel-button').on('click', function ()
					{
						$.fancybox.close();
					});
					$.fancybox({
						content: content,
						title: 'Password recovery',
						openEffect: 'none',
						closeEffect: 'none'
					});
				},
				error: function ()
				{
				},
				async: true,
				dataType: 'html'
			});
		};
	};
	$(document).ready(function ()
	{
		$.AuthController = new AuthController();

		$('#recover-password-link').fancybox().off('click').on('click', function ()
		{
			$.AuthController.recoverPassword();
		});

		$('#password-requirements').off('click').on('click', function (event)
		{
			$.fancybox({
				content: $('<div style="text-align: center">' +
					'Password MUST Be AT LEAST 8 characters<br><br>' +
					'Must contain at least 3 of these 4 conditions below:<br><br>' +
					'<b>1 CAPITAL LETTER</b><br>' +
					'<b>1 lower case letter</b><br>' +
					'<b>Number (1, 2, 3…)</b><br>' +
					'<b>Symbols (!, @, #...)</b><br><br>' +
					'<button class="btn btn-default" style="width: 80px;" onclick="$.fancybox.close()">OK</a>' +
					'</div>'),
				title: 'Password Requirements',
				width: 350,
				autoSize: false,
				autoHeight: true,
				openEffect: 'none',
				closeEffect: 'none'
			});
			event.stopPropagation();
			event.preventDefault();
		});

		$('#button-change-password').off('click').on('click', function (event)
		{
			var passwordRequirements = $('#password-requirements');
			if (passwordRequirements.length)
			{
				var passwordFiled = $('#edit-field-password');
				if (!$.AuthController.checkComplexPassword(passwordFiled.val()))
				{
					event.preventDefault();
					event.stopPropagation();
					passwordFiled.val('');
					$('#edit-field-password-confirm').val('');
					passwordRequirements.trigger('click');
				}
			}
		});

		$('#button-login').off('click').on('click', function (event)
		{
			if ($('#disclaimer').length && !$("#disclaimer").attr('checked'))
			{
				event.preventDefault();
				event.stopPropagation();
				$.ajax({
					type: "POST",
					url: BASE_URL+"/auth/disclaimerWarning",
					data: {},
					beforeSend: function ()
					{
						$.showOverlay();
					},
					complete: function ()
					{
						$.hideOverlay();
					},
					success: function (msg)
					{
						var content = $(msg);
						content.find('#accept-button').off('click');
						content.find('#accept-button').on('click', function ()
						{
							$.fancybox.close();
						});
						$.fancybox({
							content: content,
							title: 'Confirmation Needed!',
							width: 450,
							autoSize: false,
							autoHeight: true,
							openEffect: 'none',
							closeEffect: 'none'
						});
					},
					error: function ()
					{
					},
					async: true,
					dataType: 'html'
				});
			}
		});
		$.AuthController.updateLoginBodyPosition();
		$(window).on('resize', $.AuthController.updateLoginBodyPosition);
	});
})(jQuery);
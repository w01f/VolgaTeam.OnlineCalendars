<?php
class RequireLogin extends CBehavior
{
    public function attach($owner)
    {
        $owner->attachEventHandler('onBeginRequest', array($this, 'handleBeginRequest'));
    }

    public function handleBeginRequest()
    {
        if (Yii::app()->user->isGuest &&
			!strstr(Yii::app()->request->getUrl(), 'auth/') &&
			!strstr(Yii::app()->request->getUrl(), 'users/'))
        {
            Yii::app()->user->loginRequired();
        }
    }

}


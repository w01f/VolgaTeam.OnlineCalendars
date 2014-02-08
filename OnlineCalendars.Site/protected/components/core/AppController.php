<?php
class AppController extends CController
{
    public $browser;
    public $pathPrefix;
    public $isTabletMobileView;
    public function init()
    {
		$this->browser = Yii::app()->browser->getBrowser();
		//$this->browser = Browser::BROWSER_IPHONE;
        switch ($this->browser)
        {
            case Browser::BROWSER_IPHONE:
            case Browser::BROWSER_ANDROID_MOBILE:
                $this->layout = '/phone/layouts/main';
                $this->pathPrefix = 'application.views.phone.';
                $this->isTabletMobileView = false;
                break;
            default :
                $version = Yii::app()->cacheDB->get('siteVersion');
                if (Yii::app()->browser->isMobile() && isset($version) && $version == 'mobile')
                {
                    $this->layout = '/phone/layouts/main';
                    $this->pathPrefix = 'application.views.phone.';
                    $this->isTabletMobileView = true;
                }
                else
                {
                    $this->layout = '/regular/layouts/main';
                    $this->pathPrefix = 'application.views.regular.';
                    $this->isTabletMobileView = false;
                }
                $cookie = new CHttpCookie('mobileDeviceUsed', Yii::app()->browser->isMobile() ? "true" : "false");
                $cookie->expire = time() + (60 * 60 * 24 * 7);
                Yii::app()->request->cookies['mobileDeviceUsed'] = $cookie;
                break;
        }
    }

}

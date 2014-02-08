(function( $ ) {
    $.showOverlay = function(){
        $('#content-overlay').css({
            'width':$(window).width()+'px'
        }).css({
            'height':$(window).height()+'px'
        }).fadeIn(0);
        $("<div id=\"fancybox-loading\"><div></div></div>").appendTo('body');
    };
    $.hideOverlay = function(){
        $('#fancybox-loading').remove(); 
        $('#content-overlay').fadeOut(0);
        $('#ribbon').fadeIn(0);
    };
    $.showOverlayLight = function(){
        $('<div id="fancybox-loading"><div></div></div>').appendTo('body'); 
    };
    $.hideOverlayLight = function(){
        $('#fancybox-loading').remove(); 
    };
})( jQuery );    



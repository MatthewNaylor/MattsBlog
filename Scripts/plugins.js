
// Start Function
(function($, window, document, undefined) {

    'use strict';
    // init cubeportfolio
    $('#posts').cubeportfolio({
        filters: '#posts-filter',
        loadMore: '#more-posts',
        loadMoreAction: 'click',
        layoutMode: 'masonry',
        defaultFilter: '*',
        mediaQueries: [{
            width: 1500,
            cols: 4
        }, {
            width: 800,
            cols: 3,
        }, {
            width: 600,
            cols: 2,
        }, {
            width: 640,
            cols: 2
        }, {
            width: 480,
            cols: 1,
            gapHorizontal: 0,
            gapVertical: 0
        }],
        animationType: 'quicksand',
        gapHorizontal: 30,
        gapVertical: 30,
        gridAdjustment: 'responsive',
        caption: 'zoom',
        displayType: 'sequentially',
        displayTypeSpeed: 100
    });
    // End Portfolio Scripts


    $('.announcement span.close-btn').on('click', function(){
        var item = $('.announcement');
        $(item).fadeOut();
        setTimeout( function(){$('#post-container').addClass('announcement-closed')},550);
    });

    $('#add_comment').click(function() {
        setTimeout( function(){ $('#message').focus(); },350);
    });

    //Check where i am when click on the filters
    $('#posts-filter .cbp-filter-item').on('click', function(){
        var position = $('#posts-filter').offset().top - $('#post-container').offset().top,
            max = 400, min = -50;
        if ( position > max || position < min) {
            $('html, body').stop().animate({
                scrollTop : $('#post-container').offset().top - 80 + "px"
            }, 1150, 'easeInOutExpo');
        }
    });

// End Function
})(jQuery, window, document);

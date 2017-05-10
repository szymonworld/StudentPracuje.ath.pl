$(document).ready(function () {

    var descMinHeight = 120;
    var desc = $('.desc');
    var descWrapper = $('.desc-wrapper');

    // show more button if desc too long
    if (desc.height() > descWrapper.height()) {
        $('.more-info').show();
    }

    // When clicking more/less button
    $('.more-info').click(function () {

        var fullHeight = $('.desc').height();

        if ($(this).hasClass('expand')) {
            // contract
            $('.desc-wrapper').animate({ 'height': descMinHeight }, 'slow');
        }
        else {
            // expand 
            $('.desc-wrapper').css({ 'height': descMinHeight, 'max-height': 'none' }).animate({ 'height': fullHeight }, 'slow');
        }

        $(this).toggleClass('expand');
        return false;
    });

});
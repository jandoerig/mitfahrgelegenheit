$(document).ready(function () {
    $('.listing-car').click(function () {
        $('.listing-car').not(this).removeClass('activeCar');
        $(this).toggleClass('activeCar');
    });
});
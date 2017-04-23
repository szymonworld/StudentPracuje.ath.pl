//Pojawianie sie dodatkowych pol po wyboraniu z select listy
$(function () {
    $("#AccountType").on("change", function () {
        if (parseInt($("#AccountType").val()) == 1) {
            $("#studentProp").show();
        } else {
            $("#studentProp").hide();
        }
    });
    $("#AccountType").trigger("change");
});

//Date picker
$(function () {
    $('.date-picker').datepicker(
        {
            dateFormat: 'yy-mm-dd'
        }
    );
})
﻿jQuery.validator.addMethod("pastdate", function (value, element, param) {
    //get date entered by user, confirm it's a date
    if (value === '') return false;
    var dateToCheck = new Date(value);
    if (dateToCheck === "Invalid Date") return false;

    //get number of years
    var numYears = Number(param);

    //get current date
    var now = new Date();

    //check date
    if (numYears == -1) {
        if (dateToCheck < now) return true;
    } else {
        //calculate date limit
        var minDate = new Date();
        var minYear = now.getFullYear() - numYears;
        minDate.setFullYear(minYear);

        if (dateToCheck >= minDate && dateToCheck < now) return true;
    }
    return false;
});

jQuery.validator.unobtrusive.adapters.addSingleVal("pastdate", "numyears");
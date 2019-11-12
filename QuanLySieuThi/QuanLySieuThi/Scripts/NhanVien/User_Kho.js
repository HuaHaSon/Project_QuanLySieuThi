$(document).ready(function () {
    checkCookie() == false ? window.location.href = "/Login/Index" : true;

    checkRole("User_Kho") ? true : window.location.href = "/Login/Index";
});
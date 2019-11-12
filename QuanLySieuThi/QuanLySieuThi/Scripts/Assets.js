function parseJwt(token) {
    if (token != null) {
        var base64Url = token.split('.')[1];
        var base64 = base64Url.replace(/-/g, '+').replace(/_/g, '/');
        var jsonPayload = decodeURIComponent(atob(base64).split('').map(function (c) {
            return '%' + ('00' + c.charCodeAt(0).toString(16)).slice(-2);
        }).join(''));
        return JSON.parse(jsonPayload);
    }
    return null;
}

function customAlert(title, type, showConfirmButton, timer) {
    Swal.fire({
        position: 'center',
        type: type,
        title: title,
        showConfirmButton: showConfirmButton,
        timer: timer
    });
}
function alert_btnOK(title) {
    Swal.fire(title)
}
function checkCookie() {
    const rs = Cookies.get("User_token");
    return (rs == null || rs == undefined) ? false : true; //exist
}

function checkRole(role) {
    const rs = JSON.parse(Cookies.get("User_info"));

    return rs.role.findIndex(e => e == role) != -1;
}

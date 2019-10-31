$(document).ready(function () {
    $("#form").on("submit", function (e) {
        e.preventDefault();
        if ($("#tk").val() == "" || $("#pwd").val() == "")
            alert("Vui lòng nhập thông tin đăng nhập!");
        else {
            var TK = { "TenTK": $("#tk").val(), "MatKhau": $("#pwd").val() };
            $.ajax({
                url: "/Login/LoginTK",
                method: "POST",
                data: JSON.stringify(TK),
                dataType: "json",
                contentType: "application/json",
                success: function (data) {
                    if (data.TenQuyen == "User_Kho" || data.TenQuyen=="User_BanHang") {
                        alert("Đăng nhập thành công!");
                        window.location = "/NhanVienHome/Index";
                    }
                    else
                        alert("Tài khoản không tồn tại!");
                },
                error: function () {
                    alert("Đăng nhập không thành công")
                }
            });
        }
    });
    $('#logout').click(function () {
        $.ajax({
            url: "/Login/LogoutTK",
            method: "POST",
            dataType: "json",
            contentType: "application/json",
            success: function (data) {
                window.location = "/Login/Index";
            },
            error: function () {
                alert("Đăng xuất thất bại");
            }
        });
    });
});

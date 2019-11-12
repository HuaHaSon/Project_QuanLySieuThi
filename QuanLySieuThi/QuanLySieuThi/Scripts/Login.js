$(document).ready(function () {
    $("#form").on("submit", function (e) {
        e.preventDefault();
        if ($("#tk").val() == "" || $("#pwd").val() == "")
            alert_btnOK("Thông tin đăng nhập thiếu!");
        else {
            var TK = {
                username: $("#tk").val(),
                password: $("#pwd").val(),
                grant_type: "password"
            };          
            $.ajax({
                url: Config.HOST+"oauth2/token",
                type: "POST",
                data: TK,
                success: function (data) {                                        
                    Cookies.set("User_token", data.access_token, { expires: 1 / 24 / 1});
                    var rs = parseJwt(data.access_token);
                    Cookies.set("User_info", rs, { expires: 1 / 24 / 1 });


                    if (rs.role.findIndex(e => e == "Admin") !=-1) {
                        customAlert("Đăng nhập thành công", "success", false, 1500);
                        window.location = "/NhanVienBanHang/Index";
                    }
                    else if (rs.role.findIndex(e => e == "User_BanHang") != -1) {
                        customAlert("Đăng nhập thành công", "success", false, 1500);
                        window.location = "/NhanVienBanHang/Index";
                    }
                    else if (rs.role.findIndex(e => e == "User_ThongKe") != -1) {
                        customAlert("Đăng nhập thành công", "success", false, 1500);
                        window.location = "/NhanVienThongKe/Index";
                    }
                    else if (rs.role.findIndex(e => e == "User_Kho") != -1) {
                        customAlert("Đăng nhập thành công", "success", false, 1500);
                        window.location = "/NhanVienKho/Index";
                    }
                    else 
                        customAlert("Tài khoản chưa được phân quyền", "error", true, 1500);
                    
                        
                },
                error: function () {
                    customAlert("Tài khoản hoặc mật khẩu không đúng", "error", true, 1500);
                }
            });
        }
    });
    
});

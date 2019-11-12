$(document).ready(function () {
    var url = new URL(window.location.href);
    var sanphams = [];
    sanphams = load_sanpham();
    const id = url.searchParams.get("id");   
    function load_sanpham() {
        var token = Cookies.get("User_token");
        var data = [];
        $.ajax({
            url: Config.HOST + "api/sanpham/GetAll",
            headers: {
                "Authorization": `Bearer ${token}`,
            },
            method: "GET",
            async: false,
            contentType: "application/json",
            success: function (result) {
                data = result;
            },
            error: function () {

            }
        });
        return data;
    }
    function GiaBan(id) {
        var token = Cookies.get("User_token");
        var giaban;
        $.ajax({
            url: Config.HOST + "api/hoadon/GiaBan/" + id,
            headers: {
                "Authorization": `Bearer ${token}`,
            },
            method: "POST",
            async: false,
            contentType: "application/json",
            success: function (result) {
                giaban = result;
            },
            error: function () {

            }
        });
        return giaban;
    }



    var store = new DevExpress.data.CustomStore({       
        load: function () {
            var deferred = $.Deferred();
            var token = Cookies.get("User_token");
            $.ajax({
                url: "http://localhost:64549/api/hoadon/ListCTHD/" + id,
                headers: {
                    "Authorization": `Bearer ${token}`,
                },
                method: "POST",
                contentType: "application/json",
                success: function (result) {
                    deferred.resolve(result);
                    var sum = 0;
                    for (var i = 0; i < result.length; i++) {
                        sum += result[i].DonGia * result[i].SLBan;
                    }
                    $("#tongtien").val(sum);
                },
                error: function () {
                    deferred.reject("Lỗi hiển thị dữ liệu");
                },
            });
            return deferred.promise();
        }
    });



    $("#grid").dxDataGrid({
        dataSource: store,
        showBorders: true,
        hoverStateEnabled: true,
        noDataText: "Không có dữ liệu",
        allowColumnResizing: true,
        paging: {
            pageSize: 10
        },
        pager: {
            showPageSizeSelector: true,
            allowedPageSizes: [5, 10, 20],
            showInfo: true
        },
        filterPanel: {
            customizeText: null,
            filterEnabled: true,
            texts: {},
            visible: false
        },
        columns: [
            {
                caption: "Tên sản phẩm",
                cssClass: "cell-highlighted",
                cellTemplate: function (t, options) {
                    return $("<div>").append(sanphams[sanphams.findIndex(e => e.id == options.row.data.MaSP)].TenSP);
                }
            },
            {
                dataField:"DonGia",
                caption: "Đơn giá",
                cssClass: "cell-highlighted",                
            },
            {
                caption: "Số lượng bán",
                dataField: "SLBan",
                cssClass: "cell-highlighted"
            }
        ],
    });  






});
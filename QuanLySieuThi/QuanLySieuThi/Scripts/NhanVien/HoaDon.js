$(document).ready(function () {
    var result_tkhoadon, idhd;
    
    var data = {
        id: "",
        NgayHD: "",
        TongTien: ""
    }
    function cleardata() {
        data = {
            id: "",
            NgayHD: "",
            TongTien: ""
        }
    }
    function SearchHD(ngayhd) {
        var deferred = $.Deferred();
        var token = Cookies.get("User_token");
        $.ajax({
            url: "http://localhost:64549/api/hoadon/Search?ngayhd=" + ngayhd,
            headers: {
                "Authorization": `Bearer ${token}`,
            },
            method: "POST",
            contentType: "application/json",
            success: function (result) {
                result_tkhoadon = result
                deferred.resolve(result_tkhoadon);
            },
            error: function () {
                deferred.reject("Lỗi hiển thị dữ liệu");
            },
        });
        return deferred.promise();
    }
    $("#form").dxForm({
        formData: data,
        items: [
            {
                itemType: "group",
                title: "Thông tin hóa đơn",
                colSpan: 2,
                colCount: 4,
                items:
                    [
                        {
                            dataField: "id",
                            editorType: "dxTextBox",
                            editorOptions: {
                            },
                            visible: false
                        },
                        {
                            colSpan: 3,
                            dataField: "NgayHD",
                            label: {
                                text: "Ngày hóa đơn"
                            },
                            editorType: "dxDateBox",
                            editorOptions: {}

                        }

                    ]
            },
            {
                itemType: "group",
                colSpan: 2,
                colCount: 10,
                items:
                    [
                        { itemType: "empty", colSpan: 3 },
                        {
                            itemType: "button",
                            colSpan: 1,
                            buttonOptions: {
                                type: "danger",
                                text: "Thêm hóa đơn",
                                onClick: function () {
                                    window.location.href = "/NhanVienBanHang/ThemHD";
                                }
                            }
                        },
                        {
                            itemType: "button",
                            colSpan: 1,
                            buttonOptions: {
                                type: "success",
                                text: "Tìm kiếm",
                                onClick: function () {
                                    SearchHD(data.NgayHD.toLocaleDateString());
                                    setTimeout(function () {
                                        $("#grid").dxDataGrid("instance").option("dataSource", result_tkhoadon);
                                    }, 200);

                                }
                            }
                        },
                        {
                            itemType: "button",
                            colSpan: 1,
                            buttonOptions: {
                                type: "default",
                                text: "Làm mới",
                                onClick: function () {
                                    cleardata();
                                    $("#form").dxForm("option", "formData", data);
                                }
                            }
                        },
                        { itemType: "empty", colSpan: 4 }]
            }
        ]
    });
   var store = new DevExpress.data.CustomStore({
        key: "id",
        load: function () {
            var deferred = $.Deferred();
            var token = Cookies.get("User_token");
            $.ajax({
                url: "http://localhost:64549/api/hoadon/GetAll",
                headers: {
                    "Authorization": `Bearer ${token}`,
                },
                method: "GET",
                contentType: "application/json",
                success: function (result) {
                    deferred.resolve(result);
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
                dataField: "id",
                width: 350,
                cssClass: "cell-highlighted"
            },
            {
                dataField: "NgayHD",
                cssClass: "cell-highlighted",
                cellTemplate: function (t, options) {
                    var d = moment(new Date(options.row.data.NgayHD)).format("DD/MM/YYYY");
                    return $("<div>").append(d);
                }
            },
            {
                dataField: "TongTien",
                cssClass: "cell-highlighted"
            },          
            {
                width: 150,
                alignment:"center",
                cellTemplate: function (t, e) {
                    return $("<div>").dxButton({
                        type: "default",
                        text: "Chi tiết",
                        icon: "info",
                        onClick: function () {

                            //ngayhd = e.row.data.NgayHD;

                            window.location = "/NhanVienBanHang/CTHoaDon?id=" + e.row.key;

                        }
                    });
                }
            }],
    });


     
    

        
   
        
        

});
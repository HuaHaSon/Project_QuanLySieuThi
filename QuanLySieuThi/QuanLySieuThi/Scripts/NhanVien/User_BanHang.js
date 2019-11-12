$(document).ready(function () {
   
    var result_slton, idsp, tensp, mota,result_tkhoadon;
    var idhd_cthd;
    var content_popup;
    var data = {
        id: "",
        TenSP: "",
        MoTa: ""
    }    
    function cleardata() {
        data = {
            id: "",
            TenSP: "",
            MoTa: ""
        }
    }     
    var data_sp = new DevExpress.data.CustomStore({
        key: "id",
        load: function () {
            var deferred = $.Deferred();
            var token = Cookies.get("User_token");
            $.ajax({
                url: Config.HOST+"api/sanpham/Search",
                headers: {
                    "Authorization": `Bearer ${token}`,
                },
                data: JSON.stringify(data),
                method: "POST",
                dataType: "json",
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



    $("#gridsanPham").dxDataGrid({
        dataSource: data_sp,
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
                dataField: "stt",
                width: 100,
                caption:"STT",
                alignment: "center",
                cssClass: "cell-highlighted",
                cellTemplate: function (t,options) {
                    return $("<div>").append(options.rowIndex +1);
                }
            },
            {
                dataField: "TenSP",
                caption: "Tên sản phẩm",
                alignment: "left",
                cssClass: "cell-highlighted"
            },
            {
                dataField: "MoTa",
                caption:"Mô tả",
                alignment: "left",
                cssClass: "cell-highlighted"
            },            
            {
                width: 100,
                cellTemplate: function (t, e) {
                    return $("<div>").dxButton({
                        type: "default",
                        text: "Chi tiết",
                        icon: "info",
                        onClick: function () {                           
                            popup_info(e.row.data,SLTon(e.row.key));
                            
                        }
                    });
                }
            }],
    });
    $("#show_search").dxForm({
        formData: data,
        items: [{
            itemType: "group",
            title: "Thông tin tìm kiếm",
            colSpan: 2,
            colCount: 2,
            items: [{
                dataField: "id",
                editorType: "dxTextBox",
                editorOptions: {
                },
                visible: false
            },
            {
                colSpan: 1,
                dataField: "TenSP",
                label: {
                    text: "Tên sản phẩm"
                },
                editorType: "dxTextBox",
                editorOptions: {}

            },
            {
                colSpan: 1,
                label: {
                    text: "Mô tả"
                },
                dataField: "MoTa",
                editorType: "dxTextArea",
                editorOptions: {
                    autoResizeEnabled: true
                }
            }]
        }, {
            itemType: "group",
            colSpan: 2,
            colCount: 10,
            items: [{ itemType: "empty", colSpan: 4 }, {
                itemType: "button",
                colSpan: 1,
                buttonOptions: {
                    type: "danger",
                    text: "Tìm",
                    onClick: function () {
                        $("#gridsanPham").dxDataGrid("refresh");
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
                        $("#show_search").dxForm("option", "formData", data);
                    }
                },
            },
            { itemType: "empty", colSpan: 4 }]
        }]
    });

    function popup_info(data,slton) {
        $("#popup_info").dxPopup({
            maxHeight: 400,
            maxWidth: 1000,
            hoverStateEnabled: true,
            contentTemplate: function () {
                var content_popup = `
                    <div class="row">
                        <div class="col-lg-8">
                            <h4>Tên sản phẩm: ${data.TenSP}</h4>
                            <h4>Mô tả: ${data.MoTa}</h4>
                            <h4>Số lượng tồn: ${slton}</h4>
                        </div>
                        <div class="col-lg-4">
                            <img src="${data.UrlImage}" height="300" width="auto"/>
                        </div>
                    </div>
                    
                    `;
                
                return content_popup;
            },
            title: "Thông tin sản phẩm",
            showTitle: true
        });
        $("#popup_info").dxPopup("show");
    }

    function SLTon(id) {
        var defered = null;
        var token = Cookies.get("User_token");
        $.ajax({
            url: "http://localhost:64549/api/sanpham/GetSLTon/" + id,
            method: "POST",
            headers: {
                "Authorization": `Bearer ${token}`,
            },
            async: false,
            contentType: "application/json",
            success: function (data) {
                defered = data;              
            },
            error: function () {
 
            }
        });
        return defered;
    }


    
});













    

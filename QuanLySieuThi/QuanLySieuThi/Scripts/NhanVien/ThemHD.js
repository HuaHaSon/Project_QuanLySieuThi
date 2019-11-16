$(document).ready(function () {
    var store = {
        TenSP: "",
        DonGia: "",
        SLBan: ""
    }

    var sp_ncc = new DevExpress.data.CustomStore({
        key: "id",
        load: function () {
            var deferred = $.Deferred();
            var token = Cookies.get("User_token");
            $.ajax({
                url: Config.HOST + "api/nhacungcap/GetNCC_SP",
                headers: {
                    "Authorization": `Bearer ${token}`,
                },
                method: "GET",
                async: false,
                contentType: "application/json",
                success: function (result) {
                    deferred.resolve(result);
                },
                error: function () {
                    deferred.reject("Lỗi hiển thị dữ liệu");
                }
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
        filterPanel: {
            customizeText: null,
            filterEnabled: true,
            texts: {},
            visible: false
        },
        columns: [
            {
                dataField:"TenSP",
                caption: "Tên sản phẩm",
                cssClass: "cell-highlighted",                
            },
            {
                dataField: "TenNCC",
                caption: "Tên nhà cung cấp",
                cssClass: "cell-highlighted",
            },
            {
                dataField: "DonGia",
                caption: "Đơn giá",
                cssClass: "cell-highlighted",
            },
            {
                alignment:"left",
                caption: "Số lượng",
                dataField: "SLBan",              
                cssClass: "cell-highlighted"
            }
        ],
        onToolbarPreparing: function (e) {
            var toolbarItems = e.toolbarOptions.items;
             toolbarItems.push({
                 widget: 'dxButton',
                 options: {
                     icon: 'add',
                     onClick: function () {
                         init_popup({});
                     }
                 },
                 location: 'after'
             });
        },
    }); 

    function init_popup(_data) {
        $("#popup_edit").dxPopup({
            title: "Chi tiết hồ sơ",
            position: "center",
            maxHeight: 800,
            minWeight: 800,
            closeOnOutsideClick: true,
            contentTemplate: function (e) {
                return $("<div id='form_edit'>").dxForm({
                    data: _data,
                    items: [{
                        itemType: "group",
                        caption: "",
                        colCount: 2,
                        colSpan: 2,
                        items: [
                            {
                                dataField: "TenSP",
                                colSpan: 1,
                                editorType: "dxSelectBox",
                                label: {
                                    text: "Tên sản phẩm"
                                },
                                editorOptions: {
                                    dataSource: sp_ncc,
                                    valueExpr: "id",
                                    displayExpr: "TenSP",
                                    placeholder: "Chọn sản phẩm...",
                                    onSelectionChanged: function (e) {
                                        alert(e.selectedItem.MaSP + e.selectedItem.MaNCC);
                                    },
                                    itemTemplate: function (itemData, itemIndex, itemElement) {
                                        return $("<div/>").append(itemData.TenSP + "-" + itemData.TenNCC);
                                    }
                                }

                            },
                            {
                                dataField: "SLTon",
                                label: {
                                    text: "Số lượng tồn"
                                },
                                editorType: "dxNumberBox",
                                editorOptions: {
                                    readOnly: true
                                }
                            }, {
                                dataField: "SLBan",
                                label: {
                                    text: "Số lượng bán"
                                },
                                editorType: "dxNumberBox",
                                editorOptions: {

                                }
                            }, {
                                dataField: "GiaBan",
                                label: {
                                    text: "Giá bán"
                                },
                                editorType: "dxNumberBox",
                                editorOptions: {
                                    readOnly: true
                                }
                            }
                        ]
                    }
                    ]
            });
            }
        });
        $("#popup_edit").dxPopup("show");
    }

    

    
});
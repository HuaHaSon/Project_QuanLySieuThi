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
        editing: {
            allowAdding: true,
            mode: "popup",
            form: {
                items: [{
                    itemType: "group",
                    caption:"",
                    items: [
                        {
                            dataField: "TenSP", 
                            editorType: "dxSelectBox",
                            label: {
                                text:"Tên sản phẩm"
                            },
                            editorOptions: {
                                dataSource: sp_ncc,
                                valueExpr: "id",
                                displayExpr: "TenSP",
                                placeholder: "Chọn sản phẩm...",
                                onSelectionChanged: function (e) {
                                    alert(e.selectedItem.MoTa);
                                },
                                itemTemplate: function (itemData, itemIndex, itemElement) {
                                    return $("<div/>").append(itemData.TenSP + "-" + itemData.TenNCC);
                                }
                            }
                            
                        },                     
                        {
                            dataField: "SLBan",
                            label: {
                                text:"Số lượng"
                            },
                            editorType: "dxNumberBox",
                        }
                    ]
                },
                    {
                        itemType: "group", 
                        caption:"",
                        items: [
                            {
                                dataField: "GiaBan",
                                label: {
                                    text:"Giá bán"
                                },
                                editorType: "dxNumberBox",
                                editorOptions: {
                                    readOnly: true
                                }
                            },
                         ]
                    }
                ]
            },
            texts: {
                addRow: "Thêm sản phẩm",              
                cancelRowChanges: "Hủy",               
                saveRowChanges: "Thêm"
                
            },
            
        }
    }); 

    
});
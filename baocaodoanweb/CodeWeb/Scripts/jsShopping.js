$(document).ready(function () {
    ShowCount();
    $('body').on('click', '.btnThemVaoGioHang', function (e) {
        e.preventDefault();
        var id = $(this).data('id');
        var soLuong = 1;
        var tSoLuong = $('#quantity_value').text();
        if (tSoLuong != '') {
            soLuong = parseInt(tSoLuong);
        }

        //alert(id + " " + soLuong);
        $.ajax({
            url: '/giohang/themvaogiohang',
            type: 'POST',
            data: { id: id, soLuong: soLuong },
            success: function (rs) {
                if (rs.Success) {
                    $('#checkout_items').html(rs.Count);
                    alert(rs.msg);
                }
            }
        });
    });
    $('body').on('click', '.btnCapNhat', function (e) {
        e.preventDefault();
        var id = $(this).data("id");
        var soLuong = $('#SoLuong_' + id).val();
        CapNhat(id, soLuong);
        

    });
    $('body').on('click', '.btnXoaHet', function (e) {
        e.preventDefault();
        var conf = confirm('Bạn Có Chắc Muốn Xóa Hết Mặt Hàng Trong Giỏ Hàng?')
        if (conf == true) {
            XoaHet();
        }

    });
    $('body').on('click', '.btnXoa', function (e) {
        e.preventDefault();
        var id = $(this).data('id');
        var conf = confirm('Bạn Có Chắc Muốn Xóa Mặt Hàng Này Khỏi Giỏ Hàng?')
        if (conf == true) {
            $.ajax({
                url: '/giohang/Xoa',
                type: 'POST',
                data: { id: id },
                success: function (rs) {
                    if (rs.Success) {
                        $('#checkout_items').html(rs.Count);
                        $('#trow_' + id).remove();
                        LoadGioHang();
                    }
                }
            });
        }
        
    });

});

function ShowCount() {
    $.ajax({
        url: '/giohang/ShowCount',
        type: 'GET',
        success: function (rs) {
            $('#checkout_items').html(rs.Count);
        }
    });
}
function XoaHet() {
    $.ajax({
        url: '/giohang/XoaHet',
        type: 'POST',
        success: function (rs) {
            if (rs.Success) {
                LoadGioHang();
            }
        }
    });
}
function CapNhat(id, soLuong) {
    $.ajax({
        url: '/giohang/CapNhat',
        type: 'POST',
        data: { id: id, soLuong: soLuong },
        success: function (rs) {
            if (rs.Success) {
                LoadGioHang();
            }
        }
    });
}

function LoadGioHang() {
    $.ajax({
        url: '/giohang/Partial_Item_GioHang',
        type: 'GET',
        success: function (rs) {
            $('#load_data').html(rs);
        }
    });
}
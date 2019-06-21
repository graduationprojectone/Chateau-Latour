

function AddCart(id) {
    $.ajax({
        url: "/Single/Add",
        type: "post",
        dataType: "Json",
        data: { "id": id, "count": 1 },
        success: function (rs) {
            alert(rs.msg);
        }
    })
}
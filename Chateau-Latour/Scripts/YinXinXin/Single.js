$(function () {
    $.ajax({
        url: "/Single/Load",
        type: "get",
        datatype: "json",
        success: function (rs) {
            var my_ul = $(
                '<ul class="slides">' +
                '<li data-thumb="' + rs[0].Mastergraph + '">' +
                '<div class="thumb-image"> <img src="' + rs[0].Mastergraph + '" data-imagezoom="true" class="img-responsive" style="width :286px;height :400px;"> </div></li>' +
                '<li data-thumb="' + rs[1].Mastergraph + '">' +
                '<div class="thumb-image"> <img src="' + rs[1].Mastergraph + '" data-imagezoom="true" class="img-responsive" style="width :286px;height :400px;"> </div></li>' +
                '<li data-thumb="' + rs[2].Mastergraph + '">' +
                '<div class="thumb-image"><img src="' + rs[2].Mastergraph + '" data-imagezoom="true" class="img-responsive" style="width :286px;height :400px;"> </div></li></ul>'
            );
            $("#fix_one").append(my_ul);

            var my_div = $(
                '<h3>' + rs[0].Tradename + '</h3><h4><span class="item_price">￥' + rs[0].Price + '</span></h4>' +
                '<div class="rating1"><span class="starRating">' +
                '<input id="rating5" type="radio" name="rating" value="5">' +
                '<label for="rating5">5</label>' +
                '<input id="rating4" type="radio" name="rating" value="4">' +
                '<label for="rating4">4</label>' +
                '<input id="rating3" type="radio" name="rating" value="3" checked>' +
                '<label for="rating3">3</label>' +
                '<input id="rating2" type="radio" name="rating" value="2">' +
                '<label for="rating2">2</label>' +
                '<input id="rating1" type="radio" name="rating" value="1">' +
                '<label for="rating1">1</label>' +
                '</span></div><div class="description">' +
                '<h5><i>描述</i></h5><p>' + rs[0].CommodityDescription + '</p></div>' +
                '<div class="color-quality">' +
                '<div class="color-quality-left">' +
                '<h5>纯度</h5><ul>' +
                '<li><a href="#"><span></span>30%</a></li>' +
                '<li><a href="#" class="brown"><span></span>50%</a></li>' +
                '<li><a href="#" class="purple"><span></span>70%</a></li>' +
                '<li><a href="#" class="gray"><span></span>90%</a></li>' +
                '</ul></div><div class="clearfix"></div></div>' +
                '<div class="color-quality-right">' +
                '<h5>数量 :</h5>' +
                '<select id="country1" onchange="change_country(this.value)" class="frm-field required sect">' +
                '<option value="1">1 个</option>' +
                '<option value="2">2 个</option>' +
                '<option value="3">3 个</option>' +
                '<option value="4">4 个</option></select>' +
                '</div><div class="clearfix"></div>' +
                '<div class="occasion-cart" style=" margin-top :10px;">' +
                '<a class="item_add" href="javascript:;" onclick="AddCart(' + rs[0].CommodityId + ')">添加到购物车 </a></div>' +
                '<div id="counter"> </div>'
            );
            $("#fix_two").append(my_div);
        }
    })
});

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
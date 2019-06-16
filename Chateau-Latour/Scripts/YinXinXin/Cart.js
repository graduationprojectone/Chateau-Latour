$(function () {
    //加载购物车商品列表
    $.ajax({
        url: "/Cart/Load",
        dataType: "json",
        success: function (rs) {
            var count = 0;
            for (var i = 0; i < rs.length; i++) {
                //添加商品信息列表
                var my_shop = $(
                    '<tr class="rem1" id="rov' + (i + 1) + '">' +
                    '<td class="invert">' + (i + 1) + '</td>' +
                    '<td class="invert-image"><a href="single.html"><img src="' + rs[i].Image + '" alt=" " class="img-responsive" /></a></td>' +
                    '<td class="invert"><div class="quantity">' +
                    '<div class="quantity-select"><div class="entry value-minus">&nbsp;</div>' +
                    '<div class="entry value"><span>1</span></div><div class="entry value-plus active">&nbsp;</div>' +
                    '</div></div></td>' +
                    '<td class="invert">' + rs[i].Tradename + '</td><td class="invert">￥' + rs[i].Price + '</td>' +
                    '<td class="invert"><div class="rem"><div class="close' + (i + 1) + '"> </div></div>' +
                    '<script>$(document).ready(function (c) {' +
                    '$(".close' + (i + 1) + '").on("click", function (c) {$("#rov' + (i + 1) + '").fadeOut("slow", function (c) {' +
                    '$("#rov' + (i + 1) + '").remove();});});});</script></td></tr>'
                );
                $("#Cart_First").append(my_shop);

                //添加商品价格列表
                var my_ul = $(
                    '<li>产品' + (i + 1) + ' <i>-</i> <span>￥' + rs[i].Price + ' </span></li>'
                );
                $("#div_price").append(my_ul);

                //计算商品总价
                count += rs[i].Price;
            }
            //添加商品总价
            var my_div = $(
                '<li>合计 <i>-</i> <span>￥' + count + '</span></li>'
            );
            $("#ul_price").append(my_div);
        }
    })


})
$(function () {
    $.ajax({
        url: "/Home/Load",
        type: "get",
        dataType: "json",
        success: function (rs) {
            for (var i = 0; i < rs.length; i++) {
                var my_html = $(
                    '<div class="col-md-3 new-collections-grid">' +
                    '<div class="new-collections-grid1 animated wow slideInUp" data-wow-delay=".5s">' +
                    '<div class="new-collections-grid1-image">' +
                    '<a href="single.html" class="product-image"><img src="' + rs[i].Image + '" alt=" " class="img-responsive" /></a>' +
                    '<div class="new-collections-grid1-image-pos"><a href="single.html">查看详情</a></div>' +
                    '<div class="new-collections-grid1-right">' +
                    '<div class="rating"><div class="rating-left">' +
                    '<img src="/Images/Index/2.png" alt=" " class="img-responsive" /></div>' +
                    '<div class="rating-left"><img src="/Images/Index/2.png" alt=" " class="img-responsive" />' +
                    '</div><div class="rating-left">' +
                    '<img src="/Images/Index/2.png" alt=" " class="img-responsive" /></div>' +
                    '<div class="rating-left">' +
                    '<img src="/Images/Index/1.png" alt=" " class="img-responsive" /></div>' +
                    '<div class="rating-left">' +
                    '<img src="/Images/Index/1.png" alt=" " class="img-responsive" /></div>' +
                    '<div class="clearfix"> </div></div></div></div>' +
                    '<h4><a href="single.html">' + rs[i].Tradename +'</a></h4>' +
                    '<p>' + rs[i].Contactnumber+'</p>' +
                    '<div class="new-collections-grid1-left simpleCart_shelfItem">' +
                    '<p><i>￥' + rs[i].Commodityclassification + '</i> <span class="item_price">￥' + rs[i].Price + '</span><a class="item_add" href="#">加入购物车 </a></p></div></div>' +
                    '<div style="width:100%;height:20px"></div>'
                );
                $("#conter-first").append(my_html);
            }
        }
    })
})
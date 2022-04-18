#pragma checksum "C:\Users\Tibame_T14\Documents\GitHub\TFM104-4-main\TFM104MVC\TFM104MVC\Views\Order\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd8e2e6f1cc38cbf697c3698c8582149308d1b54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Detail), @"mvc.1.0.view", @"/Views/Order/Detail.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Tibame_T14\Documents\GitHub\TFM104-4-main\TFM104MVC\TFM104MVC\Views\_ViewImports.cshtml"
using TFM104MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tibame_T14\Documents\GitHub\TFM104-4-main\TFM104MVC\TFM104MVC\Views\_ViewImports.cshtml"
using TFM104MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd8e2e6f1cc38cbf697c3698c8582149308d1b54", @"/Views/Order/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d55a31bf224b05d842f37c5c48e4b11f1c3a59d", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Tibame_T14\Documents\GitHub\TFM104-4-main\TFM104MVC\TFM104MVC\Views\Order\Detail.cshtml"
  
    ViewData["Title"] = "訂單明細";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""/css/orderDetail.css"" type=""text/css"">


<div class=""container mt-3 mb-5"">
    <div class=""row"">

        <!--左功能列表-->
        <div class=""col-md-3"">
            <div class=""card shadow"">
                <img src=""https://picsum.photos/400/300?ramdom=10"" class=""card-img-top"">
                <div class=""card-body"">
                    <h5 class=""card-title"" id=""product"">{{product.title}}</h5>
                    <p class=""card-date"">使用日期</p>
                    <p class=""card-date"" id=""date-time"">{{gotourist.time}}</p>
                    <p class=""discount"">數量</p>
                    <p class=""discount-ct"">{{discount}}人</p>
                </div>
                <div class=""card shadow"">
                    <div class=""card-body"">
                        <div class=""card-price"">
                            <p class=""price-title"">實際付款金額</p>
                            <p class=""price-td"">TWD</p>
                            <p class=""price-detail"">{{product.");
            WriteLiteral(@"price}}</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>


        <!--右訂單明細欄-->
        <div class=""col-md-9"">
            <div class=""board shadow"">
                <div class=""card-lt"">
                    <div class=""order-title"">
                        <div>
                            <a href=""javascript:void(0);"" class=""btn"" id=""btn_1"" role=""button"" data-bs-toggle=""button"">
                                <p>聯絡客服</p>
                            </a>
                        </div>
                        <h4>訂單編號{{order.id}}</h4>
                        <p>訂購人姓名：{{user.name}}</p>
                        <div>
                            <a href=""javascript:void(0);"" class=""btn"" id=""btn_2"" role=""button"" data-bs-toggle=""button"">
                                <p>給予評價</p>
                            </a>
                        </div>
                        <p>電子郵件：{{user.id}}</p>
                        <p>連");
            WriteLiteral("絡電話：{{user.phone}}</p>\r\n                        <p>訂購日期：{{order.date}}</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<!--回頂部-->\r\n");
            WriteLiteral("\r\n\r\n<script>\r\n    var getUrlString = location.pathname;\r\n    //var pid = getUrlString.replace(\"\", \"\");\r\n    var apporder = new Vue({\r\n        el: \'#detailVue\',\r\n        data: {\r\n            order: [],\r\n        }\r\n    })\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

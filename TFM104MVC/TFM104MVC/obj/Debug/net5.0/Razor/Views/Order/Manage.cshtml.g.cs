#pragma checksum "C:\Users\Tibame_T14\Documents\GitHub\TFM104-4\TFM104MVC\TFM104MVC\Views\Order\Manage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5475231e9cbf7d20a5b4a3a01dd22f16f2db1a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Manage), @"mvc.1.0.view", @"/Views/Order/Manage.cshtml")]
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
#line 1 "C:\Users\Tibame_T14\Documents\GitHub\TFM104-4\TFM104MVC\TFM104MVC\Views\_ViewImports.cshtml"
using TFM104MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tibame_T14\Documents\GitHub\TFM104-4\TFM104MVC\TFM104MVC\Views\_ViewImports.cshtml"
using TFM104MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5475231e9cbf7d20a5b4a3a01dd22f16f2db1a7", @"/Views/Order/Manage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d55a31bf224b05d842f37c5c48e4b11f1c3a59d", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Manage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Tibame_T14\Documents\GitHub\TFM104-4\TFM104MVC\TFM104MVC\Views\Order\Manage.cshtml"
  
    ViewData["Title"] = "訂單管理";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <link rel=""stylesheet"" href=""/css/orderManage.css"" type=""text/css"">


<!--左會員資訊欄-->
<section class=""page-wrap"">
    <div class=""container"">
        <div class=""row"">
            <div class=""bd_board col-md-3"">
                <div class=""card-info shadow-sm"">
                    <div class=""card-info-inner"">
                        <img src=""https://images.plurk.com/7xffWFcSGWCxhksYH53PN5.png""
                            class=""card-img-top rounded-circle"">
                    </div>
                    <div class=""card-body"" id=""user_account"">
                        <p class=""card-username"">使用者名稱</p>
                    </div>
                    <div class=""user-account shadow-sm"">
                        <span id=""user_account_fb""><img src=""https://imgur.com/MAqZ1Pb.png""
                                style=""width: 24px;height: 24px;"">
                            Facebook
                        </span>
                        <br>
                        <span id=""user_accoun");
            WriteLiteral(@"t_line""><img src=""https://imgur.com/1yBEAZq.png""
                                style=""width: 24px; height: 24px;"">
                            Line
                        </span>
                        <br>
                        <span id=""user_account_google""><img src=""https://i.imgur.com/WDgbTaH.png""
                                style=""width: 24px; height: 24px;"">
                            Google
                        </span>
                    </div>
                    <!--左功能列表-->
                    <div class=""card-intro shadow"">
                        <ul class=""list-group list-group-flush"">
                            <li class=""list-group-item""><svg style=""margin-right: 6px;""
                                    xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor""
                                    class=""bi bi-gear-wide-connected"" viewBox=""0 0 16 16"">
                                    <path
                                        d=""M7.068.7");
            WriteLiteral(@"27c.243-.97 1.62-.97 1.864 0l.071.286a.96.96 0 0 0 1.622.434l.205-.211c.695-.719 1.888-.03 1.613.931l-.08.284a.96.96 0 0 0 1.187 1.187l.283-.081c.96-.275 1.65.918.931 1.613l-.211.205a.96.96 0 0 0 .434 1.622l.286.071c.97.243.97 1.62 0 1.864l-.286.071a.96.96 0 0 0-.434 1.622l.211.205c.719.695.03 1.888-.931 1.613l-.284-.08a.96.96 0 0 0-1.187 1.187l.081.283c.275.96-.918 1.65-1.613.931l-.205-.211a.96.96 0 0 0-1.622.434l-.071.286c-.243.97-1.62.97-1.864 0l-.071-.286a.96.96 0 0 0-1.622-.434l-.205.211c-.695.719-1.888.03-1.613-.931l.08-.284a.96.96 0 0 0-1.186-1.187l-.284.081c-.96.275-1.65-.918-.931-1.613l.211-.205a.96.96 0 0 0-.434-1.622l-.286-.071c-.97-.243-.97-1.62 0-1.864l.286-.071a.96.96 0 0 0 .434-1.622l-.211-.205c-.719-.695-.03-1.888.931-1.613l.284.08a.96.96 0 0 0 1.187-1.186l-.081-.284c-.275-.96.918-1.65 1.613-.931l.205.211a.96.96 0 0 0 1.622-.434l.071-.286zM12.973 8.5H8.25l-2.834 3.779A4.998 4.998 0 0 0 12.973 8.5zm0-1a4.998 4.998 0 0 0-7.557-3.779l2.834 3.78h4.723zM5.048 3.967c-.03.021-.058.043-.087.065l.087-.");
            WriteLiteral("065zm-.431.355A4.984 4.984 0 0 0 3.002 8c0 1.455.622 2.765 1.615 3.678L7.375 8 4.617 4.322zm.344 7.646.087.065-.087-.065z\" />\r\n                                </svg><a id=\"link-account-setting\"");
            BeginWriteAttribute("href", " href=\"", 3307, "\"", 3314, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a><span class=""list-item-title"">帳號設定</span>
                            </li>
                            <li class=""list-group-item""><svg style=""margin-right: 6px;""
                                    xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor""
                                    class=""bi bi-stickies"" viewBox=""0 0 16 16"">
                                    <path
                                        d=""M1.5 0A1.5 1.5 0 0 0 0 1.5V13a1 1 0 0 0 1 1V1.5a.5.5 0 0 1 .5-.5H14a1 1 0 0 0-1-1H1.5z"" />
                                    <path
                                        d=""M3.5 2A1.5 1.5 0 0 0 2 3.5v11A1.5 1.5 0 0 0 3.5 16h6.086a1.5 1.5 0 0 0 1.06-.44l4.915-4.914A1.5 1.5 0 0 0 16 9.586V3.5A1.5 1.5 0 0 0 14.5 2h-11zM3 3.5a.5.5 0 0 1 .5-.5h11a.5.5 0 0 1 .5.5V9h-4.5A1.5 1.5 0 0 0 9 10.5V15H3.5a.5.5 0 0 1-.5-.5v-11zm7 11.293V10.5a.5.5 0 0 1 .5-.5h4.293L10 14.793z"" />
                                </svg><a id=""link-account-setting""");
            BeginWriteAttribute("href", " href=\"", 4310, "\"", 4317, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a><span class=""list-item-title"">訂單管理</span>
                            </li>
                            <li class=""list-group-item""><svg style=""margin-right: 6px;""
                                    xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor""
                                    class=""bi bi-chat-dots-fill"" viewBox=""0 0 16 16"">
                                    <path
                                        d=""M16 8c0 3.866-3.582 7-8 7a9.06 9.06 0 0 1-2.347-.306c-.584.296-1.925.864-4.181 1.234-.2.032-.352-.176-.273-.362.354-.836.674-1.95.77-2.966C.744 11.37 0 9.76 0 8c0-3.866 3.582-7 8-7s8 3.134 8 7zM5 8a1 1 0 1 0-2 0 1 1 0 0 0 2 0zm4 0a1 1 0 1 0-2 0 1 1 0 0 0 2 0zm3 1a1 1 0 1 0 0-2 1 1 0 0 0 0 2z"" />
                                </svg><a id=""link-account-setting""");
            BeginWriteAttribute("href", " href=\"", 5142, "\"", 5149, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a><span class=""list-item-title"">訊息管理</span>
                            </li>
                            <li class=""list-group-item""><svg style=""margin-right: 6px;""
                                    xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor""
                                    class=""bi bi-balloon-heart"" viewBox=""0 0 16 16"">
                                    <path fill-rule=""evenodd""
                                        d=""m8 2.42-.717-.737c-1.13-1.161-3.243-.777-4.01.72-.35.685-.451 1.707.236 3.062C4.16 6.753 5.52 8.32 8 10.042c2.479-1.723 3.839-3.29 4.491-4.577.687-1.355.587-2.377.236-3.061-.767-1.498-2.88-1.882-4.01-.721L8 2.42Zm-.49 8.5c-10.78-7.44-3-13.155.359-10.063.045.041.089.084.132.129.043-.045.087-.088.132-.129 3.36-3.092 11.137 2.624.357 10.063l.235.468a.25.25 0 1 1-.448.224l-.008-.017c.008.11.02.202.037.29.054.27.161.488.419 1.003.288.578.235 1.15.076 1.629-.157.469-.422.867-.588 1.115l-.004.007a.25.25 0 1 1-.416-.278c.168-.252.4-.6.533-1.003.13");
            WriteLiteral(@"3-.396.163-.824-.049-1.246l-.013-.028c-.24-.48-.38-.758-.448-1.102a3.177 3.177 0 0 1-.052-.45l-.04.08a.25.25 0 1 1-.447-.224l.235-.468ZM6.013 2.06c-.649-.18-1.483.083-1.85.798-.131.258-.245.689-.08 1.335.063.244.414.198.487-.043.21-.697.627-1.447 1.359-1.692.217-.073.304-.337.084-.398Z"" />
                                </svg><a id=""link-account-setting""");
            BeginWriteAttribute("href", " href=\"", 6532, "\"", 6539, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a><span class=""list-item-title"">我的收藏</span>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <!--右訂單資訊欄(至少兩筆訂單)-->
            <div class=""col-md-9"">
                <div class=""board shadow-sm"">
                    <div class=""page-head"">
                        <h3>訂單管理</h3>
                    </div>
                    <div class=""card-items mb-4 shadow"">
                        <div class=""card col"" style=""height: 200px;"" id=""card-ts"">
                            <div class=""row g-0"">
                                <div class=""col-md-4"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 7243, "\"", 7250, 0);
            EndWriteAttribute();
            WriteLiteral(@"><img src=""https://picsum.photos/300/200?ramdom=10""
                                            style=""margin-left: 10px; margin-top: 10px;"" class=""img-fluid rounded""></a>
                                </div>
                                <div class=""col-md-8"">
                                    <div class=""card-body"">
                                        <h5 class=""card-title"">ProductName</h5>
                                        <p class=""card-text"">This is a wider card with supporting text below as a
                                            natural
                                            lead-in to
                                            additional content.
                                            This content is a little bit longer.</p>
                                        <p class=""card-text""><small class=""text-muted"">Last updated 3 mins ago</small>
                                        </p>
                                        <!--修改訂單=>跳修改訂單頁面-->
         ");
            WriteLiteral(@"                               <a href=""/orderEdit.html"" class=""btn"" role=""button"" data-bs-toggle=""button""
                                            style=""float: right; margin-right: 9px;"">
                                            <p>修改訂單</p>
                                        </a>
                                        <a href=""#"" class=""btn"" role=""button"" data-bs-toggle=""button""
                                            style=""float: right; margin-right: 9px;"">
                                            <p>查看明細</p>
                                        </a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""card-items mb-4 shadow"">
                        <div class=""card col"" style=""height: 200px;"" id=""card-ts"">
                            <div class=""row g-0"">
                                <div class=""col-md-4"">
    ");
            WriteLiteral("                                <a");
            BeginWriteAttribute("href", " href=\"", 9333, "\"", 9340, 0);
            EndWriteAttribute();
            WriteLiteral(@"><img src=""https://picsum.photos/300/200?ramdom=10""
                                            style=""margin-left: 10px; margin-top: 10px;"" class=""img-fluid rounded""></a>
                                </div>
                                <div class=""col-md-8"">
                                    <div class=""card-body"">
                                        <h5 class=""card-title"">ProductName</h5>
                                        <p class=""card-text"">This is a wider card with supporting text below as a
                                            natural
                                            lead-in to
                                            additional content.
                                            This content is a little bit longer.</p>
                                        <p class=""card-text""><small class=""text-muted"">Last updated 3 mins ago</small>
                                        </p>
                                        <!--修改訂單=>跳修改訂單頁面-->
         ");
            WriteLiteral(@"                               <a href=""/orderEdit.html"" class=""btn"" role=""button"" data-bs-toggle=""button""
                                            style=""float: right; margin-right: 9px;"">
                                            <p>修改訂單</p>
                                        </a>
                                        <a href=""#"" class=""btn"" role=""button"" data-bs-toggle=""button""
                                            style=""float: right; margin-right: 9px;"">
                                            <p>查看明細</p>
                                        </a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>


<div class=""scroll-top-wrapper"">
    <button type=""button"" id=""BackTop"" class=""scroll-top-inner"" style=""float: right;""><svg xmlns=""http://www.w3.org/2000/svg"" fill=");
            WriteLiteral(@"""currentColor"" class=""bi bi-arrow-up-circle"" viewBox=""0 0 16 16"">
            <path fill-rule=""evenodd""
                d=""M1 8a7 7 0 1 0 14 0A7 7 0 0 0 1 8zm15 0A8 8 0 1 1 0 8a8 8 0 0 1 16 0zm-7.5 3.5a.5.5 0 0 1-1 0V5.707L5.354 7.854a.5.5 0 1 1-.708-.708l3-3a.5.5 0 0 1 .708 0l3 3a.5.5 0 0 1-.708.708L8.5 5.707V11.5z"" />
        </svg></button>
</div>
<script type=""text/javascript"">
$(function(){
	$('#BackTop').click(function(){ 
		$('html,body').animate({scrollTop:0}, 333);
	});
	$(window).scroll(function() {
		if ( $(this).scrollTop() > 100 ){
			$('#BackTop').fadeIn(222);
		} else {
			$('#BackTop').stop().fadeOut(222);
		}
	}).scroll();
});
</script>
");
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

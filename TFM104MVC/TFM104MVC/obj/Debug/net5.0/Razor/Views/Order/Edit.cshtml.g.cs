#pragma checksum "C:\Users\Tibame_T14\Documents\GitHub\TFM104-4\TFM104MVC\TFM104MVC\Views\Order\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa3593e99d6df26c4520c673a2f4e225c9ee1433"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Edit), @"mvc.1.0.view", @"/Views/Order/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa3593e99d6df26c4520c673a2f4e225c9ee1433", @"/Views/Order/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d55a31bf224b05d842f37c5c48e4b11f1c3a59d", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Tibame_T14\Documents\GitHub\TFM104-4\TFM104MVC\TFM104MVC\Views\Order\Edit.cshtml"
  
    ViewData["Title"] = "訂單修改";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""/css/orderEdit.css"" type=""text/css"">


<!--主要區塊-->
<section class=""section"">
    <div class=""container my-5"">
        <div class=""row col-md-10"">
            <div class=""bd_board shadow"">
                <table class=""table table-borderless shadow border-0"">
                    <thead class=""table-list"">
                        <tr class=""col-sm-1"">
                            <tb class=""table-title"">
                                <div class=""title"">
                                    <p class=""title_w"">
                                        訂單管理<img src=""https://i.imgur.com/gfyymzf.png""
                                                 style=""width: 18px; height: 18px;"">修改訂單
                                    </p>
                                </div>
                                <span>
                                    <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 983, "\"", 991, 0);
            EndWriteAttribute();
            WriteLiteral(@" id=""allcheck""
                                           onclick=""demo()"">
                                    <label class=""form-check-label"" for=""flexCheckDefault"">全選</label>
                                </span>

                                <script type=""text/javascript"">
                                    //點選全選，子複選框被選中
                                    function demo() {
                                        var allcheck = document.getElementById(""allcheck"");
                                        var choice = document.getElementsByName(""choice"");
                                        for (var i = 0; i < choice.length; i++) {
                                            choice[i].checked = allcheck.checked;
                                        }
                                    }

                                    //點選子複選框,全選框 選中、取消
                                    function setAll() {
                                        if (!$("".checknum"").checked) {
        ");
            WriteLiteral(@"                                    $(""#allcheck"").prop(""checked"", false); // 子複選框某個不選擇，全選也被取消
                                        }
                                        var choicelength = $(""input[type='checkbox'][class='checknum']"").length;
                                        var choiceselect = $(""input[type='checkbox'][class='checknum']:checked"").length;

                                        if (choicelength == choiceselect) {
                                            $(""#allcheck"").prop(""checked"", true);   // 子複選框全部部被選擇，全選也被選擇；1.對於HTML元素我們自己自定義的DOM屬性，在處理時，使用attr方法；2.對於HTML元素本身就帶有的固有屬性，在處理時，使用prop方法。
                                        }

                                    }
                                </script>
                            </tb>
                        </tr>
                    </thead>
                    <tbody>
                        <tr class=""col"">
                            <th>
                                <input class=""form-check-input");
            WriteLiteral("\" type=\"checkbox\" id=\"check\" name=\"choice\"\r\n                                       onclick=\"setAll()\" aria-label=\"img-fluid\">\r\n                            </th>\r\n                            <th>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 3270, "\"", 3277, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <img src=""https://picsum.photos/200/150?ramdom=10""
                                         class=""img-fluid rounded"">
                                </a>
                            </th>
                            <th>
                                <div class=""card-body"">
                                    <h7 class=""card-title"">ProductName</h7>
                                    <p class=""card-text""><small class=""text-muted"">Last updated 3 mins ago</small></p>
                                </div>
                            </th>
                            <th>
                                <p class=""quantity"">x1</p>
                            </th>
                            <th>
                                <p class=""pricetag"">NTD 3000</p>
                            </th>
                        </tr>
                        <tr class=""col"">
                            <th>
                                <input class=""form-check-");
            WriteLiteral("input\" type=\"checkbox\" id=\"check\" name=\"choice\"\r\n                                       onclick=\"setAll()\" aria-label=\"img-fluid\">\r\n                            </th>\r\n                            <th>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 4537, "\"", 4544, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <img src=""https://picsum.photos/200/150?ramdom=10""
                                         class=""img-fluid rounded"">
                                </a>
                            </th>
                            <th>
                                <div class=""card-body"">
                                    <h7 class=""card-title"">ProductName</h7>
                                    <p class=""card-text""><small class=""text-muted"">Last updated 3 mins ago</small></p>
                                </div>
                            </th>
                            <th>
                                <p class=""quantity"">x1</p>
                            </th>
                            <th>
                                <p class=""pricetag"">NTD 3000</p>
                            </th>
                        </tr>
                        <tr class=""col"">
                            <th>
                                <input class=""form-check-");
            WriteLiteral("input\" type=\"checkbox\" id=\"check\" name=\"choice\"\r\n                                       onclick=\"setAll()\" aria-label=\"img-fluid\">\r\n                            </th>\r\n                            <th>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 5804, "\"", 5811, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <img src=""https://picsum.photos/200/150?ramdom=10""
                                         class=""img-fluid rounded"">
                                </a>
                            </th>
                            <th>
                                <div class=""card-body"">
                                    <h7 class=""card-title"">ProductName</h7>
                                    <p class=""card-text""><small class=""text-muted"">Last updated 3 mins ago</small></p>
                                </div>
                            </th>
                            <th>
                                <p class=""quantity"">x1</p>
                            </th>
                            <th>
                                <p class=""pricetag"">NTD 3000</p>
                            </th>
                        </tr>
                        <tr class=""col"">
                            <th>
                                <input class=""form-check-");
            WriteLiteral("input\" type=\"checkbox\" id=\"check\" name=\"choice\"\r\n                                       onclick=\"setAll()\" aria-label=\"img-fluid\">\r\n                            </th>\r\n                            <th>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 7071, "\"", 7078, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <img src=""https://picsum.photos/200/150?ramdom=10""
                                         class=""img-fluid rounded"">
                                </a>
                            </th>
                            <th>
                                <div class=""card-body"">
                                    <h7 class=""card-title"">ProductName</h7>
                                    <p class=""card-text""><small class=""text-muted"">Last updated 3 mins ago</small></p>
                                </div>
                            </th>
                            <th>
                                <p class=""quantity"">x1</p>
                            </th>
                            <th>
                                <p class=""pricetag"">NTD 3000</p>
                            </th>
                        </tr>
                        <tr class=""col"">
                            <th>
                                <input class=""form-check-");
            WriteLiteral("input\" type=\"checkbox\" id=\"check\" name=\"choice\"\r\n                                       onclick=\"setAll()\" aria-label=\"img-fluid\">\r\n                            </th>\r\n                            <th>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 8338, "\"", 8345, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    <img src=""https://picsum.photos/200/150?ramdom=10""
                                         class=""img-fluid rounded"">
                                </a>
                            </th>
                            <th>
                                <div class=""card-body"">
                                    <h7 class=""card-title"">ProductName</h7>
                                    <p class=""card-text""><small class=""text-muted"">Last updated 3 mins ago</small></p>
                                </div>
                            </th>
                            <th>
                                <p class=""quantity"">x1</p>
                            </th>
                            <th>
                                <p class=""pricetag"">NTD 3000</p>
                            </th>
                        </tr>
                    </tbody>
                </table>
                <div>
                    <a href=""#"" class=""btn"" id=""btn_in");
            WriteLiteral("\" role=\"button\" data-bs-toggle=\"button\">\r\n                        <p>確認送出</p>\r\n                    </a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n<!--回頂部按鈕-->\r\n");
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

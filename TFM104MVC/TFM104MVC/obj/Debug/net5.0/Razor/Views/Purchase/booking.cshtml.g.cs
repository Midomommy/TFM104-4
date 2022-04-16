#pragma checksum "C:\Users\Tibame_T14\Documents\GitHub\TFM104-4\TFM104MVC\TFM104MVC\Views\Purchase\booking.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4d01851ea6479a45cf4080c43b3cd8ad1a6b242"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Purchase_booking), @"mvc.1.0.view", @"/Views/Purchase/booking.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4d01851ea6479a45cf4080c43b3cd8ad1a6b242", @"/Views/Purchase/booking.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d55a31bf224b05d842f37c5c48e4b11f1c3a59d", @"/Views/_ViewImports.cshtml")]
    public class Views_Purchase_booking : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Bank/SpgatewayPayBill"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Tibame_T14\Documents\GitHub\TFM104-4\TFM104MVC\TFM104MVC\Views\Purchase\booking.cshtml"
  
    ViewData["Title"] = "訂購";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""/css/purchase.css"" type=""text/css"">

<!--麵包屑-->
<div class=""container mt-3"">
    <nav style=""--bs-breadcrumb-divider: '>';"" aria-label=""breadcrumb"">
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item""><a href=""javascript:void(0);"">付款</a></li>
            <li class=""breadcrumb-item active"" aria-current=""page"">訂購完成</li>
        </ol>
    </nav>
</div>

<!--訂購頁本體-->
<main class=""mb-5"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4d01851ea6479a45cf4080c43b3cd8ad1a6b2424620", async() => {
                WriteLiteral(@"
        <div class=""container"">
            <!--訂購人資料-->
            <div class=""board mb-5"">
                <!--訂購標題-->
                <div class=""board-title d-flex gap-3"">
                    <div>
                        <a class=""text-black"" data-bs-toggle=""collapse"" href=""#collapseOrderData"" role=""button"">
                            <span class=""fs-3"">
                                <i class=""fas fa-angle-down""></i>
                            </span>
                        </a>
                    </div>
                    <div>
                        <span class=""fs-5 fw-bold"">訂購人資料</span>
                    </div>
                </div>
                <div class=""container collapse"" id=""collapseOrderData"">
                    <hr class=""text-muted"">
                    <div class=""container "">
                        <!--姓名-->
                        <div class=""row mb-3"">
                            <div class=""col"">
                                <div class=""mb-1"">");
                WriteLiteral(@"
                                    <label>
                                        <span>
                                            名字
                                        </span>
                                        <span class=""text-danger"">*</span>
                                    </label>
                                </div>
                                <div>
                                    <input type=""text"" name=""FirstName"" placeholder=""例：子庭"" class=""form-control"">
                                </div>
                            </div>
                            <div class=""col"">
                                <div class=""mb-1"">
                                    <label>
                                        <span>
                                            姓氏
                                        </span>
                                        <span class=""text-danger"">*</span>
                                    </label>
                              ");
                WriteLiteral(@"  </div>
                                <div>
                                    <input type=""text"" name=""LastName"" placeholder=""例：蘇"" class=""form-control"">
                                </div>
                            </div>
                        </div>
                        <!--連絡電話-->
                        <div class=""row mb-3"">
                            <div class=""mb-1"">
                                <label>
                                    <span>
                                        聯絡電話
                                    </span>
                                    <span class=""text-danger"">*</span>
                                </label>
                            </div>
                            <div>
                                <input class=""form-control"" name=""Phone"" type=""tel"" placeholder=""請輸入聯絡電話"">
                            </div>
                        </div>
                        <!--電子郵件信箱-->
                        <div class=""row mb-3"">");
                WriteLiteral(@"
                            <div class=""mb-1"">
                                <label>
                                    <span>
                                        電子郵件信箱
                                        <span class=""text-danger"">*</span>
                                    </span>
                                </label>
                            </div>
                            <div>
                                <input class=""form-control"" name=""Email"" type=""email"" placeholder=""請輸入常用電子郵件信箱"">
                            </div>
                        </div>
                    </div>
                    <button class=""btn btn-info mt-3"" type=""button"">繼續</button>
                </div>
            </div>

            <!--其他資訊-->
            <span class=""fs-5 fw-bold"">其他資訊</span>
            <div class=""board mb-5"">
                <!--商品單項標題-->
                <div class=""board-title d-flex gap-3"">
                    <!--icon-->
                    <div>
        ");
                WriteLiteral(@"                <a class=""text-black"" data-bs-toggle=""collapse"" href=""#collapseOrderInfo"" role=""button"">
                            <span class=""fs-3"">
                                <i class=""fas fa-angle-down""></i>
                            </span>
                        </a>
                    </div>
                    <!--商品單項-->
                    <div class=""mb-3"">
                        <div class=""row g-0"">
                            <div class=""col-3"">
                                <div class=""product-pic w-80 h-50"">
                                    <img src=""https://picsum.photos/200/150""
                                         class=""w-100 img-fluid rounded-start product-pic"" alt=""..."">
                                </div>
                            </div>
                            <div class=""col-9"">
                                <div class=""card-body"">
                                    <!--商品標題-->
                                    <div class=""d-flex"">");
                WriteLiteral(@"
                                        <span class=""card-title mb-3 fs-6 fw-bold"">商品標題｜商品標題內容敘述</span>
                                    </div>
                                    <div class=""d-flex justify-content-between"">
                                        <!--日期-->
                                        <div class=""d-flex gap-1"">
                                            <span class=""text-muted""><i class=""bi bi-calendar""></i></span>
                                            <p><small class=""text-muted"">2022-05-06</small></p>
                                        </div>
                                        <!--人數-->
                                        <div class=""d-flex gap-1"">
                                            <span class=""text-muted""><i class=""bi bi-people-fill""></i></span>
                                            <p><small class=""text-muted"">人數x?</small></p>
                                        </div>
                                    </div>
       ");
                WriteLiteral(@"                         </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""container collapse"" id=""collapseOrderInfo"">
                    <hr class=""text-muted"">
                    <!--特殊需求備註-->
                    <div class=""mb-4 mt-4"">
                        <div class=""mb-2"">
                            <span class=""fs-6 fw-bold"">▎特殊需求備註</span>
                        </div>
                        <div>
                            <textarea class=""form-control"" placeholder=""此欄位僅限資料備註。不在商品規換內的個人需求，不保證提供。""></textarea>
                        </div>
                    </div>
                    <!--使用折扣券-->
                    <div class=""mb-3"">
                        <div class=""mb-2"">
                            <span class=""fs-6 fw-bold"">▎使用折扣券</span>
                        </div>
                        <div class=""mt-3 mb-4"">
                            <button type=""button"" ");
                WriteLiteral(@"class=""btn btn-outline-success"">
                                <span>
                                    <i class=""bi bi-ticket-perforated""></i>
                                    使用折扣券
                                </span>
                            </button>
                        </div>
                    </div>
                    <button class=""btn btn-info"" type=""button"">繼續</button>
                </div>
            </div>

            <!--付款方式-->
            <span class=""fs-5 fw-bold"">付款</span>
            <div class=""board mb-5"">
                <!--付款標題-->
                <div class=""board-title d-flex gap-3"">
                    <div>
                        <a class=""text-black"" data-bs-toggle=""collapse"" href=""#collapsePayment"" role=""button"">
                            <span class=""fs-3"">
                                <i class=""fas fa-angle-down""></i>
                            </span>
                        </a>
                    </div>
                    ");
                WriteLiteral(@"<div>
                        <span class=""fs-5 fw-bold"">請選擇付款方式</span>
                    </div>
                </div>
                <div class=""container collapse"" id=""collapsePayment"">
                    <hr class=""text-muted"">
                    <!--多種付款方式-->
                    <div class=""mb-3"">
                        <!--WEBATM繳費-->
                        <!--<div class=""form-check"">
                            <input class=""form-check-input"" type=""radio"" name=""PayMethod"" id=""WEBATM"" value=""WEBATM"">
                            <label class=""form-check-label"" for=""WEBATM"">
                                <div class=""d-flex gap-3"">
                                    <div>
                                        <span>
                                            網銀繳費
                                        </span>
                                    </div>
                                    <div>
                                        <img src="""" style=""max-width:40px"">
    ");
                WriteLiteral(@"                                </div>
                                </div>
                            </label>
                        </div>
                        <hr class=""text-muted"">-->
                        <!--ATM轉帳-->
                        <!--<div class=""form-check"">
                            <input class=""form-check-input"" type=""radio"" name=""PayMethod"" id=""VACC"" value=""VACC"">
                            <label class=""form-check-label"" for=""VACC"">
                                <div class=""d-flex gap-3"">
                                    <div>
                                        <span>
                                            ATM轉帳
                                        </span>
                                    </div>
                                    <div>
                                        <img src="""" style=""max-width:40px"">
                                    </div>
                                </div>
                            </label>
     ");
                WriteLiteral(@"                   </div>
                        <hr class=""text-muted"">-->
                        <!--超商代碼繳費-->
                        <div class=""form-check"">
                            <input class=""form-check-input"" type=""radio"" name=""PayMethod"" id=""CVS"" value=""CVS"">
                            <label class=""form-check-label"" for=""CVS"">
                                <div class=""d-flex gap-3"">
                                    <div>
                                        <span>
                                            超商代碼繳費
                                        </span>
                                    </div>
                                    <div>
                                        <img");
                BeginWriteAttribute("src", " src=\"", 11521, "\"", 11527, 0);
                EndWriteAttribute();
                WriteLiteral(@" style=""max-width:40px"">
                                    </div>
                                </div>
                            </label>
                        </div>
                        <hr class=""text-muted"">
                        <!--超商條碼繳費-->
                        <!--<div class=""form-check"">
                            <input class=""form-check-input"" type=""radio"" name=""PayMethod"" id=""BARCODE"" value=""BARCODE"">
                            <label class=""form-check-label"" for=""BARCODE"">
                                <div class=""d-flex gap-3"">
                                    <div>
                                        <span>
                                            超商條碼繳費
                                        </span>
                                    </div>
                                    <div>
                                        <img src="""" style=""max-width:40px"">
                                    </div>
                                </div>
     ");
                WriteLiteral(@"                       </label>
                        </div>
                        <hr class=""text-muted"">-->
                        <!--Google Pay-->
                        <div class=""form-check"">
                            <input class=""form-check-input"" type=""radio"" name=""PayMethod"" id=""GooglePay"" value=""GooglePay"">
                            <label class=""form-check-label"" for=""GooglePay"">
                                <div class=""d-flex gap-3"">
                                    <div>
                                        <span>
                                            Google Pay
                                        </span>
                                    </div>
                                    <div>
                                        <img src=""https://seeklogo.com/images/G/google-pay-logo-AA826E728D-seeklogo.com.png"" style=""max-width:40px"">
                                    </div>
                                </div>
                            </labe");
                WriteLiteral(@"l>
                        </div>
                        <hr class=""text-muted"">
                        <!--Samsung Pay-->
                        <div class=""form-check"">
                            <input class=""form-check-input"" type=""radio"" name=""PayMethod"" id=""SamsungPay"" value=""SamsungPay"">
                            <label class=""form-check-label"" for=""SamsungPay"">
                                <div class=""d-flex gap-3"">
                                    <div>
                                        <span>
                                            Samsung Pay
                                        </span>
                                    </div>
                                    <div>
                                        <img src=""https://upload.wikimedia.org/wikipedia/commons/thumb/0/07/Samsung_Pay_Logo.svg/462px-Samsung_Pay_Logo.svg.png"" style=""max-width:100px"">
                                    </div>
                                </div>
                        ");
                WriteLiteral(@"    </label>
                        </div>
                        <hr class=""text-muted"">
                        <!--信用卡-->
                        <div class=""form-check"">
                            <input class=""form-check-input"" type=""radio"" name=""PayMethod"" id=""creditcard""
                                   value=""creditcard"">
                            <label class=""form-check-label gap-3"" for=""creditcard"">
                                <span>
                                    信用卡/簽帳金融卡
                                </span>
                                <img src=""https://cdn.kkday.com/pc-web/assets/img/payment/ic_visa.svg""");
                BeginWriteAttribute("alt", " alt=\"", 15259, "\"", 15265, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <img src=\"https://cdn.kkday.com/pc-web/assets/img/payment/ic_master.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 15373, "\"", 15379, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <img src=\"https://cdn.kkday.com/pc-web/assets/img/payment/ic_jcb.svg\"");
                BeginWriteAttribute("alt", " alt=\"", 15484, "\"", 15490, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            </label>
                        </div>
                        <hr class=""text-muted"">
                    </div>
                    <div class=""d-flex gap-1 text-muted"">
                        <i class=""bi bi-exclamation-circle-fill""></i>
                        <small>
                            付款提醒：本店一律採電子發票寄送到信箱；請注意本平台不會向您收取任何平台交易手續費，但你下單時使用的信用卡或第三方支付平台可能會向您收取相關手續費，請參考其相關服務政策和規定，並向你所選的交易服務商取得更多資訊。
                        </small>
                    </div>
                </div>

            </div>

            <!--付款明細-->
            <div class=""board"">
                <!--付款明細標題-->
                <div class=""board-title d-flex gap-3"">
                    <div>
                        <a class=""text-black"" href=""#collapsePayDetail"" data-bs-toggle=""collapse"" role=""button"">
                            <span class=""fs-3"">
                                <i class=""fas fa-angle-down""></i>
                            </span>
                        </");
                WriteLiteral(@"a>
                    </div>
                    <div>
                        <span class=""fs-5 fw-bold"">付款明細</span>
                    </div>
                </div>
                <div class=""container collapse"" id=""collapsePayDetail"">
                    <hr class=""text-muted"">
                    <!--商品明細-->
                    <div class=""container"">
                        <!--商品單項-->
                        <div class=""mb-3"">
                            <div class=""mb-3"">
                                <div class=""row g-0"">
                                    <div class=""col-3"">
                                        <div class=""product-pic w-80 h-50"">
                                            <img src=""https://picsum.photos/200/150""
                                                 class=""w-100 img-fluid rounded-start product-pic"" alt=""..."">
                                        </div>
                                    </div>
                                    <div class");
                WriteLiteral(@"=""col-9"">
                                        <div class=""card-body"">
                                            <!--商品標題-->
                                            <div class=""d-flex"">
                                                <span class=""card-title mb-3 fs-6 fw-bold"">商品標題｜商品標題內容敘述</span>
                                            </div>
                                            <!--日期-->
                                            <div class=""d-flex gap-1"">
                                                <span class=""text-muted""><i class=""bi bi-calendar""></i></span>
                                                <p><small class=""text-muted"">2022-05-06</small></p>
                                            </div>
                                            <!--商品數量-->
                                            <div class=""d-flex justify-content-between"">
                                                <span class=""text-muted"">
                                              ");
                WriteLiteral(@"      商品數量*?
                                                </span>
                                                <span class=""text-muted"">
                                                    TWD XXX
                                                </span>
                                            </div>
                                            <hr class=""text-muted"">
                                            <!--總金額-->
                                            <div class=""d-flex justify-content-between"">
                                                <span");
                BeginWriteAttribute("class", " class=\"", 19147, "\"", 19155, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                    總金額\r\n                                                </span>\r\n                                                <span");
                BeginWriteAttribute("class", " class=\"", 19326, "\"", 19334, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                                    TWD XXX
                                                </span>
                                            </div>
                                        </div>
                                    </div>
                                    <hr class=""text-muted"">
                                </div>
                            </div>
                        </div>
                        <!--商品2-->
                        <div class=""mb-3"">
                            <div class=""mb-3"">
                                <div class=""row g-0"">
                                    <div class=""col-3"">
                                        <div class=""product-pic w-80 h-50"">
                                            <img src=""https://picsum.photos/200/150""
                                                 class=""w-100 img-fluid rounded-start product-pic"" alt=""..."">
                                        </div>
                            ");
                WriteLiteral(@"        </div>
                                    <div class=""col-9"">
                                        <div class=""card-body"">
                                            <!--商品標題-->
                                            <div class=""d-flex"">
                                                <span class=""card-title mb-3 fs-6 fw-bold"">商品標題｜商品標題內容敘述</span>
                                            </div>
                                            <!--日期-->
                                            <div class=""d-flex gap-1"">
                                                <span class=""text-muted""><i class=""bi bi-calendar""></i></span>
                                                <p><small class=""text-muted"">2022-05-06</small></p>
                                            </div>
                                            <!--商品數量-->
                                            <div class=""d-flex justify-content-between"">
                                                <span class");
                WriteLiteral(@"=""text-muted"">
                                                    商品數量*?
                                                </span>
                                                <span class=""text-muted"">
                                                    TWD XXX
                                                </span>
                                            </div>
                                            <hr class=""text-muted"">
                                            <!--總金額-->
                                            <div class=""d-flex justify-content-between"">
                                                <span");
                BeginWriteAttribute("class", " class=\"", 22029, "\"", 22037, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                    總金額\r\n                                                </span>\r\n                                                <span");
                BeginWriteAttribute("class", " class=\"", 22208, "\"", 22216, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                                    TWD XXX
                                                </span>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <hr class=""text-muted"">
                        <!--支付金額-->
                        <div class=""d-flex justify-content-between"">
                            <p class=""fw-bold"">支付金額</p>
                            <span class=""fw-bold text-info fs-5"">TWD xxxx</span>
                        </div>
                        <hr class=""text-muted"">
                        <!--訂單回饋 -->
                        <div class=""d-flex justify-content-between"">
                            <p class=""fw-bold"">訂單完成後回饋</p>
                            <div class=""d-flex text-warning"">
                                <span>
    ");
                WriteLiteral(@"                                <i class=""bi bi-exclamation-circle-fill""></i>
                                    xx
                                </span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <!--確認付款-->
            <div class=""board"">
                <div class=""container "">
                    <div class=""d-flex justify-content-end"">
                        <!--總金額與點數-->
                        <div class=""item"">
                            <div class=""d-flex gap-1 align-items-center"">
                                <small class=""text-muted"">x件商品合計</small>
                                <span class=""fw-bold text-info"">TWD xxxx</span>
                            </div>
                            <div class=""d-flex gap-1 align-items-center justify-content-end"">
                                <small class=""text-muted"">訂單完成後回饋</small>
                                <div clas");
                WriteLiteral(@"s=""d-flex text-warning"">
                                    <span>
                                        <i class=""bi bi-exclamation-circle-fill""></i>
                                        xx
                                    </span>
                                </div>
                            </div>
                        </div>
                        <!--下訂-->
                        <div class=""item btn"">
                            <div class=""d-flex justify-content-end gap-3"">
                                <button class=""btn btn-info"" type=""submit"">確認付款</button>
                            </div>
                        </div>
                    </div>


                </div>
            </div>

        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</main>\r\n\r\n");
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

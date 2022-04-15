#pragma checksum "C:\Users\Tibame_T14\Documents\GitHub\TFM104-4\TFM104MVC\TFM104MVC\Views\ProductView\productlist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed8b5cc39bdd01c6baf1134d420014508b1182da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductView_productlist), @"mvc.1.0.view", @"/Views/ProductView/productlist.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed8b5cc39bdd01c6baf1134d420014508b1182da", @"/Views/ProductView/productlist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d55a31bf224b05d842f37c5c48e4b11f1c3a59d", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductView_productlist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Tibame_T14\Documents\GitHub\TFM104-4\TFM104MVC\TFM104MVC\Views\ProductView\productlist.cshtml"
  
    ViewData["Title"] = "商品列表";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--自幹css-->
<link rel=""stylesheet"" href=""/css/allProduct.css"" type=""text/css"">


<div class=""container"">
    <div class=""row breadcrumb mt-3 mb-3"">
        <nav style=""--bs-breadcrumb-divider: '>';"" aria-label=""breadcrumb"">
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><a href=""/"">首頁</a></li>
                <li class=""breadcrumb-item active"" aria-current=""page"">露營</li>
            </ol>
        </nav>
    </div>
    <div class=""row mb-3"">
        <h2 class=""fw-bold"">
            搜尋結果""
            <b class=""text-success"">
                xxx
            </b>
            ""
        </h2>
    </div>
</div>
<!--商品列表區塊-->
<div class=""container"" id=""GetProducts"">
    <div class=""row"">
        <!--左側區塊-->
        <div class=""col-12 col-lg-3 "">
            <!--目的地-->
            <div class=""item"">
                <div class=""ms-sm-2"">
                    <p class=""fw-bold mb-3"">目的地</p>
                    <div class=""form-check"">
                  ");
            WriteLiteral("      <input class=\"form-check-input\" type=\"checkbox\" value=\"0\" id=\"countryCheck\" v-model=\"regionValue\" true-value=\"0\"");
            BeginWriteAttribute("false-value", "\r\n                               false-value=\"", 1182, "\"", 1228, 0);
            EndWriteAttribute();
            WriteLiteral(@" v-on:change=""regionClick"">
                        <label class=""form-check-label"" for=""countryCheck"">
                            北北基
                        </label>
                    </div>
                    <div class=""form-check"">
                        <input class=""form-check-input"" type=""checkbox"" value=""1"" id=""countryCheck"" v-model=""regionValue"" :true-value=""1""");
            BeginWriteAttribute("false-value", " false-value=\"", 1613, "\"", 1627, 0);
            EndWriteAttribute();
            WriteLiteral(@" v-on:change=""regionClick"">
                        <label class=""form-check-label"" for=""countryCheck"">
                            桃竹苗
                        </label>
                    </div>
                    <div class=""form-check"">
                        <input class=""form-check-input"" type=""checkbox"" value=""2"" id=""countryCheck"" v-model=""regionValue"" :true-value=""2""");
            BeginWriteAttribute("false-value", " false-value=\"", 2012, "\"", 2026, 0);
            EndWriteAttribute();
            WriteLiteral(@" v-on:change=""regionClick"">
                        <label class=""form-check-label"" for=""countryCheck"">
                            中彰投
                        </label>
                    </div>
                    <div class=""form-check"">
                        <input class=""form-check-input"" type=""checkbox"" value=""3"" id=""countryCheck"" v-model=""regionValue"" :true-value=""3""");
            BeginWriteAttribute("false-value", " false-value=\"", 2411, "\"", 2425, 0);
            EndWriteAttribute();
            WriteLiteral(@" v-on:change=""regionClick"">
                        <label class=""form-check-label"" for=""countryCheck"">
                            雲嘉南
                        </label>
                    </div>
                    <div class=""form-check"">
                        <input class=""form-check-input"" type=""checkbox"" value=""4"" id=""countryCheck"" v-model=""regionValue"" :true-value=""4""");
            BeginWriteAttribute("false-value", " false-value=\"", 2810, "\"", 2824, 0);
            EndWriteAttribute();
            WriteLiteral(@" v-on:change=""regionClick"">
                        <label class=""form-check-label"" for=""countryCheck"">
                            高屏
                        </label>
                    </div>
                    <div class=""form-check"">
                        <input class=""form-check-input"" type=""checkbox"" value=""5"" id=""countryCheck"" v-model=""regionValue"" :true-value=""5""");
            BeginWriteAttribute("false-value", " false-value=\"", 3208, "\"", 3222, 0);
            EndWriteAttribute();
            WriteLiteral(@" v-on:change=""regionClick"">
                        <label class=""form-check-label"" for=""countryCheck"">
                            宜花東
                        </label>
                    </div>
                    <div class=""form-check"">
                        <input class=""form-check-input"" type=""checkbox"" value=""6"" id=""countryCheck"" v-model=""regionValue"" :true-value=""6""");
            BeginWriteAttribute("false-value", " false-value=\"", 3607, "\"", 3621, 0);
            EndWriteAttribute();
            WriteLiteral(@" v-on:change=""regionClick"">
                        <label class=""form-check-label"" for=""countryCheck"">
                            離島地區
                        </label>
                    </div>
                    <div class=""d-grid gap-2 mt-3 mb-3"">
                        <button class=""btn btn-outline-success"" type=""button"">
                            查看更多目的地
                        </button>

                    </div>

                </div>
            </div>

            <!--商品類別-->
            <div class=""item"">
                <div class=""ms-sm-2"">
                    <p class=""fw-bold mb-3"">商品類別</p>
                    <div class=""form-check"">
                        <input class=""form-check-input"" type=""checkbox"" value=""0"" id=""productType"" v-model=""TriptypeValue"" :true-value=""0""");
            BeginWriteAttribute("false-value", " false-value=\"", 4446, "\"", 4460, 0);
            EndWriteAttribute();
            WriteLiteral(@" v-on:change=""regionClick"">
                        <label class=""form-check-label"" for=""productType"">
                            戶外休閒
                        </label>
                    </div>
                    <div class=""form-check"">
                        <input class=""form-check-input"" type=""checkbox"" value=""1"" id=""productType"" v-model=""TriptypeValue"" :true-value=""1""");
            BeginWriteAttribute("false-value", " false-value=\"", 4846, "\"", 4860, 0);
            EndWriteAttribute();
            WriteLiteral(@" v-on:change=""regionClick"">
                        <label class=""form-check-label"" for=""productType"">
                            景點門票
                        </label>
                    </div>
                    <div class=""form-check"">
                        <input class=""form-check-input"" type=""checkbox"" value=""2"" id=""productType"" v-model=""TriptypeValue"" :true-value=""2""");
            BeginWriteAttribute("false-value", " false-value=\"", 5246, "\"", 5260, 0);
            EndWriteAttribute();
            WriteLiteral(@" v-on:change=""regionClick"">
                        <label class=""form-check-label"" for=""productType"">
                            水上活動
                        </label>
                    </div>
                    <div class=""form-check"">
                        <input class=""form-check-input"" type=""checkbox"" value=""3"" id=""productType"" v-model=""TriptypeValue"" :true-value=""3""");
            BeginWriteAttribute("false-value", " false-value=\"", 5646, "\"", 5660, 0);
            EndWriteAttribute();
            WriteLiteral(@" v-on:change=""regionClick"">
                        <label class=""form-check-label"" for=""productType"">
                            地方特色
                        </label>
                    </div>
                    <div class=""form-check"">
                        <input class=""form-check-input"" type=""checkbox"" value=""4"" id=""productType"" v-model=""TriptypeValue"" :true-value=""4""");
            BeginWriteAttribute("false-value", " false-value=\"", 6046, "\"", 6060, 0);
            EndWriteAttribute();
            WriteLiteral(@" v-on:change=""regionClick"">
                        <label class=""form-check-label"" for=""productType"">
                            溫泉之旅
                        </label>
                    </div>
                    <div class=""form-check"">
                        <input class=""form-check-input"" type=""checkbox"" value=""5"" id=""productType"" v-model=""TriptypeValue"" :true-value=""5""");
            BeginWriteAttribute("false-value", " false-value=\"", 6446, "\"", 6460, 0);
            EndWriteAttribute();
            WriteLiteral(@" v-on:change=""regionClick"">
                        <label class=""form-check-label"" for=""productType"">
                            人文之旅
                        </label>
                    </div>


                </div>
            </div>
            <!--我是出發日-->
            <div class=""item"">
                <div class=""btn-datepicker btn d-flex gap-3 "" data-bs-toggle=""collapse"" data-bs-target=""#datepicker""
                     aria-expanded=""false"" aria-controls=""collapseExample"">
                    <span class=""text-muted""><i class=""bi bi-calendar""></i></span>
                    <p class=""fw-bold  mb-1"">篩選出發日期</p>
                </div>
            </div>

            <div class=""collapse mb-5"" id=""datepicker"">
                <div class=""card card-body"">
                    這邊想要置入日期選擇器
                </div>
            </div>

            <!--我是價錢-->
            <div class=""item"">
                <p class=""fw-bold mb-3"">價錢(TWD)</p>
                <label class=""form-label"" f");
            WriteLiteral(@"or=""customRange1"">Example range</label>
                <div class=""range"">
                    <input type=""range"" class=""form-range"" id=""customRange1"" />
                </div>
            </div>
            <!--行程時間-->
            <div class=""item"">
                <p class=""fw-bold mb-3"">行程天數</p>
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""checkbox"" value=""0"" id=""travelDays"" v-model=""TraveldaysValue"" :true-value=""0""");
            BeginWriteAttribute("false-value", " false-value=\"", 7972, "\"", 7986, 0);
            EndWriteAttribute();
            WriteLiteral(@" v-on:change=""regionClick"">
                    <label class=""form-check-label"" for=""travelDays"">
                        1天以內
                    </label>
                </div>
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""checkbox"" value=""1"" id=""travelDays"" v-model=""TraveldaysValue"" :true-value=""1""");
            BeginWriteAttribute("false-value", " false-value=\"", 8348, "\"", 8362, 0);
            EndWriteAttribute();
            WriteLiteral(@" v-on:change=""regionClick"">
                    <label class=""form-check-label"" for=""travelDays"">
                        1~3天
                    </label>
                </div>
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""checkbox"" value=""2"" id=""travelDays"" v-model=""TraveldaysValue"" :true-value=""2""");
            BeginWriteAttribute("false-value", " false-value=\"", 8724, "\"", 8738, 0);
            EndWriteAttribute();
            WriteLiteral(@" v-on:change=""regionClick"">
                    <label class=""form-check-label"" for=""travelDays"">
                        3~5天
                    </label>
                </div>
                <div class=""form-check"">
                    <input class=""form-check-input"" type=""checkbox"" value=""3"" id=""travelDays"" v-model=""TraveldaysValue"" :true-value=""3""");
            BeginWriteAttribute("false-value", " false-value=\"", 9100, "\"", 9114, 0);
            EndWriteAttribute();
            WriteLiteral(@" v-on:change=""regionClick"">
                    <label class=""form-check-label"" for=""travelDays"">
                        5天以上
                    </label>
                </div>
            </div>

        </div>
        <!--右側區塊-->
        <div class=""col-12 col-lg-9"">
            <!--商品排序器-->
            <div class=""filter-block mb-3"">
                <div class=""filter"">
                    <span class=""text-primary"">{{productTotal}}</span>項體驗行程
                </div>
                <hr class=""text-muted"">
                <div class=""d-flex flex-wrap"">
                    <div>
                        <p>排序 :</p>
                    </div>
                    <div>
                        ｜
                        <a");
            BeginWriteAttribute("href", " href=\"", 9868, "\"", 9875, 0);
            EndWriteAttribute();
            WriteLiteral("v-on:click.prevent=\"regionClick(orderbyClick=\'&orderby=originalprice\') \">kkday推薦</a>\r\n                    </div>\r\n                    <div>\r\n                        ｜\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 10070, "\"", 10077, 0);
            EndWriteAttribute();
            WriteLiteral(" v-on:click.prevent=\"regionClick(orderbyClick=\'&orderbydesc=originalprice\') \">熱門程度</a>\r\n                    </div>\r\n                    <div>\r\n                        ｜\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 10274, "\"", 10281, 0);
            EndWriteAttribute();
            WriteLiteral("v-on:click.prevent=\"regionClick(orderbyClick=\'&orderbydesc=customerRating\') \">用戶評價</a>\r\n                    </div>\r\n                    <div>\r\n                        ｜\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 10478, "\"", 10485, 0);
            EndWriteAttribute();
            WriteLiteral(@"v-on:click.prevent=""regionClick(orderbyClick='&orderby=originalprice') "">$價格：低到高</a>
                    </div>
                </div>
            </div>
            <!--商品單項-->
            <div id=""app"" v-for=""(item, index) in productList.slice(pageStart, pageStart + countOfPage)"" :key=""index"">
                <div class=""card mb-3"">
                    <div class=""row g-0"">
                        <div class=""col-md-4"">
                            <a v-bind:href="" '/ProductView/product/ '+ item.id "" target=""_blank"" rel=""noopener"">
                                <img v-bind:src=""item.productPictures[0].url""
                                     class=""w-100 img-fluid rounded-start product-pic"" alt=""..."">
                            </a>
                        </div>
                        <div class=""col-md-8"">
                            <div class=""card-body"">
                                <a v-bind:href="" '/ProductView/product/ '+ item.id "" target=""_blank"" rel=""noopener"">
            ");
            WriteLiteral(@"                        <div class=""d-flex justify-content-between"">
                                        <h5 class=""card-title mb-3"">{{item.title}}</h5>
                                        <div class=""text-muted"">
                                            <a href=""#"" class=""text-danger""><i class=""bi bi-heart""></i></a>
                                        </div>
                                    </div>
                                </a>

                                <!--商品內容敘述-->
                                <a v-bind:href="" '/ProductView/product/ '+ item.id "" target=""_blank"" rel=""noopener"">
                                    <p class=""card-text mb-3"">
                                        {{item.description |ellipsis}}
                                    </p>
                                </a>

                                <!--產品資訊：地點&日期-->
                                <a v-bind:href="" '/ProductView/product/ '+ item.id "" target=""_blank"" rel=""noopener"">
      ");
            WriteLiteral(@"                              <div class=""product-info mb-5 d-flex gap-3"">
                                        <!--地點-->
                                        <div class=""d-flex gap-1"">
                                            <span class=""text-muted""><i class=""bi bi-geo-alt-fill""></i></span>
                                            <p><small class=""text-muted"">地點:{{item.region}}</small></p>
                                        </div>
                                        <!--日期-->
                                        <div class=""d-flex gap-1"">
                                            <span class=""text-muted""><i class=""bi bi-calendar""></i></span>
                                            <p><small class=""text-muted"">最早可預訂日期：{{item.goTouristTime}}</small></p>
                                        </div>
                                    </div>
                                </a>
                                <!--產品資訊：評價&熱門程度&價格-->
                                <a");
            WriteLiteral(@" href=""#product-footer "" target=""_blank"" rel=""noopener"">
                                    <div class=""product-footer d-flex gap-3 position-absolute bottom-0 "">
                                        <!--評價-->
                                        <div class=""product-star d-flex"">
                                            <span class=""text-warning"">
                                                <i class=""bi bi-star-fill""></i>
                                            </span>
                                            <p><small class=""text-muted"">(星星評價數)</small></p>
                                        </div>
                                        <span class=""divider"">|</span>
                                        <!--熱門程度-->
                                        <div class=""prodcut-book d-flex gap-1 text-danger"">
                                            <span><i class=""fas fa-fire""></i></span>
                                            <p><small class=""text-muted"">xxxx個已訂");
            WriteLiteral(@"購</small></p>
                                        </div>
                                        <!--價格-->
                                        <div class=""product-price gap-3"">
                                            <div>
                                                <h4 class=""fw-bold"">TWD {{item.price }} </h4>
                                            </div>
                                        </div>
                                    </div>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div>{{error}}</div>


            <!--商品分頁-->
");
            WriteLiteral("            <div class=\"mt-5\">\r\n                <nav aria-label=\"Page navigation example\">\r\n");
            WriteLiteral("                    <ul class=\"pagination d-flex justify-content-center\">\r\n                        <!--<li class=\"page-item\" v-bind:class=\"{\'disabled\': (currPage === 1)}\"--> ");
            WriteLiteral("\r\n                        <!--");
            WriteLiteral("@click.prevent=\"setPage(currPage-1)\"><a class=\"page-link\" href=\"#\">&#60 Prev</a></li>-->\r\n");
            WriteLiteral("                        <li class=\"page-item\" v-for=\"n in totalPage\" v-bind:class=\"{\'active\': (currPage === (n))}\"\r\n                            ");
            WriteLiteral(@"@click.prevent=""setPage(n)"">
                            <a class=""page-link"" href=""#"">{{n}}</a>
                        </li>
                        <li class=""page-item"" v-bind:class=""{'disabled': (currPage === totalPage)}""
                            ");
            WriteLiteral("@click.prevent=\"setPage(currPage+1)\">\r\n                            <a class=\"page-link\"v-if=\"productTotal>0\" href=\"#\">></a>\r\n                        </li>\r\n                    </ul>\r\n                </nav>\r\n");
            WriteLiteral(@"            </div>

        </div>
    </div>
    <div class=""row row-cols-3"">
    </div>
</div>



<script>
    var app241 = new Vue({
        el: '#GetProducts',

        data: {
            productList: [],
            error: """",
            regionValue: """", // 開[]為多選   """"為單選
            TraveldaysValue: """",
            TriptypeValue: """",
            productTotal: '',
            orderbyClick: '',
            pageLeftBtn:true,


            countOfPage: 1,// 幾個一頁
            currPage: 1,//初始頁
            sectionObject: {
                ""North"": ""北北基"",
                ""MiddleNorth"": ""桃竹苗"",
                ""Middle"": ""中彰投"",
                ""MiddleSouth"": ""雲嘉南"",
                ""South"": ""高屏"",
                ""East"": ""宜花東"",
                ""OutsideIsland"": ""宜花東""
            },
            chRegion: """",


        },
        computed: {


            pageStart: function () {
                return (this.currPage - 1) * this.countOfPage;
            },
            tot");
            WriteLiteral(@"alPage: function () {
                return Math.ceil(this.productList.length / this.countOfPage);
            },
           
        },

        mounted: function () {
            var self = this;
            axios.get(""/api/products"").then(function (res) {
                for (let i of res.data) {
                    i.region = self.sectionObject[i.region];
                    i.goTouristTime = """" + i.goTouristTime;
                }
                self.productList = res.data;
                self.productTotal = res.data.length;
                //    self.chRegion = app1.sectionObject[res.data.region];
            })
        },

        methods: {
            regionClick: function () {
                var self = this;
                var regionValue = self.regionValue;
                var Traveldays = self.TraveldaysValue;
                var Triptype = self.TriptypeValue
                var orderbyClick = self.orderbyClick;
                // api/products?Traveldays=&Region=&Tri");
            WriteLiteral(@"ptype=
                //    axios.get(""/api/products?Region="" + regionValue + ""&Traveldays="" + Traveldays + ""&Triptype="" + Triptype).then(function (res) {

                //  self.productList = res.data;

                // })

                //   if (regionValue == false || Traveldays == false || Triptype == false) {
                //   axios.get(""/api/products"").then(function (res) {
                // self.productList = res.data;
                //if (regionValue == false || Traveldays == false || Triptype == false) {
                //    regionValue === """";
                //    Traveldays === "" "";
                //    Triptype === "" "";


                axios.get(""/api/products?Region="" + regionValue + ""&Traveldays="" + Traveldays + ""&Triptype="" + Triptype + orderbyClick).then(function (res) {
                    for (let i of res.data) {
                        i.region = self.sectionObject[i.region];

                    };

                    self.productList = res.data;
 ");
            WriteLiteral(@"                   self.error = """";
                    self.currPage = ""1"";
                    self.productTotal = res.data.length;
                    console.log(this.orderbyClick);
                    // console.log(regionValue, Traveldays, Triptype);
                }).catch(function (error) {
                    self.error = error.data;
                    self.productList = """";
                    self.productTotal = ""0"";


                    //    self.productList = error.data;
                    //    console.log(""沒有商品"");
                    //if (error.response.status == 404) {
                    //    self.productList = error.data;
                    //    console.log(""沒有商品"");
                    //} if (error.response.status == 500) {
                    //    self.productList = error.data;
                    //    console.log(""沒有商品"");
                    /*  }*/
                })
                // }
            },
            setPage: function (idx) {//設定頁面
       ");
            WriteLiteral(@"         if (idx <= 0 || idx > this.totalPage) {
                    return;
                }
                this.currPage = idx;
            },
            //originalpriceClick: function () {
            //    axios.get(""/api/products?orderby="" + orderbyClick).then(function (res) {
            //        self.productList = res.data;
            //    })
            //},
        },
        filters: {
            ellipsis(value) {
                if (!value) return '';
                if (value.length > 50) {
                    return value.slice(0, 50) + '...'//第幾個字加...
                }
                return value
            }
        },
    





        //methods: {
        //    regionClick: function () {
        //        var self = this;
        //        var a = self.regionValue;
        //        if (a == true) {
        //            a = ""0"";
        //            axios.get(""/api/products?Region="" + a).then(function (res) {
        //                self.productLi");
            WriteLiteral(@"st = res.data;
        //            })
        //        }
        //        if (a == false) {
        //            axios.get(""/api/products"").then(function (res) {
        //                self.productList = res.data;
        //            })
        //        }
        //        }
        //    }
    });
</script>");
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

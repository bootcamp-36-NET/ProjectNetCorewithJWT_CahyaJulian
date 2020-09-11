#pragma checksum "C:\Users\User\source\repos\LearnNetCore\JSON-Web-Token_CahyaJulian\LearnNetCore\WebApp\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4981f21b9b939a0d0826bfb106c331bcf8df8aa8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dashboard/Index.cshtml", typeof(AspNetCore.Views_Dashboard_Index))]
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
#line 1 "C:\Users\User\source\repos\LearnNetCore\JSON-Web-Token_CahyaJulian\LearnNetCore\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#line 2 "C:\Users\User\source\repos\LearnNetCore\JSON-Web-Token_CahyaJulian\LearnNetCore\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4981f21b9b939a0d0826bfb106c331bcf8df8aa8", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\User\source\repos\LearnNetCore\JSON-Web-Token_CahyaJulian\LearnNetCore\WebApp\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Layout/Layout.cshtml";

#line default
#line hidden
            BeginContext(89, 3740, true);
            WriteLiteral(@"
<!-- Content Row -->
<div class=""row"">

    <!-- Earnings (Monthly) Card Example -->
    <div class=""col-xl-3 col-md-6 mb-4"">
        <div class=""card border-left-primary shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-primary text-uppercase mb-1"">Earnings (Monthly)</div>
                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">$40,000</div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fas fa-calendar fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Earnings (Monthly) Card Example -->
    <div class=""col-xl-3 col-md-6 mb-4"">
        <div class=""card border-left-success shadow h-100 py-2"">
            <div class=""card-body"">
                <div clas");
            WriteLiteral(@"s=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-success text-uppercase mb-1"">Earnings (Annual)</div>
                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">$215,000</div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fas fa-dollar-sign fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Earnings (Monthly) Card Example -->
    <div class=""col-xl-3 col-md-6 mb-4"">
        <div class=""card border-left-info shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-info text-uppercase mb-1"">Tasks</div>
                        <div class=""row no-gutters align-items-center"">");
            WriteLiteral(@"
                            <div class=""col-auto"">
                                <div class=""h5 mb-0 mr-3 font-weight-bold text-gray-800"">50%</div>
                            </div>
                            <div class=""col"">
                                <div class=""progress progress-sm mr-2"">
                                    <div class=""progress-bar bg-info"" role=""progressbar"" style=""width: 50%"" aria-valuenow=""50"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fas fa-clipboard-list fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Pending Requests Card Example -->
    <div class=""col-xl-3 col-md-6 mb-4"">
        <div class=""card border-left-warning shadow h-100 py-2"">
            <div class=""c");
            WriteLiteral(@"ard-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-warning text-uppercase mb-1"">Pending Requests</div>
                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">18</div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fas fa-comments fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <canvas id=""myChart"" width=""400"" height=""400""></canvas>
</div>

<!-- Content Row -->
");
            EndContext();
            DefineSection("scriptdbAdmin", async() => {
                BeginContext(3852, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
                BeginContext(5106, 3487, true);
                WriteLiteral(@"    <script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.8.0/Chart.bundle.js"" integrity=""sha256-qSIshlknROr4J8GMHRlW3fGKrPki733tLq+qeMCR05Q="" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.8.0/Chart.bundle.min.js"" integrity=""sha256-xKeoJ50pzbUGkpQxDYHD7o7hxe0LaOGeguUidbq6vis="" crossorigin=""anonymous""></script>
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.8.0/Chart.css"" integrity=""sha256-IvM9nJf/b5l2RoebiFno92E5ONttVyaEEsdemDC6iQA="" crossorigin=""anonymous"" />
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.8.0/Chart.js"" integrity=""sha256-arMsf+3JJK2LoTGqxfnuJPFTU4hAK57MtIPdFpiHXOU="" crossorigin=""anonymous""></script>
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.8.0/Chart.min.css"" integrity=""sha256-aa0xaJgmK/X74WM224KMQeNQC2xYKwlAt08oZqjeF0E="" crossorigin=""anonymous"" />
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.8.0/Chart.min.j");
                WriteLiteral(@"s"" integrity=""sha256-Uv9BNBucvCPipKQ2NS9wYpJmi8DTOEfTA/nH2aoJALw="" crossorigin=""anonymous""></script>
    <script>
        function GetJSON_Simple() {
            var resp = [];
            $.ajax({
                type: ""GET"",
                url: '/DivisionWeb/LoadChar',
                async: false,
                contentType: ""application/json"",
                success: function (data) {
                    resp.push(data);
                },
                error: function (req, status, error) {
                    // do something with error
                    alert(""error"");
                }
            });
            return resp;
        }
        var simpleData = GetJSON_Simple();
        var ctx = document.getElementById(""canvas"")
        var lineChartData = {
            labels: simpleData[0].myDate,
            datasets: [{
                label: 'Sucess',
                borderColor: ""MediumSeaGreen"",
                backgroundColor: ""MediumSeaGreen"",
                ");
                WriteLiteral(@"fill: false,
                data: simpleData[0].mySuccess,
                yAxisID: 'y-axis-1',
            }, {
                label: 'Exceptioned',
                borderColor: ""Tomato"",
                backgroundColor: ""Tomato"",
                fill: false,
                data: simpleData[0].myException,
                yAxisID: 'y-axis-2'
            }]
        };

        window.myLine = Chart.Line(ctx, {
            data: lineChartData,
            options: {
                responsive: true,
                hoverMode: 'index',
                stacked: false,
                title: {
                    display: true,
                    text: 'Processes'
                },
                scales: {
                    yAxes: [{
                        type: 'linear',
                        display: true,
                        position: 'left',
                        id: 'y-axis-1',
                    }, {
                        type: 'linear',
                   ");
                WriteLiteral(@"     display: true,
                        position: 'right',
                        id: 'y-axis-2',

                        // grid line settings
                        gridLines: {
                            drawOnChartArea: false, // only want the grid lines for one axis to show up
                        },
                    }],
                }
            }
        });

    </script>
");
                EndContext();
            }
            );
            BeginContext(8596, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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

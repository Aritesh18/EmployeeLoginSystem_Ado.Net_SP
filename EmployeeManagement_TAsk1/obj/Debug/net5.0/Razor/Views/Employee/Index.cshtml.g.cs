#pragma checksum "D:\CS SOFT SOL\EmployeeManagement_TAsk1\EmployeeManagement_TAsk1\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07c54d8214c1ecb3a7401bcc0448cd74962709fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
#line 1 "D:\CS SOFT SOL\EmployeeManagement_TAsk1\EmployeeManagement_TAsk1\Views\_ViewImports.cshtml"
using EmployeeManagement_TAsk1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CS SOFT SOL\EmployeeManagement_TAsk1\EmployeeManagement_TAsk1\Views\_ViewImports.cshtml"
using EmployeeManagement_TAsk1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07c54d8214c1ecb3a7401bcc0448cd74962709fd", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef22bcbd0ac7a13e9a9eff7f8f5ac20b4d5530d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Employee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("employeeForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\CS SOFT SOL\EmployeeManagement_TAsk1\EmployeeManagement_TAsk1\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Employee List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2 class=\"text-primary text-center\">Employee List</h2>\r\n\r\n<p>\r\n    ");
#nullable restore
#line 10 "D:\CS SOFT SOL\EmployeeManagement_TAsk1\EmployeeManagement_TAsk1\Views\Employee\Index.cshtml"
Write(Html.ActionLink("Create New", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <button id=\"exportSelected\" class=\"btn btn-primary\">Export Selected to Excel</button>\r\n</p>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07c54d8214c1ecb3a7401bcc0448cd74962709fd4352", async() => {
                WriteLiteral(@"
    <table id=""employeeTable"" class=""table table-bordered table-striped table-responsive"">
        <thead>
            <tr>
                <th>
                    <input type=""checkbox"" id=""selectAll"" />
                </th>
                <th class=""sortable"" data-column=""FirstName"">First Name</th>
                <th class=""sortable"" data-column=""LastName"">Last Name</th>
                <th class=""sortable"" data-column=""Email"">Email</th>
                <th class=""sortable"" data-column=""Mobile"">Mobile</th>
                <th class=""sortable"" data-column=""Address"">Address</th>
                <th class=""sortable"" data-column=""Actions"">Actions</th>
            </tr>
        </thead>
        <tbody></tbody>
    </table>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://cdn.datatables.net/1.11.3/css/jquery.dataTables.min.css"">
    <script src=""https://code.jquery.com/jquery-3.6.0.min.js""></script>
    <script src=""https://cdn.datatables.net/1.11.3/js/jquery.dataTables.min.js""></script>
    <script src=""https://cdn.jsdelivr.net/npm/sweetalert2@10""></script>
    <script>
        $(document).ready(function () {
            $('#employeeTable').DataTable({
                ""processing"": true,
                ""serverSide"": true,
                ""ajax"": {
                    ""url"": """);
#nullable restore
#line 44 "D:\CS SOFT SOL\EmployeeManagement_TAsk1\EmployeeManagement_TAsk1\Views\Employee\Index.cshtml"
                       Write(Url.Action("GetEmployees", "Employee"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                    ""type"": ""POST""
                },
                ""columns"": [
                    { ""data"": null },
                    { ""data"": ""FirstName"" },
                    { ""data"": ""LastName"" },
                    { ""data"": ""Email"" },
                    { ""data"": ""Mobile"" },
                    { ""data"": ""Address"" },
                    {
                        ""data"": null,
                        ""render"": function (data, type, row) {
                            return '<a href=""/Employee/Update/' + row.Id + '"">Update</a> | ' +
                                '<a href=""/Employee/Delete/' + row.Id + '"">Delete</a>';
                        }
                    }
                ],
                ""columnDefs"": [
                    {
                        ""targets"": 0,
                        ""orderable"": false,
                        ""render"": function (data, type, row) {
                            return '<input type=""checkbox"" name=""selectedEmployees"" value=");
                WriteLiteral(@"""' + row.Id + '"" />';
                        }
                    }
                ],
                ""pageLength"": 10
            });

            $('#selectAll').on('click', function () {
                $('input[name=""selectedEmployees""]').prop('checked', this.checked);
            });

            $('#exportSelected').on('click', function () {
                var selectedEmployees = [];
                $('input[name=""selectedEmployees""]:checked').each(function () {
                    selectedEmployees.push($(this).val());
                });

                if (selectedEmployees.length > 0) {
                    var url = '");
#nullable restore
#line 85 "D:\CS SOFT SOL\EmployeeManagement_TAsk1\EmployeeManagement_TAsk1\Views\Employee\Index.cshtml"
                          Write(Url.Action("ExportToExcel", "Employee"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
                    var form = $('#employeeForm');
                    form.attr('action', url);
                    form.attr('method', 'POST');
                    form.append('<input type=""hidden"" name=""selectedEmployees"" value=""' + selectedEmployees.join(',') + '"">');
                    form.submit();
                } else {
                    Swal.fire({
                        icon: 'error',
                        title: 'No employees selected!',
                        text: 'Please select at least one employee to export.'
                    });
                }
            });
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "G:\renwu5\renwu5\Views\cyf\login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9a344ba2ca4399471287bf4b22a203470a75b0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_cyf_login), @"mvc.1.0.view", @"/Views/cyf/login.cshtml")]
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
#line 1 "G:\renwu5\renwu5\Views\_ViewImports.cshtml"
using renwu5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\renwu5\renwu5\Views\_ViewImports.cshtml"
using renwu5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9a344ba2ca4399471287bf4b22a203470a75b0e", @"/Views/cyf/login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89cfbce6c29e75f7247e853ce041434ae4ae3b5d", @"/Views/_ViewImports.cshtml")]
    public class Views_cyf_login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9a344ba2ca4399471287bf4b22a203470a75b0e3122", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <title> 注册 </title>\r\n    <link rel=\"stylesheet\" href=\"https://unpkg.com/element-ui/lib/theme-chalk/index.css\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9a344ba2ca4399471287bf4b22a203470a75b0e4244", async() => {
                WriteLiteral(@"
    <el-container id=""box"" style=""width:50%;height:800px"">
        <el-main>
            <el-form v-model=""user"">
                <el-form-item label=""用户名"" place-holder=""请输入用户名"">
                    <el-input v-model=""user.userName""></el-input>
                </el-form-item>
                <el-form-item label=""邮箱"">
                    <el-input v-model=""user.userName"" placeholder=""请输入邮箱""></el-input>
                </el-form-item>
                <el-form-item label=""性别"">
                    <el-radio v-model=""user.radio"" label=""boy""> 男 </el-radio>
                    <el-radio v-model=""user.radio"" label=""gril""> 女 </el-radio>
                </el-form-item>
                <el-form-item label=""所在城市"">
                    <el-select v-model=""user.sity"">
                        <el-option label=""北京""></el-option>
                        <el-option label=""上海""></el-option>
                        <el-option label=""广东""></el-option>
                        <el-option label=""西藏""></el-option>
   ");
                WriteLiteral(@"                     <el-option label=""内蒙古""></el-option>
                        <el-option label=""浙江""></el-option>
                        <el-option label=""其他""></el-option>
                    </el-select>
                </el-form-item>
                <el-form-item label=""生日"">
                    <el-date-picker v-model=""user.date"">
                    </el-date-picker>
                </el-form-item>
                <el-form-item label=""爱好"">
                    <el-checkbox label=""篮球"" checked=""true""></el-checkbox>
                    <el-checkbox label=""足球""></el-checkbox>
                    <el-checkbox label=""网球""></el-checkbox>
                    <el-checkbox label=""乒乓球""></el-checkbox>
                </el-form-item>
                <el-row>
                    <el-col style=""text-align: center"">
                        <el-button type=""primary"">注册</el-button>
                        <el-button>取消</el-button>
                    </el-col>
                </el-row>
            </el");
                WriteLiteral("-form>\r\n        </el-main>\r\n    </el-container>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script src=""https://cdn.jsdelivr.net/npm/vue/dist/vue.js""></script>
<!-- 引入组件库 -->
<script src=""https://unpkg.com/element-ui/lib/index.js""></script>
<script>
    const zhuce = new Vue({
        el: '#box',
        data: {
            user: {
                userName: """",
                email: """",
                radio:1,
                sity:"""",
                date:"""",
                hobby:""""
            }
        }
    })
</script>
</html>");
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
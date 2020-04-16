#pragma checksum "C:\Users\Wêsley Lucena\Documents\ToDo\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0a8e64c2b70d421382ad32dc2e346f4be4fa38e"
// <auto-generated/>
#pragma warning disable 1591
namespace ToDo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\Wêsley Lucena\Documents\ToDo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\Wêsley Lucena\Documents\ToDo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "C:\Users\Wêsley Lucena\Documents\ToDo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 4 "C:\Users\Wêsley Lucena\Documents\ToDo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 5 "C:\Users\Wêsley Lucena\Documents\ToDo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "C:\Users\Wêsley Lucena\Documents\ToDo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 7 "C:\Users\Wêsley Lucena\Documents\ToDo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 8 "C:\Users\Wêsley Lucena\Documents\ToDo\_Imports.razor"
using ToDo;

#line default
#line hidden
#line 9 "C:\Users\Wêsley Lucena\Documents\ToDo\_Imports.razor"
using ToDo.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-6");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "todolist not-done");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.AddMarkupContent(12, "<h1>Lista de Tarefas</h1>\r\n              \r\n                ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "class", "");
            __builder.AddAttribute(15, "placeholder", "Tarefa");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 9 "C:\Users\Wêsley Lucena\Documents\ToDo\Pages\Index.razor"
                              NewTarefa

#line default
#line hidden
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NewTarefa = __value, NewTarefa));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n                ");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "id", "checkAll");
            __builder.AddAttribute(21, "class", "btn btn-success");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 11 "C:\Users\Wêsley Lucena\Documents\ToDo\Pages\Index.razor"
                                                                        AddNewTask

#line default
#line hidden
            ));
            __builder.AddContent(23, "Adiciona");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                <hr>\r\n                ");
            __builder.OpenElement(25, "ul");
            __builder.AddAttribute(26, "id", "sortable");
            __builder.AddAttribute(27, "class", "list-unstyled");
            __builder.AddMarkupContent(28, "\r\n\r\n");
#line 15 "C:\Users\Wêsley Lucena\Documents\ToDo\Pages\Index.razor"
                     foreach (var item in tarefas.Where(x=>x.Feito==false))
                    {
                         
                            

#line default
#line hidden
            __builder.AddContent(29, "                                ");
            __builder.OpenElement(30, "li");
            __builder.AddMarkupContent(31, "\r\n                                 ");
            __builder.OpenElement(32, "label");
            __builder.AddMarkupContent(33, "\r\n                                        ");
            __builder.OpenElement(34, "input");
            __builder.AddAttribute(35, "type", "checkbox");
            __builder.AddAttribute(36, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 21 "C:\Users\Wêsley Lucena\Documents\ToDo\Pages\Index.razor"
                                                      item.Feito

#line default
#line hidden
            ));
            __builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => item.Feito = __value, item.Feito));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, " \r\n                                        ");
            __builder.AddContent(39, 
#line 22 "C:\Users\Wêsley Lucena\Documents\ToDo\Pages\Index.razor"
                                         item.Tarefa

#line default
#line hidden
            );
            __builder.AddMarkupContent(40, "\r\n                                \r\n                                 ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
#line 26 "C:\Users\Wêsley Lucena\Documents\ToDo\Pages\Index.razor"
                            
                     }

#line default
#line hidden
            __builder.AddContent(43, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n\r\n                ");
            __builder.AddMarkupContent(45, "<div class=\"todo-footer\">\r\n                    <strong><span class=\"count-todos\"></span></strong> Tarefas\r\n                </div>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n        ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "col-md-6");
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "todolist");
            __builder.AddMarkupContent(53, "\r\n                ");
            __builder.AddMarkupContent(54, "<h1>Feitas</h1>\r\n                ");
            __builder.OpenElement(55, "ul");
            __builder.AddAttribute(56, "id", "done-items");
            __builder.AddAttribute(57, "class", "list-unstyled");
            __builder.AddMarkupContent(58, "\r\n                    ");
            __builder.OpenElement(59, "li");
            __builder.AddMarkupContent(60, "\r\n                        ");
            __builder.OpenElement(61, "ul");
            __builder.AddAttribute(62, "id", "sortable");
            __builder.AddAttribute(63, "class", "list-unstyled");
            __builder.AddMarkupContent(64, "\r\n                            \r\n\r\n");
#line 43 "C:\Users\Wêsley Lucena\Documents\ToDo\Pages\Index.razor"
                             foreach (var item in tarefas.Where(x=>x.Feito == true))
                            {
                             

#line default
#line hidden
            __builder.AddContent(65, "                                    ");
            __builder.OpenElement(66, "li");
            __builder.AddMarkupContent(67, "\r\n                                         ");
            __builder.OpenElement(68, "label");
            __builder.AddMarkupContent(69, "\r\n                                            ");
            __builder.OpenElement(70, "input");
            __builder.AddAttribute(71, "type", "checkbox");
            __builder.AddAttribute(72, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 48 "C:\Users\Wêsley Lucena\Documents\ToDo\Pages\Index.razor"
                                                          item.Feito

#line default
#line hidden
            ));
            __builder.AddAttribute(73, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => item.Feito = __value, item.Feito));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddContent(74, 
#line 48 "C:\Users\Wêsley Lucena\Documents\ToDo\Pages\Index.razor"
                                                                                         item.Tarefa

#line default
#line hidden
            );
            __builder.AddMarkupContent(75, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n");
#line 51 "C:\Users\Wêsley Lucena\Documents\ToDo\Pages\Index.razor"
                                
                            }

#line default
#line hidden
            __builder.AddContent(78, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 63 "C:\Users\Wêsley Lucena\Documents\ToDo\Pages\Index.razor"
       
    public class ListaTarefa
    {

        public string Tarefa { get; set; }
        public bool Feito { get; set; }
    }

    private string NewTarefa = "";

    private List<ListaTarefa> tarefas = new List<ListaTarefa>();

    void AddNewTask()
    {
        if (!string.IsNullOrWhiteSpace(NewTarefa))
        {
            tarefas.Add(new ListaTarefa {  Tarefa = NewTarefa });
            NewTarefa = "";
        }
    }


#line default
#line hidden
    }
}
#pragma warning restore 1591
#pragma checksum "/Users/miguelgondres/Projects/PersonaBlazor/Pages/RegistroPersona.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73c371cb6edb677443e18be852d7e43017af66c3"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PersonaBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/miguelgondres/Projects/PersonaBlazor/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/miguelgondres/Projects/PersonaBlazor/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/miguelgondres/Projects/PersonaBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/miguelgondres/Projects/PersonaBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/miguelgondres/Projects/PersonaBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/miguelgondres/Projects/PersonaBlazor/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/miguelgondres/Projects/PersonaBlazor/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/miguelgondres/Projects/PersonaBlazor/_Imports.razor"
using PersonaBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/miguelgondres/Projects/PersonaBlazor/_Imports.razor"
using PersonaBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/miguelgondres/Projects/PersonaBlazor/_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/miguelgondres/Projects/PersonaBlazor/_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/miguelgondres/Projects/PersonaBlazor/Pages/RegistroPersona.razor"
using PersonaBlazor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/miguelgondres/Projects/PersonaBlazor/Pages/RegistroPersona.razor"
using PersonaBlazor.BLL;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Persona")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Persona/{ID:int}")]
    public partial class RegistroPersona : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "/Users/miguelgondres/Projects/PersonaBlazor/Pages/RegistroPersona.razor"
      
  

    [Parameter]
    public int ID { get; set; }

    private Personas personas=new Personas();
    protected override void OnInitialized()
    {
            Nuevo();
            Buscar();
    } 

    public void Nuevo()
    {
        personas= new Personas();
    }

    private void Buscar()
    {
       
        if(personas.ID>0)
        {
            var encontrado = PersonasBLL.Buscar(personas.ID);

            if(encontrado != null)
                this.personas= encontrado;
            else
                Toast.ShowWarning("No encontrado");
        }
    }

    private void Guardar()
    {
        bool guardo;

        guardo = PersonasBLL.Guardar(personas);

        if(guardo)
        {
            
            Toast.ShowSuccess("Guardado Correctamente");
            Nuevo();

        }
        else
            Toast.ShowError("No fue posible guardar");
    }

    public void Eliminar()
    {
        bool elimino;

        elimino= PersonasBLL.Eliminar(personas.ID);

        if(elimino)
        {
            Nuevo();
            Toast.ShowSuccess("Eliminado Correctamente");

        }
        else
            Toast.ShowError("No fue posible eliminar");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService Toast { get; set; }
    }
}
#pragma warning restore 1591

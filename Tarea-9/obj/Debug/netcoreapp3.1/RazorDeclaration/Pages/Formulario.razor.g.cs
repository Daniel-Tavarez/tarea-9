// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Tarea_9.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\tarea-9\Tarea-9\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\tarea-9\Tarea-9\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\tarea-9\Tarea-9\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\tarea-9\Tarea-9\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\tarea-9\Tarea-9\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\tarea-9\Tarea-9\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\tarea-9\Tarea-9\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\tarea-9\Tarea-9\_Imports.razor"
using Tarea_9;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\tarea-9\Tarea-9\_Imports.razor"
using Tarea_9.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\tarea-9\Tarea-9\Pages\Formulario.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/formulario")]
    public partial class Formulario : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "C:\Users\ESTUDIANTE\Desktop\tareas itla\prog 3\tarea-9\Tarea-9\Pages\Formulario.razor"
       
    string Latitud;
    string Longitud;
    string PositivoCovid;
    string error = "";
    bool ok = true;
    Vacunado vacunado = new Vacunado();
    void Validar()
    {
        error = "";
        ok = true;

        try
        {
            if (vacunado.Cedula.Length == 11)
            {
                Int64 nCedula = Int64.Parse(vacunado.Cedula);
            }
            else
            {
                ok = false;
                error = error + "La cedula debe tener 11 digitos.";
            }
        }
        catch
        {
            ok = false;
            error = error + "La cedula debe de ser solo numeros.";
        }
        if (vacunado.Nombre == null || vacunado.Nombre == "")
        {
            ok = false;
            error = error + "\nEl nombre es obligatorio.";
        }
        if (vacunado.Apellidos == null || vacunado.Apellidos == "")
        {
            ok = false;
            error = error + "\nLos apellidos son obligatorios.";
        }
        try
        {
            if (vacunado.Telefono.Length == 10)
            {
                Int64 nTelefono = Int64.Parse(vacunado.Telefono);
            }
            else
            {
                ok = false;
                error = error + "\nEl telefono debe tener 10 caracteres (xxx-xxx-xxxx).";
            }
        }
        catch
        {
            ok = false;
            error = error + "\nEl telefono debe de ser solo numeros.";
        }

        if (vacunado.Correo != null)
        {
            var foo = new EmailAddressAttribute();
            if (!foo.IsValid(vacunado.Correo))
            {
                ok = false;
                error = error + "\nEl correo no es valido.";
            }
        }
        else
        {
            ok = false;
            error = error + "\nEl correo es obligatorio.";
        }
        if (vacunado.Fnacimiento == null)
        {
            ok = false;
            error = error + "\nLa fecha de nacimiento es obligatoria.";
        }
        if (vacunado.Sangre == null || vacunado.Sangre == "0")
        {
            ok = false;
            error = error + "\nEl tipo de sangre es obligatorio.";
        }
        if (vacunado.Provincia == null || vacunado.Provincia == "")
        {
            ok = false;
            error = error + "\nLa provincia es obligatoria.";
        }
        if (vacunado.Direccion == null || vacunado.Direccion == "")
        {
            ok = false;
            error = error + "\nLa direccion es obligatoria.";
        }
        if (Latitud == null || Latitud == "")
        {
            ok = false;
            error = error + "\nLa latitud es oblig\natoria.";
        }
        else
        {
            try
            {
                double l = double.Parse(Latitud);
            }
            catch
            {
                error = error + "\nLatitud invalida.";
            }
        }
        if (Longitud == null || Longitud == "")
        {
            ok = false;
            error = error + "\nLa longitud es obligatoria.";
        }
        else
        {
            try
            {
                double l = double.Parse(Latitud);
            }
            catch
            {
                error = error + "\nLongitud invalida.";
            }
        }
        if (PositivoCovid == null || PositivoCovid == "default")
        {
            ok = false;
            error = error + "\nSeleccione si le ha dado covid o no.";
        }
        if (vacunado.Justificacion == null || vacunado.Justificacion == "")
        {
            ok = false;
            error = error + "\nLa justificacion es obligatoria.";
        }
        if (ok)
        {
            mandarCorreo();
        }
    }
    void mandarCorreo()
        {
            //manda el correo
        }
    void getCoordenadas()
    {
        //hace la cosa para conseguir las coordenadas
    }
    class Vacunado
    {
        public string Cedula;
        public string Nombre;
        public string Apellidos;
        public string Telefono;
        public string Correo;
        public DateTime Fnacimiento = DateTime.Now;
        public string Sangre;
        public string Provincia;
        public string Direccion;
        public double Latitud;
        public double Longitud;
        public int PositivoCovid;
        public string Justificacion;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

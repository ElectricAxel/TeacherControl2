//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegEstudiantes.Enlace_de_datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class PagosDeuda
    {
        public int IdPago { get; set; }
        public System.DateTime Fecha { get; set; }
        public int IdEstudiante { get; set; }
        public int IdAsignatura { get; set; }
        public int IdDeuda { get; set; }
        public int CantidadPagada { get; set; }
    }
}

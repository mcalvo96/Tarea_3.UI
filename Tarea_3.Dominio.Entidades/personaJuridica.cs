//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tarea_3.Dominio.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class personaJuridica
    {
        public int idPersonaJuridica { get; set; }
        public int cedulaJuridica { get; set; }
        public string razonSocial { get; set; }
        public string nombreFantasia { get; set; }
        public string filial { get; set; }
        public string estado { get; set; }
        public string nombreEntidad { get; set; }
        public string intensidad { get; set; }
        public string atributo { get; set; }
        public Nullable<int> allanada { get; set; }
    
        public virtual persona persona { get; set; }
    }
}

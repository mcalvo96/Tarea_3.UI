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
    
    public partial class delito
    {
        public int idDelito { get; set; }
        public string origen { get; set; }
        public System.Guid numeroUnico { get; set; }
        public string modalidad { get; set; }
        public string victima { get; set; }
        public string subvictima { get; set; }
        public System.DateTime fechaIngreso { get; set; }
        public string perjuicio { get; set; }
        public string moneda { get; set; }
        public int tentativa { get; set; }
        public string observacion { get; set; }
        public string narracion { get; set; }
        public int idCatDelito { get; set; }
        public Nullable<int> idSubCatDelito { get; set; }
        public Nullable<int> idDelitoSec { get; set; }
        public int idOficina { get; set; }
        public int idHecho { get; set; }
    
        public virtual categoriaDelito categoriaDelito { get; set; }
        public virtual delitoSecundario delitoSecundario { get; set; }
        public virtual hecho hecho { get; set; }
        public virtual oficina oficina { get; set; }
        public virtual subCategoriaDelito subCategoriaDelito { get; set; }
    }
}

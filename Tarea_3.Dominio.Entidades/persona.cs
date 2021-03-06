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
    
    public partial class persona
    {
        public string nombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public string estadoCivil { get; set; }
        public string sexo { get; set; }
        public string nacionalidad { get; set; }
        public string profesion { get; set; }
        public System.DateTime fechaNacimiento { get; set; }
        public int edad { get; set; }
        public string observacion { get; set; }
        public Nullable<int> detenido { get; set; }
        public Nullable<int> desaparecido { get; set; }
        public Nullable<int> revisado { get; set; }
        public int idCaracteristica { get; set; }
        public int identificacion { get; set; }
        public int idPoblacion { get; set; }
        public int idRol { get; set; }
        public int idImagen { get; set; }
    
        public virtual alias alias { get; set; }
        public virtual caracteristicaPersona caracteristicaPersona { get; set; }
        public virtual expediente expediente { get; set; }
        public virtual imagen imagen { get; set; }
        public virtual poblacionVulnerable poblacionVulnerable { get; set; }
        public virtual rol rol { get; set; }
        public virtual tipoIdentificacion tipoIdentificacion { get; set; }
        public virtual personaJuridica personaJuridica { get; set; }
        public virtual policia policia { get; set; }
    }
}

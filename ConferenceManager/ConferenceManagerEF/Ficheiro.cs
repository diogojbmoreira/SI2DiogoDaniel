//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConferenceManagerEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ficheiro
    {
        public string nome { get; set; }
        public int idArtigo { get; set; }
        public string nomeConferencia { get; set; }
        public int anoConferencia { get; set; }
    
        public virtual Artigo Artigo { get; set; }
    }
}

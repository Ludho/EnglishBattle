//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnglishBattle.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Question
    {
        public int id { get; set; }
        public int idPartie { get; set; }
        public int idVerbe { get; set; }
        public string reponseParticipePasse { get; set; }
        public string reponsePreterit { get; set; }
        public System.DateTime dateEnvoie { get; set; }
        public Nullable<System.DateTime> dateReponse { get; set; }
    
        public virtual Partie Partie { get; set; }
        public virtual Verbe Verbe { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Formula1_EF_CF
{
    using System;
    using System.Collections.Generic;
    
    public partial class PILOTOCARRO
    {
        public System.DateTime Data_Evento { get; set; }
        public int Id_Carro { get; set; }
        public int Id_Piloto { get; set; }
    
        public virtual PILOTO CARRO { get; set; }
        public virtual PILOTO PILOTO { get; set; }

        public override string ToString()
        {
            return $"Data_Evento: {this.Data_Evento}" +
                $"\nId_Carro: {this.Id_Carro}" +
                $"\nId_Piloto: {this.Id_Piloto}";
        }
    }
}

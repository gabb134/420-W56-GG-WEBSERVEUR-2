//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dbfirst.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Entreprise_Address
    {
        public int AddressID { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string EntrepriseAddWeb { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public int AddressTypeID { get; set; }
        public int EntrepriseID { get; set; }
    
        public virtual Entreprise_AddressType Entreprise_AddressType { get; set; }
        public virtual Entreprise_Entreprise Entreprise_Entreprise { get; set; }
    }
}

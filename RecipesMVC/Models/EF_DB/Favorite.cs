//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RecipesMVC.Models.EF_DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Favorite
    {
        public int ID { get; set; }
        public int RecipeID { get; set; }
        public int UserID { get; set; }
    
        public virtual Recipe Recipe { get; set; }
        public virtual User User { get; set; }
    }
}

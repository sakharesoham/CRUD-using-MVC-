//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcFullCRUD.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tbl_Student
    {
        public int ID { get; set; }
        [Required][MinLength(5)]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required][EmailAddress]
        public string Email { get; set; }
        [Required][MinLength(10)]
        public string Mobile { get; set; }
        public string Description { get; set; }
    }
}
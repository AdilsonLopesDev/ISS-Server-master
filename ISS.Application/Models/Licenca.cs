﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class Licenca
    {
        public Licenca()
        {
            Menu = new HashSet<Menu>();
        }

        [StringLength(50)]
        public string IdLicenca { get; set; }
        [StringLength(50)]
        public string ChaveLicenca { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataFim { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataInicio { get; set; }
        public int NumLicenca { get; set; }

        [InverseProperty("Licenca")]
        public virtual ICollection<Menu> Menu { get; set; }
    }
}
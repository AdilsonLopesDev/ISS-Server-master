﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class LicencaModuloUser
    {
        [StringLength(50)]
        public string IdLicencaModuloUser { get; set; }
        [Column("LicencaModuloID")]
        [StringLength(50)]
        public string LicencaModuloId { get; set; }

        [ForeignKey("LicencaModuloId")]
        [InverseProperty("LicencaModuloUser")]
        public virtual LicencaModulo LicencaModulo { get; set; }
    }
}
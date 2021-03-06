﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class TaxaPremioFixoIndicNome
    {
        [StringLength(50)]
        public string IdTaxaPremioFixo { get; set; }
        public double? ValorMin { get; set; }
        public double? ValorMax { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataActualizacao { get; set; }
        [StringLength(50)]
        public string EstadoId { get; set; }
        public bool? IsTaxa { get; set; }

        [ForeignKey("EstadoId")]
        [InverseProperty("TaxaPremioFixoIndicNome")]
        public virtual Estado Estado { get; set; }
    }
}
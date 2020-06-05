﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class ContratoMoeda
    {
        [StringLength(50)]
        public string IdContratoMoeda { get; set; }
        [StringLength(50)]
        public string MoedaId { get; set; }
        [StringLength(50)]
        public string ContratoId { get; set; }
        [StringLength(50)]
        public string CodContratoMoeda { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }

        [ForeignKey("ContratoId")]
        [InverseProperty("ContratoMoeda")]
        public virtual Contrato Contrato { get; set; }
        [ForeignKey("MoedaId")]
        [InverseProperty("ContratoMoeda")]
        public virtual Moeda Moeda { get; set; }
    }
}
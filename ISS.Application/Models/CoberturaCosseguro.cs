﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class CoberturaCosseguro
    {
        [StringLength(50)]
        public string IdCoberturaCosseguro { get; set; }
        [StringLength(50)]
        public string CoberturaId { get; set; }
        [StringLength(50)]
        public string CosseguroId { get; set; }
        [StringLength(50)]
        public string EstadoId { get; set; }
        [StringLength(10)]
        public string CodCoberturaCosseguro { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }

        [ForeignKey("CoberturaId")]
        [InverseProperty("CoberturaCosseguro")]
        public virtual Cobertura Cobertura { get; set; }
        [ForeignKey("CosseguroId")]
        [InverseProperty("CoberturaCosseguro")]
        public virtual CoSeguro Cosseguro { get; set; }
        [ForeignKey("EstadoId")]
        [InverseProperty("CoberturaCosseguro")]
        public virtual Estado Estado { get; set; }
    }
}
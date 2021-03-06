﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class PremiosRiscosSimples
    {
        [StringLength(50)]
        public string IdPremiosRiscosSimples { get; set; }
        [StringLength(50)]
        public string ClassificacaoObjectoSeguro { get; set; }
        [Column("LocalidadeID")]
        [StringLength(50)]
        public string LocalidadeId { get; set; }
        public double? Risco1 { get; set; }
        public double? Risco2 { get; set; }
        public double? Risco3 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataActualizacao { get; set; }
        [StringLength(50)]
        public string CodPremiosRiscosSimples { get; set; }
        [Column("EstadoID")]
        [StringLength(50)]
        public string EstadoId { get; set; }

        [ForeignKey("EstadoId")]
        [InverseProperty("PremiosRiscosSimples")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("LocalidadeId")]
        [InverseProperty("PremiosRiscosSimples")]
        public virtual Endereco Localidade { get; set; }
    }
}
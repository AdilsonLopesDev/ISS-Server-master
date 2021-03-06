﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class PeriodoAnualImposto
    {
        [StringLength(50)]
        public string IdPeriodoAnualImposto { get; set; }
        [StringLength(50)]
        public string MesId { get; set; }
        [StringLength(50)]
        public string TipoImpostoId { get; set; }
        [StringLength(50)]
        public string CodPeriodoAnualImposto { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [StringLength(50)]
        public string EstadoId { get; set; }
        [StringLength(500)]
        public string Descricao { get; set; }
        [StringLength(50)]
        public string GrupoImpostoId { get; set; }
        [StringLength(50)]
        public string SessaoImpostoId { get; set; }
        [StringLength(150)]
        public string Obs { get; set; }

        [ForeignKey("EstadoId")]
        [InverseProperty("PeriodoAnualImposto")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("GrupoImpostoId")]
        [InverseProperty("PeriodoAnualImposto")]
        public virtual GrupoImposto GrupoImposto { get; set; }
        [ForeignKey("MesId")]
        [InverseProperty("PeriodoAnualImposto")]
        public virtual Meses Mes { get; set; }
        [ForeignKey("SessaoImpostoId")]
        [InverseProperty("PeriodoAnualImposto")]
        public virtual SessaoImposto SessaoImposto { get; set; }
        [ForeignKey("TipoImpostoId")]
        [InverseProperty("PeriodoAnualImposto")]
        public virtual TipoImposto TipoImposto { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class FidelizacaoComissionamento
    {
        [StringLength(50)]
        public string IdCriterioComissionamento { get; set; }
        [StringLength(50)]
        public string ComissionamentoId { get; set; }
        [StringLength(50)]
        public string FidelizacaoId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [StringLength(50)]
        public string CriterioComissionamentoId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [StringLength(50)]
        public string EstadoId { get; set; }
        [StringLength(50)]
        public string CodCriterioComissionamento { get; set; }

        [ForeignKey("ComissionamentoId")]
        [InverseProperty("FidelizacaoComissionamento")]
        public virtual Comissionamento Comissionamento { get; set; }
        [ForeignKey("CriterioComissionamentoId")]
        [InverseProperty("FidelizacaoComissionamento")]
        public virtual CriterioComissionamento CriterioComissionamento { get; set; }
        [ForeignKey("EstadoId")]
        [InverseProperty("FidelizacaoComissionamento")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("FidelizacaoId")]
        [InverseProperty("FidelizacaoComissionamento")]
        public virtual Fidelizacao Fidelizacao { get; set; }
    }
}
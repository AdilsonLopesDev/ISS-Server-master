﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class PeriodoCalculo
    {
        [StringLength(50)]
        public string IdPeriodoCalculo { get; set; }
        public int? Periodo { get; set; }
        [Column("PlanoProdutoID")]
        [StringLength(50)]
        public string PlanoProdutoId { get; set; }
        [Column("MesesID")]
        [StringLength(50)]
        public string MesesId { get; set; }
        [Column("DuracaoTipoContratoID")]
        [StringLength(50)]
        public string DuracaoTipoContratoId { get; set; }
        [Column("EstadoID")]
        [StringLength(50)]
        public string EstadoId { get; set; }
        [StringLength(50)]
        public string CodPeriodoCalculo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }

        [ForeignKey("DuracaoTipoContratoId")]
        [InverseProperty("PeriodoCalculo")]
        public virtual DuracaoTipoContrato DuracaoTipoContrato { get; set; }
        [ForeignKey("EstadoId")]
        [InverseProperty("PeriodoCalculo")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("MesesId")]
        [InverseProperty("PeriodoCalculo")]
        public virtual Meses Meses { get; set; }
        [ForeignKey("PlanoProdutoId")]
        [InverseProperty("PeriodoCalculo")]
        public virtual PlanoProduto PlanoProduto { get; set; }
    }
}
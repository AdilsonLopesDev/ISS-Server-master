﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class PeriodoPlanoPlano
    {
        [StringLength(50)]
        public string IdPeriodoPlanoPlano { get; set; }
        [StringLength(50)]
        public string PeriodoPlanoId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataActualizacao { get; set; }
        [StringLength(50)]
        public string EstadoId { get; set; }
        [StringLength(50)]
        public string PessoaId { get; set; }
        [StringLength(50)]
        public string PlanoProdutoId { get; set; }
        [StringLength(50)]
        public string CodPeriodoPlanoPlano { get; set; }

        [ForeignKey("EstadoId")]
        [InverseProperty("PeriodoPlanoPlano")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("PeriodoPlanoId")]
        [InverseProperty("PeriodoPlanoPlano")]
        public virtual PeriodoPlano PeriodoPlano { get; set; }
        [ForeignKey("PessoaId")]
        [InverseProperty("PeriodoPlanoPlano")]
        public virtual Pessoa Pessoa { get; set; }
        [ForeignKey("PlanoProdutoId")]
        [InverseProperty("PeriodoPlanoPlano")]
        public virtual PlanoProduto PlanoProduto { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class TipoPessoaPlano
    {
        [StringLength(50)]
        public string IdPlanoTipoPessoa { get; set; }
        [StringLength(50)]
        public string PlanoProdutoId { get; set; }
        [StringLength(50)]
        public string TipoPessoaId { get; set; }
        [StringLength(50)]
        public string PessoaId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [StringLength(50)]
        public string EstadoId { get; set; }

        [ForeignKey("EstadoId")]
        [InverseProperty("TipoPessoaPlano")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("PessoaId")]
        [InverseProperty("TipoPessoaPlano")]
        public virtual Pessoa Pessoa { get; set; }
        [ForeignKey("PlanoProdutoId")]
        [InverseProperty("TipoPessoaPlano")]
        public virtual PlanoProduto PlanoProduto { get; set; }
        [ForeignKey("TipoPessoaId")]
        [InverseProperty("TipoPessoaPlano")]
        public virtual TipoPessoa TipoPessoa { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class RendimentosPessoa
    {
        [StringLength(50)]
        public string IdRendimentosPessoa { get; set; }
        [StringLength(50)]
        public string PessoaId { get; set; }
        public double? SalarioBaseMensal { get; set; }
        [StringLength(50)]
        public string CodRendimentosPessoa { get; set; }
        public double? SubSidioAlimentacaoMensal { get; set; }
        public double? OutrosRendimentosMensais { get; set; }
        public double? TaxaSimplesBase { get; set; }
        [Column("CAEId")]
        [StringLength(50)]
        public string Caeid { get; set; }
        public int? NumFuncionarios { get; set; }
        public double? MassaSalarialLiquida { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [StringLength(50)]
        public string EstadoId { get; set; }
        [StringLength(50)]
        public string PlanoProdutoId { get; set; }
        [StringLength(50)]
        public string FormaLiquidacaoPremioId { get; set; }
        [StringLength(50)]
        public string CotacaoId { get; set; }
        public double? SubSidioNatal { get; set; }
        public double? SubSidioFeria { get; set; }
        [StringLength(50)]
        public string TipoContratacaoId { get; set; }
        [StringLength(50)]
        public string EntidadeEmpregadoraId { get; set; }

        [ForeignKey("Caeid")]
        [InverseProperty("RendimentosPessoa")]
        public virtual Cae Cae { get; set; }
        [ForeignKey("CotacaoId")]
        [InverseProperty("RendimentosPessoa")]
        public virtual Cotacao Cotacao { get; set; }
        [ForeignKey("EntidadeEmpregadoraId")]
        [InverseProperty("RendimentosPessoaEntidadeEmpregadora")]
        public virtual Pessoa EntidadeEmpregadora { get; set; }
        [ForeignKey("EstadoId")]
        [InverseProperty("RendimentosPessoa")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("FormaLiquidacaoPremioId")]
        [InverseProperty("RendimentosPessoa")]
        public virtual FormaLiquidacaoPremio FormaLiquidacaoPremio { get; set; }
        [ForeignKey("PessoaId")]
        [InverseProperty("RendimentosPessoaPessoa")]
        public virtual Pessoa Pessoa { get; set; }
        [ForeignKey("PlanoProdutoId")]
        [InverseProperty("RendimentosPessoa")]
        public virtual PlanoProduto PlanoProduto { get; set; }
        [ForeignKey("TipoContratacaoId")]
        [InverseProperty("RendimentosPessoa")]
        public virtual TipoContratacao TipoContratacao { get; set; }
    }
}
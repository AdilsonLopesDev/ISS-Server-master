﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class TarifasPremioAutoAcidentesTrabalho
    {
        [StringLength(50)]
        public string IdTarifa { get; set; }
        [StringLength(400)]
        public string Descricao { get; set; }
        [Column("TxDP")]
        public byte? TxDp { get; set; }
        [StringLength(5)]
        public string Ocupantes { get; set; }
        [Column("CapitalRC")]
        public double? CapitalRc { get; set; }
        public double? PremioFixo { get; set; }
        [Column("UCF_USD")]
        public double? UcfUsd { get; set; }
        public double? PremioSimples { get; set; }
        [Column("SubContaID")]
        [StringLength(50)]
        public string SubContaId { get; set; }
        [Column("ProdutoID")]
        [StringLength(50)]
        public string ProdutoId { get; set; }
        [StringLength(10)]
        public string CodTarifasPremioAutoAcidentesTrabalho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [Column("LinhaProdutoID")]
        [StringLength(50)]
        public string LinhaProdutoId { get; set; }
        [Column("EstadoID")]
        [StringLength(50)]
        public string EstadoId { get; set; }
        [StringLength(50)]
        public string NaturezaMovimentoId { get; set; }
        [Required]
        public bool? Contabiliza { get; set; }
        [StringLength(50)]
        public string CodInformacoesAdicionaisProduto { get; set; }

        [ForeignKey("EstadoId")]
        [InverseProperty("TarifasPremioAutoAcidentesTrabalho")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("LinhaProdutoId")]
        [InverseProperty("TarifasPremioAutoAcidentesTrabalho")]
        public virtual LinhaProduto LinhaProduto { get; set; }
        [ForeignKey("NaturezaMovimentoId")]
        [InverseProperty("TarifasPremioAutoAcidentesTrabalho")]
        public virtual NaturezaMovimento NaturezaMovimento { get; set; }
        [ForeignKey("ProdutoId")]
        [InverseProperty("TarifasPremioAutoAcidentesTrabalho")]
        public virtual Produto Produto { get; set; }
        [ForeignKey("SubContaId")]
        [InverseProperty("TarifasPremioAutoAcidentesTrabalho")]
        public virtual PlanoContas SubConta { get; set; }
    }
}
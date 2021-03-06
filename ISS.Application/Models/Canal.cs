﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class Canal
    {
        public Canal()
        {
            Apolice = new HashSet<Apolice>();
            Bonus = new HashSet<Bonus>();
            CanalComissionamento = new HashSet<CanalComissionamento>();
            CanalComissionamentoProdutor = new HashSet<CanalComissionamentoProdutor>();
            CanalContratos = new HashSet<CanalContratos>();
            CanalDesconto = new HashSet<CanalDesconto>();
            CanalMenu = new HashSet<CanalMenu>();
            CanalPlano = new HashSet<CanalPlano>();
            CoPagamento = new HashSet<CoPagamento>();
            ComissaoPlano = new HashSet<ComissaoPlano>();
            Comissionamento = new HashSet<Comissionamento>();
            CondicaoOperacao = new HashSet<CondicaoOperacao>();
            ContaFinanceira = new HashSet<ContaFinanceira>();
            ContratoCanais = new HashSet<ContratoCanais>();
            Cotacao = new HashSet<Cotacao>();
            CriterioComissionamento = new HashSet<CriterioComissionamento>();
            Despesa = new HashSet<Despesa>();
            LimiteCompetencia = new HashSet<LimiteCompetencia>();
            MargemVendaProduto = new HashSet<MargemVendaProduto>();
            Pessoa = new HashSet<Pessoa>();
            PrecarioProduto = new HashSet<PrecarioProduto>();
            ReservasTecnicas = new HashSet<ReservasTecnicas>();
            SegmentoOferta = new HashSet<SegmentoOferta>();
            Tarifa = new HashSet<Tarifa>();
            TipoSegmentoComissionamento = new HashSet<TipoSegmentoComissionamento>();
        }

        [StringLength(50)]
        public string IdCanal { get; set; }
        [StringLength(500)]
        public string Designacao { get; set; }
        [StringLength(10)]
        public string CodCanal { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [Column("EstadoID")]
        [StringLength(50)]
        public string EstadoId { get; set; }
        [Column("UltModificacaoPorID")]
        [StringLength(50)]
        public string UltModificacaoPorId { get; set; }
        [StringLength(50)]
        public string TipoFacturamentoId { get; set; }
        [StringLength(50)]
        public string NaturezaMovimentoId { get; set; }
        [StringLength(50)]
        public string SubContaId { get; set; }

        [ForeignKey("EstadoId")]
        [InverseProperty("Canal")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("NaturezaMovimentoId")]
        [InverseProperty("Canal")]
        public virtual NaturezaMovimento NaturezaMovimento { get; set; }
        [ForeignKey("SubContaId")]
        [InverseProperty("Canal")]
        public virtual PlanoContas SubConta { get; set; }
        [ForeignKey("TipoFacturamentoId")]
        [InverseProperty("Canal")]
        public virtual TipoFacturamento TipoFacturamento { get; set; }
        [InverseProperty("Canal")]
        public virtual ICollection<Apolice> Apolice { get; set; }
        [InverseProperty("Canal")]
        public virtual ICollection<Bonus> Bonus { get; set; }
        [InverseProperty("Canal")]
        public virtual ICollection<CanalComissionamento> CanalComissionamento { get; set; }
        [InverseProperty("Canal")]
        public virtual ICollection<CanalComissionamentoProdutor> CanalComissionamentoProdutor { get; set; }
        [InverseProperty("CanalContrato")]
        public virtual ICollection<CanalContratos> CanalContratos { get; set; }
        [InverseProperty("Canal")]
        public virtual ICollection<CanalDesconto> CanalDesconto { get; set; }
        [InverseProperty("Canal")]
        public virtual ICollection<CanalMenu> CanalMenu { get; set; }
        [InverseProperty("Canal")]
        public virtual ICollection<CanalPlano> CanalPlano { get; set; }
        [InverseProperty("Canal")]
        public virtual ICollection<CoPagamento> CoPagamento { get; set; }
        [InverseProperty("Canal")]
        public virtual ICollection<ComissaoPlano> ComissaoPlano { get; set; }
        [InverseProperty("Canal")]
        public virtual ICollection<Comissionamento> Comissionamento { get; set; }
        [InverseProperty("Canal")]
        public virtual ICollection<CondicaoOperacao> CondicaoOperacao { get; set; }
        [InverseProperty("Canal")]
        public virtual ICollection<ContaFinanceira> ContaFinanceira { get; set; }
        [InverseProperty("Canal")]
        public virtual ICollection<ContratoCanais> ContratoCanais { get; set; }
        [InverseProperty("Canal")]
        public virtual ICollection<Cotacao> Cotacao { get; set; }
        [InverseProperty("Canal")]
        public virtual ICollection<CriterioComissionamento> CriterioComissionamento { get; set; }
        [InverseProperty("Canal")]
        public virtual ICollection<Despesa> Despesa { get; set; }
        [InverseProperty("Canal")]
        public virtual ICollection<LimiteCompetencia> LimiteCompetencia { get; set; }
        [InverseProperty("Canal")]
        public virtual ICollection<MargemVendaProduto> MargemVendaProduto { get; set; }
        [InverseProperty("Canal")]
        public virtual ICollection<Pessoa> Pessoa { get; set; }
        [InverseProperty("Canal")]
        public virtual ICollection<PrecarioProduto> PrecarioProduto { get; set; }
        [InverseProperty("Canal")]
        public virtual ICollection<ReservasTecnicas> ReservasTecnicas { get; set; }
        [InverseProperty("Canal")]
        public virtual ICollection<SegmentoOferta> SegmentoOferta { get; set; }
        [InverseProperty("Canal")]
        public virtual ICollection<Tarifa> Tarifa { get; set; }
        [InverseProperty("Canal")]
        public virtual ICollection<TipoSegmentoComissionamento> TipoSegmentoComissionamento { get; set; }
    }
}
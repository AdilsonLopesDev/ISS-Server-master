﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class TipoOperacao
    {
        public TipoOperacao()
        {
            Agravamento = new HashSet<Agravamento>();
            Bonus = new HashSet<Bonus>();
            Contrato = new HashSet<Contrato>();
            Desconto = new HashSet<Desconto>();
            Despesa = new HashSet<Despesa>();
            Encargos = new HashSet<Encargos>();
            Fraccionamento = new HashSet<Fraccionamento>();
            HistoricoOferta = new HashSet<HistoricoOferta>();
            Imposto = new HashSet<Imposto>();
            MargemVendaProduto = new HashSet<MargemVendaProduto>();
            Operacao = new HashSet<Operacao>();
            OperacoesPagamento = new HashSet<OperacoesPagamento>();
            PrecarioProduto = new HashSet<PrecarioProduto>();
            ReservasTecnicas = new HashSet<ReservasTecnicas>();
            TipoAgravamento = new HashSet<TipoAgravamento>();
            TipoOperacaoProcesso = new HashSet<TipoOperacaoProcesso>();
        }

        [StringLength(50)]
        public string IdTipoOperacao { get; set; }
        [StringLength(100)]
        public string Designacao { get; set; }
        [StringLength(50)]
        public string CodTipoOperacao { get; set; }
        public int? TipoMovimento { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [StringLength(1)]
        public string ValorRegraOperacao { get; set; }
        [Column("EstadoID")]
        [StringLength(50)]
        public string EstadoId { get; set; }
        [Column("UltModificacaoPorID")]
        [StringLength(50)]
        public string UltModificacaoPorId { get; set; }
        [StringLength(500)]
        public string CaminhoIcome { get; set; }
        [StringLength(50)]
        public string PapelId { get; set; }
        [StringLength(50)]
        public string SubContaCreditoId { get; set; }
        [StringLength(50)]
        public string SubContaDebitoId { get; set; }
        [StringLength(50)]
        public string TipoDocumentoId { get; set; }

        [ForeignKey("EstadoId")]
        [InverseProperty("TipoOperacao")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("PapelId")]
        [InverseProperty("TipoOperacao")]
        public virtual Papel Papel { get; set; }
        [ForeignKey("SubContaCreditoId")]
        [InverseProperty("TipoOperacaoSubContaCredito")]
        public virtual PlanoContas SubContaCredito { get; set; }
        [ForeignKey("SubContaDebitoId")]
        [InverseProperty("TipoOperacaoSubContaDebito")]
        public virtual PlanoContas SubContaDebito { get; set; }
        [ForeignKey("TipoDocumentoId")]
        [InverseProperty("TipoOperacao")]
        public virtual TipoDocumentos TipoDocumento { get; set; }
        [InverseProperty("TipoOperacao")]
        public virtual ICollection<Agravamento> Agravamento { get; set; }
        [InverseProperty("TipoOperacao")]
        public virtual ICollection<Bonus> Bonus { get; set; }
        [InverseProperty("TipoOperacao")]
        public virtual ICollection<Contrato> Contrato { get; set; }
        [InverseProperty("TipoOperacao")]
        public virtual ICollection<Desconto> Desconto { get; set; }
        [InverseProperty("TipoOperacao")]
        public virtual ICollection<Despesa> Despesa { get; set; }
        [InverseProperty("TipoOperacao")]
        public virtual ICollection<Encargos> Encargos { get; set; }
        [InverseProperty("TipoOperacao")]
        public virtual ICollection<Fraccionamento> Fraccionamento { get; set; }
        [InverseProperty("TipoOperacao")]
        public virtual ICollection<HistoricoOferta> HistoricoOferta { get; set; }
        [InverseProperty("TipoOperacao")]
        public virtual ICollection<Imposto> Imposto { get; set; }
        [InverseProperty("TipoOperacao")]
        public virtual ICollection<MargemVendaProduto> MargemVendaProduto { get; set; }
        [InverseProperty("TipoOperacao")]
        public virtual ICollection<Operacao> Operacao { get; set; }
        [InverseProperty("TipoOperacao")]
        public virtual ICollection<OperacoesPagamento> OperacoesPagamento { get; set; }
        [InverseProperty("TipoOperacao")]
        public virtual ICollection<PrecarioProduto> PrecarioProduto { get; set; }
        [InverseProperty("TipoOperacao")]
        public virtual ICollection<ReservasTecnicas> ReservasTecnicas { get; set; }
        [InverseProperty("TipoOperacao")]
        public virtual ICollection<TipoAgravamento> TipoAgravamento { get; set; }
        [InverseProperty("TipoOperacao")]
        public virtual ICollection<TipoOperacaoProcesso> TipoOperacaoProcesso { get; set; }
    }
}
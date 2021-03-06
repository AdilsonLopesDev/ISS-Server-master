﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class MovimentoHistorico
    {
        [Key]
        [StringLength(50)]
        public string IdMovimento { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataHoraMovimento { get; set; }
        [StringLength(800)]
        public string DescricaoMovimento { get; set; }
        [Column("MoedaID")]
        [StringLength(50)]
        public string MoedaId { get; set; }
        [Column("SubClasseID")]
        [StringLength(50)]
        public string SubClasseId { get; set; }
        [StringLength(50)]
        public string NaturezaMovimentoId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataValor { get; set; }
        public double Valor { get; set; }
        [Column("EstadoID")]
        [StringLength(50)]
        public string EstadoId { get; set; }
        [Column("ContaFinanceiraID")]
        [StringLength(50)]
        public string ContaFinanceiraId { get; set; }
        [Column("FuncionarioID")]
        [StringLength(50)]
        public string FuncionarioId { get; set; }
        [Column("TipoRecebimentoID")]
        [StringLength(50)]
        public string TipoRecebimentoId { get; set; }
        [StringLength(50)]
        public string CodTransacao { get; set; }
        [StringLength(200)]
        public string NumeroDocumentoInterno { get; set; }
        [StringLength(50)]
        public string CaixaId { get; set; }
        [StringLength(50)]
        public string EnderecoId { get; set; }
        [StringLength(50)]
        public string TipoOperacaoId { get; set; }
        public bool? IsPago { get; set; }
        public bool? Contabliza { get; set; }
        [StringLength(50)]
        public string FavorecidoId { get; set; }
        [StringLength(50)]
        public string OutraMoedaId { get; set; }
        [StringLength(50)]
        public string CentroResponsabilidadeId { get; set; }
        [StringLength(50)]
        public string CentroCustoId { get; set; }
        [StringLength(50)]
        public string Referencia { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataVencimento { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataProgramada { get; set; }
        public int? DocumentoParcelado { get; set; }
        [StringLength(50)]
        public string Identificador { get; set; }
        [StringLength(200)]
        public string NumeroDocumentoExterno { get; set; }
        [StringLength(50)]
        public string PeriodoContabilId { get; set; }
        [StringLength(50)]
        public string EmpresaId { get; set; }
        [StringLength(50)]
        public string TipoPagamentoId { get; set; }
        [StringLength(50)]
        public string CodOperacao { get; set; }
        public double? ValorOutraMoeda { get; set; }
    }
}
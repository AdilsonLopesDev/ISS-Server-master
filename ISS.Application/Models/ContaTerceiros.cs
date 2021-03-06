﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class ContaTerceiros
    {
        [StringLength(50)]
        public string IdContaTerceiros { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataHoraMovimento { get; set; }
        [StringLength(800)]
        public string DescricaoMovimento { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataValor { get; set; }
        public double Valor { get; set; }
        [StringLength(50)]
        public string CodEstado { get; set; }
        [StringLength(50)]
        public string CodContaFinanceira { get; set; }
        [StringLength(50)]
        public string CodTransacao { get; set; }
        [StringLength(200)]
        public string NumeroDocumentoInterno { get; set; }
        [StringLength(50)]
        public string CodCaixa { get; set; }
        [StringLength(50)]
        public string CodEndereco { get; set; }
        [StringLength(50)]
        public string CodTipoOperacao { get; set; }
        public bool? IsPago { get; set; }
        public bool? Contabliza { get; set; }
        [StringLength(50)]
        public string CodFavorecido { get; set; }
        [StringLength(50)]
        public string CodOutraMoeda { get; set; }
        [StringLength(50)]
        public string CodCentroResponsabilidade { get; set; }
        [StringLength(50)]
        public string CodCentroCusto { get; set; }
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
        public string CodEmpresa { get; set; }
        [StringLength(50)]
        public string CodTipoPagamento { get; set; }
        public double? ValorOutraMoeda { get; set; }
        [StringLength(50)]
        public string CodFraccionamento { get; set; }
        [StringLength(50)]
        public string CodOperacoesPagamento { get; set; }
        [StringLength(50)]
        public string CodMoeda { get; set; }
        [StringLength(50)]
        public string CodNaturezaMovimento { get; set; }
        [StringLength(50)]
        public string CodConta { get; set; }
        [StringLength(50)]
        public string CodOperacao { get; set; }
        [StringLength(50)]
        public string ContaFinanceiraId { get; set; }
        [StringLength(50)]
        public string CodFuncionario { get; set; }
        [StringLength(50)]
        public string CodExercicio { get; set; }
        [StringLength(10)]
        public string CodTipoDocumentos { get; set; }
    }
}
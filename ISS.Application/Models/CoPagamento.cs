﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class CoPagamento
    {
        [StringLength(50)]
        public string IdCoPagamento { get; set; }
        [StringLength(100)]
        public string ReferenciaPagamento { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataHora { get; set; }
        public double? TotalPago { get; set; }
        [StringLength(100)]
        public string Obs { get; set; }
        [Column("FornecedorID")]
        [StringLength(50)]
        public string FornecedorId { get; set; }
        [Column("ApoliceID")]
        [StringLength(50)]
        public string ApoliceId { get; set; }
        [Column("FormaPagamentoID")]
        [StringLength(50)]
        public string FormaPagamentoId { get; set; }
        [Column("CanalID")]
        [StringLength(50)]
        public string CanalId { get; set; }
        [Column("MoedaID")]
        [StringLength(50)]
        public string MoedaId { get; set; }
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
        public string CodCoPagamento { get; set; }

        [ForeignKey("ApoliceId")]
        [InverseProperty("CoPagamento")]
        public virtual Apolice Apolice { get; set; }
        [ForeignKey("CanalId")]
        [InverseProperty("CoPagamento")]
        public virtual Canal Canal { get; set; }
        [ForeignKey("EstadoId")]
        [InverseProperty("CoPagamento")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("FormaPagamentoId")]
        [InverseProperty("CoPagamento")]
        public virtual FormaPagamento FormaPagamento { get; set; }
        [ForeignKey("FornecedorId")]
        [InverseProperty("CoPagamento")]
        public virtual Pessoa Fornecedor { get; set; }
        [ForeignKey("MoedaId")]
        [InverseProperty("CoPagamento")]
        public virtual Moeda Moeda { get; set; }
    }
}
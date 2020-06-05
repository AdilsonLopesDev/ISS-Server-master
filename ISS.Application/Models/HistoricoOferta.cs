﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class HistoricoOferta
    {
        public HistoricoOferta()
        {
            OfertaLinha = new HashSet<OfertaLinha>();
            OfertaPlano = new HashSet<OfertaPlano>();
        }

        [StringLength(50)]
        public string IdHistoricoOferta { get; set; }
        [StringLength(50)]
        public string IdOferta { get; set; }
        public double? TaxaOferta { get; set; }
        [Column("TipoOfertaID")]
        [StringLength(50)]
        public string TipoOfertaId { get; set; }
        [Column("PlanoProdutoID")]
        [StringLength(50)]
        public string PlanoProdutoId { get; set; }
        [StringLength(10)]
        public string CodOferta { get; set; }
        public double? ValorMinPremioSimples { get; set; }
        public double? ValorMaxPremioSimples { get; set; }
        [Column("PapelID")]
        [StringLength(50)]
        public string PapelId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        public double? TaxaMaxOferta { get; set; }
        public double? ValorMinOferta { get; set; }
        public double? ValorMaxOferta { get; set; }
        public bool? IsTaxa { get; set; }
        [Column("EstadoID")]
        [StringLength(50)]
        public string EstadoId { get; set; }
        [Column("UltModificacaoPorID")]
        [StringLength(50)]
        public string UltModificacaoPorId { get; set; }
        [Column("PrecarioProdutoID")]
        [StringLength(50)]
        public string PrecarioProdutoId { get; set; }
        [StringLength(50)]
        public string MoedaId { get; set; }
        [StringLength(50)]
        public string TipoOperacaoId { get; set; }

        [ForeignKey("MoedaId")]
        [InverseProperty("HistoricoOferta")]
        public virtual Moeda Moeda { get; set; }
        [ForeignKey("TipoOperacaoId")]
        [InverseProperty("HistoricoOferta")]
        public virtual TipoOperacao TipoOperacao { get; set; }
        [InverseProperty("HistoricoOferta")]
        public virtual ICollection<OfertaLinha> OfertaLinha { get; set; }
        [InverseProperty("HistoricoOferta")]
        public virtual ICollection<OfertaPlano> OfertaPlano { get; set; }
    }
}
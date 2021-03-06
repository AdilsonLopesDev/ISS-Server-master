﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class Despesa
    {
        public Despesa()
        {
            AgravamentoDespesa = new HashSet<AgravamentoDespesa>();
            DespesaLinha = new HashSet<DespesaLinha>();
            DespesaPlano = new HashSet<DespesaPlano>();
            DespesaSeleccionada = new HashSet<DespesaSeleccionada>();
            DespesasCobertura = new HashSet<DespesasCobertura>();
            DespesasTipoConta = new HashSet<DespesasTipoConta>();
        }

        [StringLength(50)]
        public string IdDespesa { get; set; }
        public double? ValorMin { get; set; }
        [Column("TipoDespesaID")]
        [StringLength(50)]
        public string TipoDespesaId { get; set; }
        [StringLength(10)]
        public string CodDespesa { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        public double? ValorMax { get; set; }
        [Column("EstadoID")]
        [StringLength(50)]
        public string EstadoId { get; set; }
        [Column("UltModificacaoPorID")]
        [StringLength(50)]
        public string UltModificacaoPorId { get; set; }
        public bool IsTaxa { get; set; }
        [Column("MoedaID")]
        [StringLength(50)]
        public string MoedaId { get; set; }
        [StringLength(50)]
        public string CanalId { get; set; }
        [StringLength(50)]
        public string CentroCustoId { get; set; }
        [StringLength(50)]
        public string TipoRecebimentoId { get; set; }
        [StringLength(50)]
        public string LocalAplicacaoId { get; set; }
        [StringLength(50)]
        public string ProdutorId { get; set; }
        [StringLength(50)]
        public string CoberturaId { get; set; }
        [StringLength(50)]
        public string TipoOperacaoId { get; set; }
        [StringLength(50)]
        public string Designacao { get; set; }
        public double? Taxa { get; set; }
        [StringLength(50)]
        public string NivelRiscoId { get; set; }

        [ForeignKey("CanalId")]
        [InverseProperty("Despesa")]
        public virtual Canal Canal { get; set; }
        [ForeignKey("CentroCustoId")]
        [InverseProperty("Despesa")]
        public virtual CentroCusto CentroCusto { get; set; }
        [ForeignKey("CoberturaId")]
        [InverseProperty("Despesa")]
        public virtual Cobertura Cobertura { get; set; }
        [ForeignKey("EstadoId")]
        [InverseProperty("Despesa")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("LocalAplicacaoId")]
        [InverseProperty("Despesa")]
        public virtual LocalAplicacaoPlano LocalAplicacao { get; set; }
        [ForeignKey("MoedaId")]
        [InverseProperty("Despesa")]
        public virtual Moeda Moeda { get; set; }
        [ForeignKey("NivelRiscoId")]
        [InverseProperty("Despesa")]
        public virtual NivelRisco NivelRisco { get; set; }
        [ForeignKey("ProdutorId")]
        [InverseProperty("Despesa")]
        public virtual Pessoa Produtor { get; set; }
        [ForeignKey("TipoDespesaId")]
        [InverseProperty("Despesa")]
        public virtual TipoDespesa TipoDespesa { get; set; }
        [ForeignKey("TipoOperacaoId")]
        [InverseProperty("Despesa")]
        public virtual TipoOperacao TipoOperacao { get; set; }
        [ForeignKey("TipoRecebimentoId")]
        [InverseProperty("Despesa")]
        public virtual TipoRecebimento TipoRecebimento { get; set; }
        [InverseProperty("Despesa")]
        public virtual ICollection<AgravamentoDespesa> AgravamentoDespesa { get; set; }
        [InverseProperty("Despesa")]
        public virtual ICollection<DespesaLinha> DespesaLinha { get; set; }
        [InverseProperty("Despesa")]
        public virtual ICollection<DespesaPlano> DespesaPlano { get; set; }
        [InverseProperty("Despesa")]
        public virtual ICollection<DespesaSeleccionada> DespesaSeleccionada { get; set; }
        [InverseProperty("Despesas")]
        public virtual ICollection<DespesasCobertura> DespesasCobertura { get; set; }
        [InverseProperty("Despesa")]
        public virtual ICollection<DespesasTipoConta> DespesasTipoConta { get; set; }
    }
}
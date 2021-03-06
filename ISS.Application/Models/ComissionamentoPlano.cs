﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class ComissionamentoPlano
    {
        public ComissionamentoPlano()
        {
            LimiteComissionamentoProdutor = new HashSet<LimiteComissionamentoProdutor>();
        }

        [StringLength(50)]
        public string IdComissionamentoPlano { get; set; }
        [StringLength(50)]
        public string PlanoProdutoId { get; set; }
        public double? Desconto { get; set; }
        [StringLength(50)]
        public string CanalPlanoId { get; set; }
        [StringLength(50)]
        public string TipoSegmentoPlano { get; set; }
        [StringLength(50)]
        public string SectorActividadePlanoId { get; set; }
        public double? CapitalMin { get; set; }
        public double? CapitalMax { get; set; }
        [StringLength(50)]
        public string FormaPagamentoPlanoId { get; set; }
        [StringLength(50)]
        public string PapelPlanoId { get; set; }
        [StringLength(50)]
        public string PessoaId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataInicio { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataFim { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [StringLength(50)]
        public string EstadoId { get; set; }
        public double? TaxaComissionamento { get; set; }
        [StringLength(50)]
        public string ComissionamentoId { get; set; }
        public double? TaxaAtribuir { get; set; }
        public double? DescontoMin { get; set; }
        public double? DescontoMax { get; set; }

        [ForeignKey("CanalPlanoId")]
        [InverseProperty("ComissionamentoPlano")]
        public virtual CanalPlano CanalPlano { get; set; }
        [ForeignKey("ComissionamentoId")]
        [InverseProperty("ComissionamentoPlano")]
        public virtual Comissionamento Comissionamento { get; set; }
        [ForeignKey("EstadoId")]
        [InverseProperty("ComissionamentoPlano")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("FormaPagamentoPlanoId")]
        [InverseProperty("ComissionamentoPlano")]
        public virtual FormaPagamentoPlano FormaPagamentoPlano { get; set; }
        [ForeignKey("PapelPlanoId")]
        [InverseProperty("ComissionamentoPlano")]
        public virtual PapelPlano PapelPlano { get; set; }
        [ForeignKey("PessoaId")]
        [InverseProperty("ComissionamentoPlano")]
        public virtual Pessoa Pessoa { get; set; }
        [ForeignKey("PlanoProdutoId")]
        [InverseProperty("ComissionamentoPlano")]
        public virtual PlanoProduto PlanoProduto { get; set; }
        [ForeignKey("SectorActividadePlanoId")]
        [InverseProperty("ComissionamentoPlano")]
        public virtual SectorActividadePlano SectorActividadePlano { get; set; }
        [ForeignKey("TipoSegmentoPlano")]
        [InverseProperty("ComissionamentoPlano")]
        public virtual TipoSegmentoPlano TipoSegmentoPlanoNavigation { get; set; }
        [InverseProperty("ComissionamentoProdutor")]
        public virtual ICollection<LimiteComissionamentoProdutor> LimiteComissionamentoProdutor { get; set; }
    }
}
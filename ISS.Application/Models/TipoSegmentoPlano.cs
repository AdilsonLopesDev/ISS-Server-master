﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class TipoSegmentoPlano
    {
        public TipoSegmentoPlano()
        {
            ComissionamentoPlano = new HashSet<ComissionamentoPlano>();
            CriterioComissionamento = new HashSet<CriterioComissionamento>();
            CriterioPlano = new HashSet<CriterioPlano>();
            LimiteComissionamentoPlano = new HashSet<LimiteComissionamentoPlano>();
            LimiteComissionamentoProdutor = new HashSet<LimiteComissionamentoProdutor>();
        }

        [StringLength(50)]
        public string IdTipoSegmentoPlano { get; set; }
        [StringLength(50)]
        public string PlanoProdutoId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [StringLength(10)]
        public string CodTipoSegmentoPlano { get; set; }
        [StringLength(50)]
        public string TipoSegmentoId { get; set; }

        [ForeignKey("PlanoProdutoId")]
        [InverseProperty("TipoSegmentoPlano")]
        public virtual PlanoProduto PlanoProduto { get; set; }
        [ForeignKey("TipoSegmentoId")]
        [InverseProperty("TipoSegmentoPlano")]
        public virtual TipoSegmento TipoSegmento { get; set; }
        [InverseProperty("TipoSegmentoPlanoNavigation")]
        public virtual ICollection<ComissionamentoPlano> ComissionamentoPlano { get; set; }
        [InverseProperty("SegmentoPlano")]
        public virtual ICollection<CriterioComissionamento> CriterioComissionamento { get; set; }
        [InverseProperty("TipoSegmentoPlano")]
        public virtual ICollection<CriterioPlano> CriterioPlano { get; set; }
        [InverseProperty("TipoSegmentoPlano")]
        public virtual ICollection<LimiteComissionamentoPlano> LimiteComissionamentoPlano { get; set; }
        [InverseProperty("TipoSegmentoProdutor")]
        public virtual ICollection<LimiteComissionamentoProdutor> LimiteComissionamentoProdutor { get; set; }
    }
}
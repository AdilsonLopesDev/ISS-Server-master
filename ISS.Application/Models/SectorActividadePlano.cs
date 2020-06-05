﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class SectorActividadePlano
    {
        public SectorActividadePlano()
        {
            ComissionamentoPlano = new HashSet<ComissionamentoPlano>();
            CriterioPlano = new HashSet<CriterioPlano>();
            LimiteComissionamentoPlanoSectorActividadePlano1 = new HashSet<LimiteComissionamentoPlano>();
            LimiteComissionamentoPlanoSectorActividadePlanoNavigation = new HashSet<LimiteComissionamentoPlano>();
            LimiteComissionamentoProdutor = new HashSet<LimiteComissionamentoProdutor>();
        }

        [StringLength(50)]
        public string IdSectorActividadePlano { get; set; }
        [StringLength(50)]
        public string PlanoProdutoId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [StringLength(50)]
        public string SectorActividadeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [StringLength(50)]
        public string PessoaId { get; set; }
        [StringLength(50)]
        public string EstadoId { get; set; }
        [StringLength(50)]
        public string CodSectorActividadePlano { get; set; }

        [ForeignKey("EstadoId")]
        [InverseProperty("SectorActividadePlano")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("PessoaId")]
        [InverseProperty("SectorActividadePlano")]
        public virtual Pessoa Pessoa { get; set; }
        [ForeignKey("PlanoProdutoId")]
        [InverseProperty("SectorActividadePlano")]
        public virtual PlanoProduto PlanoProduto { get; set; }
        [ForeignKey("SectorActividadeId")]
        [InverseProperty("SectorActividadePlano")]
        public virtual SectorActividade SectorActividade { get; set; }
        [InverseProperty("SectorActividadePlano")]
        public virtual ICollection<ComissionamentoPlano> ComissionamentoPlano { get; set; }
        [InverseProperty("SectorActividadePlanoNavigation")]
        public virtual ICollection<CriterioPlano> CriterioPlano { get; set; }
        [InverseProperty("SectorActividadePlano1")]
        public virtual ICollection<LimiteComissionamentoPlano> LimiteComissionamentoPlanoSectorActividadePlano1 { get; set; }
        [InverseProperty("SectorActividadePlanoNavigation")]
        public virtual ICollection<LimiteComissionamentoPlano> LimiteComissionamentoPlanoSectorActividadePlanoNavigation { get; set; }
        [InverseProperty("SectorActividadeProdutor")]
        public virtual ICollection<LimiteComissionamentoProdutor> LimiteComissionamentoProdutor { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    [Table("CategoriaMetricaKPI")]
    public partial class CategoriaMetricaKpi
    {
        public CategoriaMetricaKpi()
        {
            MetricaKpi = new HashSet<MetricaKpi>();
        }

        [Column("IdCategoriaMetricaKPI")]
        [StringLength(50)]
        public string IdCategoriaMetricaKpi { get; set; }
        [Column("PCFID")]
        [StringLength(20)]
        public string Pcfid { get; set; }
        [Column("HierarquiaID")]
        [StringLength(20)]
        public string HierarquiaId { get; set; }
        [StringLength(4000)]
        public string Nome { get; set; }
        [StringLength(3000)]
        public string IndiceDiferenca { get; set; }
        [StringLength(300)]
        public string DetalheMudanca { get; set; }
        [StringLength(50)]
        public string MetricaDisponivel { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [StringLength(50)]
        public string EstadoId { get; set; }

        [ForeignKey("EstadoId")]
        [InverseProperty("CategoriaMetricaKpi")]
        public virtual Estado Estado { get; set; }
        [InverseProperty("CategoriaMetricaKp")]
        public virtual ICollection<MetricaKpi> MetricaKpi { get; set; }
    }
}
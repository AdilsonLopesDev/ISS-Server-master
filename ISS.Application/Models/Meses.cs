﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class Meses
    {
        public Meses()
        {
            PeriodoAnualImposto = new HashSet<PeriodoAnualImposto>();
            PeriodoCalculo = new HashSet<PeriodoCalculo>();
            TarifasAutomovel = new HashSet<TarifasAutomovel>();
        }

        [StringLength(50)]
        public string IdMes { get; set; }
        [StringLength(20)]
        public string Mes { get; set; }
        [StringLength(10)]
        public string CodMeses { get; set; }
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

        [ForeignKey("EstadoId")]
        [InverseProperty("Meses")]
        public virtual Estado Estado { get; set; }
        [InverseProperty("Mes")]
        public virtual ICollection<PeriodoAnualImposto> PeriodoAnualImposto { get; set; }
        [InverseProperty("Meses")]
        public virtual ICollection<PeriodoCalculo> PeriodoCalculo { get; set; }
        [InverseProperty("Meses")]
        public virtual ICollection<TarifasAutomovel> TarifasAutomovel { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class Regiao
    {
        public Regiao()
        {
            Clausula = new HashSet<Clausula>();
            LocaisCobertura = new HashSet<LocaisCobertura>();
            LocaisDesconto = new HashSet<LocaisDesconto>();
            LocaisEncargo = new HashSet<LocaisEncargo>();
            LocaisFranquia = new HashSet<LocaisFranquia>();
            LocaisImposto = new HashSet<LocaisImposto>();
            LocaisLimiteCompetencia = new HashSet<LocaisLimiteCompetencia>();
            LocaisObjectivosComerciais = new HashSet<LocaisObjectivosComerciais>();
            LocaisOferta = new HashSet<LocaisOferta>();
            Pais = new HashSet<Pais>();
            Provincia = new HashSet<Provincia>();
        }

        [StringLength(50)]
        public string IdRegiao { get; set; }
        [StringLength(100)]
        public string Nome { get; set; }
        [StringLength(10)]
        public string CodRegiao { get; set; }
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
        [InverseProperty("Regiao")]
        public virtual Estado Estado { get; set; }
        [InverseProperty("Regiao")]
        public virtual ICollection<Clausula> Clausula { get; set; }
        [InverseProperty("Regiao")]
        public virtual ICollection<LocaisCobertura> LocaisCobertura { get; set; }
        [InverseProperty("Regiao")]
        public virtual ICollection<LocaisDesconto> LocaisDesconto { get; set; }
        [InverseProperty("Regiao")]
        public virtual ICollection<LocaisEncargo> LocaisEncargo { get; set; }
        [InverseProperty("Regiao")]
        public virtual ICollection<LocaisFranquia> LocaisFranquia { get; set; }
        [InverseProperty("Regiao")]
        public virtual ICollection<LocaisImposto> LocaisImposto { get; set; }
        [InverseProperty("Regiao")]
        public virtual ICollection<LocaisLimiteCompetencia> LocaisLimiteCompetencia { get; set; }
        [InverseProperty("Regiao")]
        public virtual ICollection<LocaisObjectivosComerciais> LocaisObjectivosComerciais { get; set; }
        [InverseProperty("Regiao")]
        public virtual ICollection<LocaisOferta> LocaisOferta { get; set; }
        [InverseProperty("Regiao")]
        public virtual ICollection<Pais> Pais { get; set; }
        [InverseProperty("Regiao")]
        public virtual ICollection<Provincia> Provincia { get; set; }
    }
}
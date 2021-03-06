﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class ModalidadesResponsabilidadeCivil
    {
        public ModalidadesResponsabilidadeCivil()
        {
            AscensoresMontaCarga = new HashSet<AscensoresMontaCarga>();
            LocalidadeAntena = new HashSet<LocalidadeAntena>();
            ModalidadesRcselecionadas = new HashSet<ModalidadesRcselecionadas>();
            TipoEstabelecimentoComercio = new HashSet<TipoEstabelecimentoComercio>();
            TipoSalaEspetaculo = new HashSet<TipoSalaEspetaculo>();
            ValoresCapitalSeguroFamiliar = new HashSet<ValoresCapitalSeguroFamiliar>();
        }

        [StringLength(50)]
        public string IdModalidadeResponsabilidadeCivil { get; set; }
        [StringLength(100)]
        public string Designacao { get; set; }
        [StringLength(10)]
        public string CodModalidadesResponsabilidadeCivil { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [Column("EstadoID")]
        [StringLength(50)]
        public string EstadoId { get; set; }

        [ForeignKey("EstadoId")]
        [InverseProperty("ModalidadesResponsabilidadeCivil")]
        public virtual Estado Estado { get; set; }
        [InverseProperty("ModalidadeResponsabilidadeCivil")]
        public virtual ICollection<AscensoresMontaCarga> AscensoresMontaCarga { get; set; }
        [InverseProperty("ModalidadeResponsabilidadeCivil")]
        public virtual ICollection<LocalidadeAntena> LocalidadeAntena { get; set; }
        [InverseProperty("ModalidadeResponsabilidadeCivil")]
        public virtual ICollection<ModalidadesRcselecionadas> ModalidadesRcselecionadas { get; set; }
        [InverseProperty("ModalidadeResponsabilidadeCivil")]
        public virtual ICollection<TipoEstabelecimentoComercio> TipoEstabelecimentoComercio { get; set; }
        [InverseProperty("ModalidadeResponsabilidadeCivil")]
        public virtual ICollection<TipoSalaEspetaculo> TipoSalaEspetaculo { get; set; }
        [InverseProperty("ModalidadeResponsabilidadeCivil")]
        public virtual ICollection<ValoresCapitalSeguroFamiliar> ValoresCapitalSeguroFamiliar { get; set; }
    }
}
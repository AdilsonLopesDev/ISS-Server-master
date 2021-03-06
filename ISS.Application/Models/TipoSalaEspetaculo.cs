﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class TipoSalaEspetaculo
    {
        public TipoSalaEspetaculo()
        {
            ModalidadesRcselecionadas = new HashSet<ModalidadesRcselecionadas>();
        }

        [StringLength(50)]
        public string IdTipoSalaEspetaculo { get; set; }
        [StringLength(100)]
        public string Designacao { get; set; }
        [Column("ModalidadeResponsabilidadeCivilID")]
        [StringLength(50)]
        public string ModalidadeResponsabilidadeCivilId { get; set; }
        [StringLength(10)]
        public string CodTipoSalaEspetaculo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [Column("EstadoID")]
        [StringLength(50)]
        public string EstadoId { get; set; }
        [StringLength(500)]
        public string CaminhoIcone { get; set; }

        [ForeignKey("EstadoId")]
        [InverseProperty("TipoSalaEspetaculo")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("ModalidadeResponsabilidadeCivilId")]
        [InverseProperty("TipoSalaEspetaculo")]
        public virtual ModalidadesResponsabilidadeCivil ModalidadeResponsabilidadeCivil { get; set; }
        [InverseProperty("TipoSalaEspetaculo")]
        public virtual ICollection<ModalidadesRcselecionadas> ModalidadesRcselecionadas { get; set; }
    }
}
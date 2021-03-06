﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class MembrosGrupo
    {
        [StringLength(50)]
        public string IdMembro { get; set; }
        [Column("PessoaID")]
        [StringLength(50)]
        public string PessoaId { get; set; }
        [Column("GrupoID")]
        [StringLength(50)]
        public string GrupoId { get; set; }
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
        public bool IsAdministrador { get; set; }
        [StringLength(50)]
        public string CodMembrosGrupo { get; set; }

        [ForeignKey("EstadoId")]
        [InverseProperty("MembrosGrupo")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("GrupoId")]
        [InverseProperty("MembrosGrupo")]
        public virtual GrupoPessoas Grupo { get; set; }
        [ForeignKey("PessoaId")]
        [InverseProperty("MembrosGrupo")]
        public virtual Pessoa Pessoa { get; set; }
    }
}
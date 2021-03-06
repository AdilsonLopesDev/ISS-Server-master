﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class DescontoApoliceGrupo
    {
        public DescontoApoliceGrupo()
        {
            DescontoApoliceGrupoPlano = new HashSet<DescontoApoliceGrupoPlano>();
        }

        [StringLength(50)]
        public string IdDescontoApoliceGrupo { get; set; }
        public int? NumMaxPessoas { get; set; }
        public int? NumMinPessoas { get; set; }
        [StringLength(50)]
        public string CodDescontoApoliceGrupo { get; set; }
        [StringLength(50)]
        public string DescontoId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [StringLength(50)]
        public string EstadoId { get; set; }
        [StringLength(50)]
        public string Obs { get; set; }

        [ForeignKey("DescontoId")]
        [InverseProperty("DescontoApoliceGrupo")]
        public virtual Desconto Desconto { get; set; }
        [ForeignKey("EstadoId")]
        [InverseProperty("DescontoApoliceGrupo")]
        public virtual Estado Estado { get; set; }
        [InverseProperty("DescontoApoliceGrupo")]
        public virtual ICollection<DescontoApoliceGrupoPlano> DescontoApoliceGrupoPlano { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class CategoriaSujeitoDano
    {
        public CategoriaSujeitoDano()
        {
            LimiteGarantiaResponsabilidadeCivil = new HashSet<LimiteGarantiaResponsabilidadeCivil>();
        }

        [StringLength(50)]
        public string IdCategoriaSujeitoDano { get; set; }
        [StringLength(50)]
        public string CodCategoriaSujeitoDano { get; set; }
        [StringLength(500)]
        public string Designacao { get; set; }
        [StringLength(50)]
        public string ProdutoId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataActualizacao { get; set; }
        [StringLength(50)]
        public string EstadoId { get; set; }

        [ForeignKey("EstadoId")]
        [InverseProperty("CategoriaSujeitoDano")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("ProdutoId")]
        [InverseProperty("CategoriaSujeitoDano")]
        public virtual Produto Produto { get; set; }
        [InverseProperty("CategoriaSujeitoDano")]
        public virtual ICollection<LimiteGarantiaResponsabilidadeCivil> LimiteGarantiaResponsabilidadeCivil { get; set; }
    }
}
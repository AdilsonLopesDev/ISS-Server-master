﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class LocaisDesconto
    {
        [StringLength(50)]
        public string IdLocaisDesconto { get; set; }
        [Column("RegiaoID")]
        [StringLength(50)]
        public string RegiaoId { get; set; }
        [Column("PaisID")]
        [StringLength(50)]
        public string PaisId { get; set; }
        [Column("ProvinciaID")]
        [StringLength(50)]
        public string ProvinciaId { get; set; }
        [Column("MunicipioID")]
        [StringLength(50)]
        public string MunicipioId { get; set; }
        [Column("DistritoID")]
        [StringLength(50)]
        public string DistritoId { get; set; }
        [Column("NivelAbrangenciaID")]
        [StringLength(50)]
        public string NivelAbrangenciaId { get; set; }
        [Column("DescontoID")]
        [StringLength(50)]
        public string DescontoId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [Column("EstadoID")]
        [StringLength(50)]
        public string EstadoId { get; set; }

        [ForeignKey("DescontoId")]
        [InverseProperty("LocaisDesconto")]
        public virtual Desconto Desconto { get; set; }
        [ForeignKey("DistritoId")]
        [InverseProperty("LocaisDesconto")]
        public virtual Distrito Distrito { get; set; }
        [ForeignKey("EstadoId")]
        [InverseProperty("LocaisDesconto")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("MunicipioId")]
        [InverseProperty("LocaisDesconto")]
        public virtual Municipio Municipio { get; set; }
        [ForeignKey("NivelAbrangenciaId")]
        [InverseProperty("LocaisDesconto")]
        public virtual NivelAbrangencia NivelAbrangencia { get; set; }
        [ForeignKey("PaisId")]
        [InverseProperty("LocaisDesconto")]
        public virtual Pais Pais { get; set; }
        [ForeignKey("ProvinciaId")]
        [InverseProperty("LocaisDesconto")]
        public virtual Provincia Provincia { get; set; }
        [ForeignKey("RegiaoId")]
        [InverseProperty("LocaisDesconto")]
        public virtual Regiao Regiao { get; set; }
    }
}
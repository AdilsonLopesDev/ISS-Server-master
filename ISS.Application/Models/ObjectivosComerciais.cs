﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class ObjectivosComerciais
    {
        public ObjectivosComerciais()
        {
            LocaisObjectivosComerciais = new HashSet<LocaisObjectivosComerciais>();
            SegmentoObjectivosComerciais = new HashSet<SegmentoObjectivosComerciais>();
        }

        [Column("IDObjectivosComerciais")]
        [StringLength(50)]
        public string IdobjectivosComerciais { get; set; }
        public int? NumObjectivo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DataInicio { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DataFim { get; set; }
        public double? ValorProgamado { get; set; }
        public double? ValorRealizado { get; set; }
        [StringLength(2048)]
        public string Designacao { get; set; }
        [Column("ProdutoID")]
        [StringLength(50)]
        public string ProdutoId { get; set; }
        [StringLength(10)]
        public string CodObjectivosComerciais { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [Column("LinhaProdutoID")]
        [StringLength(50)]
        public string LinhaProdutoId { get; set; }
        [Column("EstadoID")]
        [StringLength(50)]
        public string EstadoId { get; set; }

        [ForeignKey("EstadoId")]
        [InverseProperty("ObjectivosComerciais")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("LinhaProdutoId")]
        [InverseProperty("ObjectivosComerciais")]
        public virtual LinhaProduto LinhaProduto { get; set; }
        [ForeignKey("ProdutoId")]
        [InverseProperty("ObjectivosComerciais")]
        public virtual Produto Produto { get; set; }
        [InverseProperty("ObjectivosComerciais")]
        public virtual ICollection<LocaisObjectivosComerciais> LocaisObjectivosComerciais { get; set; }
        [InverseProperty("ObjectivosComerciais")]
        public virtual ICollection<SegmentoObjectivosComerciais> SegmentoObjectivosComerciais { get; set; }
    }
}
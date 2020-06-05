﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class Mapa
    {
        [StringLength(50)]
        public string IdMapa { get; set; }
        [Column("ContaID")]
        [StringLength(50)]
        public string ContaId { get; set; }
        [Column("ModeloMapaID")]
        [StringLength(50)]
        public string ModeloMapaId { get; set; }
        [Column("LinhaProdutoID")]
        [StringLength(50)]
        public string LinhaProdutoId { get; set; }
        [StringLength(50)]
        public string ProdutoId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [StringLength(50)]
        public string CodMapa { get; set; }

        [ForeignKey("ContaId")]
        [InverseProperty("Mapa")]
        public virtual PlanoContas Conta { get; set; }
        [ForeignKey("LinhaProdutoId")]
        [InverseProperty("Mapa")]
        public virtual LinhaProduto LinhaProduto { get; set; }
        [ForeignKey("ModeloMapaId")]
        [InverseProperty("Mapa")]
        public virtual ModeloMapa ModeloMapa { get; set; }
        [ForeignKey("ProdutoId")]
        [InverseProperty("Mapa")]
        public virtual Produto Produto { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class FactorRisco
    {
        [StringLength(50)]
        public string IdFactorRisco { get; set; }
        [StringLength(50)]
        public string CodFactorRisco { get; set; }
        [StringLength(200)]
        public string Designacao { get; set; }
        [Column(TypeName = "ntext")]
        public string Descricao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataActualizacao { get; set; }
        [StringLength(50)]
        public string EstadoId { get; set; }
        [StringLength(50)]
        public string LinhaProdutoId { get; set; }

        [ForeignKey("EstadoId")]
        [InverseProperty("FactorRisco")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("LinhaProdutoId")]
        [InverseProperty("FactorRisco")]
        public virtual LinhaProduto LinhaProduto { get; set; }
    }
}
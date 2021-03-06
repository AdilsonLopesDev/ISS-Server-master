﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class TipoFacturacaoPlanoProduto
    {
        [StringLength(50)]
        public string IdTipoFacturacao { get; set; }
        [Column("PlanoProdutoID")]
        [StringLength(50)]
        public string PlanoProdutoId { get; set; }
        [StringLength(50)]
        public string TipoFacturacaoId { get; set; }

        [ForeignKey("PlanoProdutoId")]
        [InverseProperty("TipoFacturacaoPlanoProduto")]
        public virtual PlanoProduto PlanoProduto { get; set; }
        [ForeignKey("TipoFacturacaoId")]
        [InverseProperty("TipoFacturacaoPlanoProduto")]
        public virtual TipoFacturacao TipoFacturacao { get; set; }
    }
}
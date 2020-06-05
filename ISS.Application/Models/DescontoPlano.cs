﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class DescontoPlano
    {
        [StringLength(50)]
        public string IdDescontoPlano { get; set; }
        [StringLength(50)]
        public string CodDescontoPlano { get; set; }
        [StringLength(50)]
        public string PlanoProdutoId { get; set; }
        [StringLength(50)]
        public string DescontoId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }

        [ForeignKey("DescontoId")]
        [InverseProperty("DescontoPlano")]
        public virtual Desconto Desconto { get; set; }
        [ForeignKey("PlanoProdutoId")]
        [InverseProperty("DescontoPlano")]
        public virtual PlanoProduto PlanoProduto { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class CasoClassificacao
    {
        [StringLength(50)]
        public string IdCasoClassificacao { get; set; }
        [StringLength(50)]
        public string CodCasoClassificacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [StringLength(50)]
        public string EstadoId { get; set; }
        [StringLength(50)]
        public string PessoaId { get; set; }
        [StringLength(400)]
        public string Descricao { get; set; }
        [StringLength(50)]
        public string ClassificacaoTipoCasoId { get; set; }
        [StringLength(50)]
        public string PlanoProdutoId { get; set; }
        [StringLength(50)]
        public string DepartamentoId { get; set; }

        [ForeignKey("ClassificacaoTipoCasoId")]
        [InverseProperty("CasoClassificacao")]
        public virtual ClassificacaoTipoCaso ClassificacaoTipoCaso { get; set; }
        [ForeignKey("DepartamentoId")]
        [InverseProperty("CasoClassificacao")]
        public virtual Departamento Departamento { get; set; }
        [ForeignKey("EstadoId")]
        [InverseProperty("CasoClassificacao")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("PlanoProdutoId")]
        [InverseProperty("CasoClassificacao")]
        public virtual PlanoProduto PlanoProduto { get; set; }
    }
}
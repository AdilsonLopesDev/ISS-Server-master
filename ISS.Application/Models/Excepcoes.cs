﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class Excepcoes
    {
        public Excepcoes()
        {
            ExcepcoesPlano = new HashSet<ExcepcoesPlano>();
        }

        [StringLength(50)]
        public string IdExcepcao { get; set; }
        [StringLength(500)]
        public string Descricao { get; set; }
        [StringLength(50)]
        public string CodExcepcao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [StringLength(50)]
        public string EstadoId { get; set; }
        [StringLength(50)]
        public string PlanoProdutoId { get; set; }
        [StringLength(50)]
        public string NumOrdem { get; set; }

        [ForeignKey("PlanoProdutoId")]
        [InverseProperty("Excepcoes")]
        public virtual PlanoProduto PlanoProduto { get; set; }
        [InverseProperty("Excepcao")]
        public virtual ICollection<ExcepcoesPlano> ExcepcoesPlano { get; set; }
    }
}
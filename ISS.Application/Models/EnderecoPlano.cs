﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class EnderecoPlano
    {
        [StringLength(50)]
        public string IdEnderencoPlano { get; set; }
        [StringLength(50)]
        public string EnderencoId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataActualizacao { get; set; }
        [StringLength(50)]
        public string EstadoId { get; set; }
        [StringLength(50)]
        public string PessoaId { get; set; }
        [StringLength(50)]
        public string PlanoProdutoId { get; set; }

        [ForeignKey("EnderencoId")]
        [InverseProperty("EnderecoPlano")]
        public virtual Endereco Enderenco { get; set; }
        [ForeignKey("EstadoId")]
        [InverseProperty("EnderecoPlano")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("PessoaId")]
        [InverseProperty("EnderecoPlano")]
        public virtual Pessoa Pessoa { get; set; }
        [ForeignKey("PlanoProdutoId")]
        [InverseProperty("EnderecoPlano")]
        public virtual PlanoProduto PlanoProduto { get; set; }
    }
}
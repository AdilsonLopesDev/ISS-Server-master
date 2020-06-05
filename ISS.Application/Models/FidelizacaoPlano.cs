﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class FidelizacaoPlano
    {
        public FidelizacaoPlano()
        {
            LimiteComissionamentoPlano = new HashSet<LimiteComissionamentoPlano>();
            LimiteComissionamentoProdutor = new HashSet<LimiteComissionamentoProdutor>();
        }

        [StringLength(50)]
        public string IdFidelizacaoPlano { get; set; }
        [StringLength(50)]
        public string FidelizacaoId { get; set; }
        [StringLength(50)]
        public string PlanoProdutoId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [StringLength(50)]
        public string EstadoId { get; set; }
        [StringLength(50)]
        public string PessoaId { get; set; }

        [ForeignKey("EstadoId")]
        [InverseProperty("FidelizacaoPlano")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("FidelizacaoId")]
        [InverseProperty("FidelizacaoPlano")]
        public virtual Fidelizacao Fidelizacao { get; set; }
        [ForeignKey("PessoaId")]
        [InverseProperty("FidelizacaoPlano")]
        public virtual Pessoa Pessoa { get; set; }
        [ForeignKey("PlanoProdutoId")]
        [InverseProperty("FidelizacaoPlano")]
        public virtual PlanoProduto PlanoProduto { get; set; }
        [InverseProperty("FidelizacaoPlano")]
        public virtual ICollection<LimiteComissionamentoPlano> LimiteComissionamentoPlano { get; set; }
        [InverseProperty("FidelizacaoProdutor")]
        public virtual ICollection<LimiteComissionamentoProdutor> LimiteComissionamentoProdutor { get; set; }
    }
}
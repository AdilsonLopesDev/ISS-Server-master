﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class RespostaPergunta
    {
        [StringLength(50)]
        public string IdRespostaQuestionario { get; set; }
        [Column("PerguntaID")]
        [StringLength(50)]
        public string PerguntaId { get; set; }
        public string Resposta { get; set; }
        public string Detalhes { get; set; }
        [Column("QuestionarioID")]
        [StringLength(50)]
        public string QuestionarioId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [Column("EstadoID")]
        [StringLength(50)]
        public string EstadoId { get; set; }
        [StringLength(50)]
        public string ItemPerguntaId { get; set; }
        [StringLength(50)]
        public string AutomovelId { get; set; }

        [ForeignKey("AutomovelId")]
        [InverseProperty("RespostaPergunta")]
        public virtual Automovel Automovel { get; set; }
        [ForeignKey("EstadoId")]
        [InverseProperty("RespostaPergunta")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("ItemPerguntaId")]
        [InverseProperty("RespostaPergunta")]
        public virtual ItensPergunta ItemPergunta { get; set; }
        [ForeignKey("PerguntaId")]
        [InverseProperty("RespostaPergunta")]
        public virtual Perguntas Pergunta { get; set; }
        [ForeignKey("QuestionarioId")]
        [InverseProperty("RespostaPergunta")]
        public virtual Questionario Questionario { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class Perguntas
    {
        public Perguntas()
        {
            InversePerguntaMae = new HashSet<Perguntas>();
            ItensPergunta = new HashSet<ItensPergunta>();
            RespostaPergunta = new HashSet<RespostaPergunta>();
        }

        [StringLength(50)]
        public string IdPergunta { get; set; }
        public int? NumPergunta { get; set; }
        [StringLength(500)]
        public string Pergunta { get; set; }
        [Column("TipoQuestionarioID")]
        [StringLength(50)]
        public string TipoQuestionarioId { get; set; }
        [Column("LinhaProdutoID")]
        [StringLength(50)]
        public string LinhaProdutoId { get; set; }
        public bool? IsRadioButton { get; set; }
        public bool? IsTextBox { get; set; }
        public bool? IsCheckBox { get; set; }
        public bool? IsComboBox { get; set; }
        public bool? IsNumber { get; set; }
        [StringLength(10)]
        public string CodPerguntas { get; set; }
        public bool? IsDatePicker { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [StringLength(4000)]
        public string Legenda { get; set; }
        public double Agravamento { get; set; }
        [Column("PerguntaMaeID")]
        [StringLength(50)]
        public string PerguntaMaeId { get; set; }
        [Required]
        public bool? IsTaxa { get; set; }
        [Column("EstadoID")]
        [StringLength(50)]
        public string EstadoId { get; set; }
        [Column("UltModificacaoPorID")]
        [StringLength(50)]
        public string UltModificacaoPorId { get; set; }
        [StringLength(50)]
        public string ModalidadeSeguroId { get; set; }
        [StringLength(150)]
        public string Nota { get; set; }
        [StringLength(50)]
        public string Sourc { get; set; }

        [ForeignKey("EstadoId")]
        [InverseProperty("Perguntas")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("LinhaProdutoId")]
        [InverseProperty("Perguntas")]
        public virtual LinhaProduto LinhaProduto { get; set; }
        [ForeignKey("ModalidadeSeguroId")]
        [InverseProperty("Perguntas")]
        public virtual ModalidadeSeguro ModalidadeSeguro { get; set; }
        [ForeignKey("PerguntaMaeId")]
        [InverseProperty("InversePerguntaMae")]
        public virtual Perguntas PerguntaMae { get; set; }
        [ForeignKey("TipoQuestionarioId")]
        [InverseProperty("Perguntas")]
        public virtual TipoQuestionario TipoQuestionario { get; set; }
        [InverseProperty("PerguntaMae")]
        public virtual ICollection<Perguntas> InversePerguntaMae { get; set; }
        [InverseProperty("Pergunta")]
        public virtual ICollection<ItensPergunta> ItensPergunta { get; set; }
        [InverseProperty("Pergunta")]
        public virtual ICollection<RespostaPergunta> RespostaPergunta { get; set; }
    }
}
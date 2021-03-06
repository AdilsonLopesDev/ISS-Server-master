﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class Lesado
    {
        public Lesado()
        {
            DocumentosLesado = new HashSet<DocumentosLesado>();
            LesaoLesado = new HashSet<LesaoLesado>();
        }

        [StringLength(50)]
        public string IdLesado { get; set; }
        public bool? RelacaoComResponsavelAcidente { get; set; }
        [StringLength(2048)]
        public string EspecificacaoRelacao { get; set; }
        [StringLength(2048)]
        public string EspecificacaoDanos { get; set; }
        [StringLength(50)]
        public string TipoIntervencaoId { get; set; }
        [StringLength(50)]
        public string TipoDanosId { get; set; }
        [Column("TipoRelacaoSeguradoID")]
        [StringLength(50)]
        public string TipoRelacaoSeguradoId { get; set; }
        [Column("PessoaID")]
        [StringLength(50)]
        public string PessoaId { get; set; }
        [StringLength(50)]
        public string SinistroId { get; set; }
        [Column("FornecedorID")]
        [StringLength(50)]
        public string FornecedorId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataInicioPeriodoIncapacidadeTemporario { get; set; }
        [StringLength(500)]
        public string CaminhoBoletimExame { get; set; }
        [StringLength(500)]
        public string CaminhoBoletimObito { get; set; }
        [StringLength(500)]
        public string CaminhoRelatorioAutopsia { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataPrimeiroSocorro { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [Column("EstadoID")]
        [StringLength(50)]
        public string EstadoId { get; set; }
        [Column("UltModificacaoPorID")]
        [StringLength(50)]
        public string UltModificacaoPorId { get; set; }
        [StringLength(50)]
        public string CodLesado { get; set; }
        public bool? IsFerido { get; set; }

        [ForeignKey("EstadoId")]
        [InverseProperty("Lesado")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("FornecedorId")]
        [InverseProperty("LesadoFornecedor")]
        public virtual Pessoa Fornecedor { get; set; }
        [ForeignKey("PessoaId")]
        [InverseProperty("LesadoPessoa")]
        public virtual Pessoa Pessoa { get; set; }
        [ForeignKey("SinistroId")]
        [InverseProperty("Lesado")]
        public virtual Sinistro Sinistro { get; set; }
        [ForeignKey("TipoDanosId")]
        [InverseProperty("Lesado")]
        public virtual TipoDanos TipoDanos { get; set; }
        [ForeignKey("TipoIntervencaoId")]
        [InverseProperty("Lesado")]
        public virtual TipoIntervencao TipoIntervencao { get; set; }
        [ForeignKey("TipoRelacaoSeguradoId")]
        [InverseProperty("Lesado")]
        public virtual TipoRelacaoSegurado TipoRelacaoSegurado { get; set; }
        [InverseProperty("Lesado")]
        public virtual ICollection<DocumentosLesado> DocumentosLesado { get; set; }
        [InverseProperty("Lesado")]
        public virtual ICollection<LesaoLesado> LesaoLesado { get; set; }
    }
}
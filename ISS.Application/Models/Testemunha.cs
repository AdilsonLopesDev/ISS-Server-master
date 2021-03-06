﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class Testemunha
    {
        public Testemunha()
        {
            DocumentosTestemunha = new HashSet<DocumentosTestemunha>();
            InverseProfissao = new HashSet<Testemunha>();
        }

        [StringLength(50)]
        public string IdTestemunha { get; set; }
        [Column("TipoRelacaoSeguradoID")]
        [StringLength(50)]
        public string TipoRelacaoSeguradoId { get; set; }
        [Column("PessoaID")]
        [StringLength(50)]
        public string PessoaId { get; set; }
        [StringLength(50)]
        public string SinistroId { get; set; }
        [StringLength(4000)]
        public string Declaracao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataDeclaracao { get; set; }
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
        public string CodTestemunha { get; set; }
        [StringLength(50)]
        public string ProfissaoId { get; set; }
        [StringLength(50)]
        public string OndeSeEncontrava { get; set; }
        [StringLength(50)]
        public string LocalTrabalho { get; set; }
        [StringLength(50)]
        public string DeclaracaoTestemunhaId { get; set; }
        [StringLength(50)]
        public string ApoliceId { get; set; }

        [ForeignKey("ApoliceId")]
        [InverseProperty("Testemunha")]
        public virtual Apolice Apolice { get; set; }
        [ForeignKey("DeclaracaoTestemunhaId")]
        [InverseProperty("Testemunha")]
        public virtual DeclaracaoTestemunha DeclaracaoTestemunha { get; set; }
        [ForeignKey("EstadoId")]
        [InverseProperty("Testemunha")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("PessoaId")]
        [InverseProperty("Testemunha")]
        public virtual Pessoa Pessoa { get; set; }
        [ForeignKey("ProfissaoId")]
        [InverseProperty("InverseProfissao")]
        public virtual Testemunha Profissao { get; set; }
        [ForeignKey("SinistroId")]
        [InverseProperty("Testemunha")]
        public virtual Sinistro Sinistro { get; set; }
        [ForeignKey("TipoRelacaoSeguradoId")]
        [InverseProperty("Testemunha")]
        public virtual TipoRelacaoSegurado TipoRelacaoSegurado { get; set; }
        [InverseProperty("Testemunha")]
        public virtual ICollection<DocumentosTestemunha> DocumentosTestemunha { get; set; }
        [InverseProperty("Profissao")]
        public virtual ICollection<Testemunha> InverseProfissao { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class Paciente
    {
        public Paciente()
        {
            Perda = new HashSet<Perda>();
        }

        [StringLength(50)]
        public string IdPaciente { get; set; }
        [StringLength(50)]
        public string NumeroPaciente { get; set; }
        public bool? RecebeuAlta { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataFimTratamento { get; set; }
        [Column("ApoliceID")]
        [StringLength(50)]
        public string ApoliceId { get; set; }
        [Column("TipoRelacaoSeguradoID")]
        [StringLength(50)]
        public string TipoRelacaoSeguradoId { get; set; }
        [Column("PessoaID")]
        [StringLength(50)]
        public string PessoaId { get; set; }
        [StringLength(50)]
        public string SinistroId { get; set; }
        [StringLength(500)]
        public string CaminhoBoletimExame { get; set; }
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
        public string CodPaciente { get; set; }

        [ForeignKey("ApoliceId")]
        [InverseProperty("Paciente")]
        public virtual Apolice Apolice { get; set; }
        [ForeignKey("EstadoId")]
        [InverseProperty("Paciente")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("PessoaId")]
        [InverseProperty("Paciente")]
        public virtual Pessoa Pessoa { get; set; }
        [ForeignKey("SinistroId")]
        [InverseProperty("Paciente")]
        public virtual Sinistro Sinistro { get; set; }
        [ForeignKey("TipoRelacaoSeguradoId")]
        [InverseProperty("Paciente")]
        public virtual TipoRelacaoSegurado TipoRelacaoSegurado { get; set; }
        [InverseProperty("Paciente")]
        public virtual ICollection<Perda> Perda { get; set; }
    }
}
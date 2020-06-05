﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class Animais
    {
        [StringLength(50)]
        public string IdAnimal { get; set; }
        [StringLength(100)]
        public string Nome { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DataCompra { get; set; }
        public int? Idade { get; set; }
        [StringLength(1000)]
        public string Observacao { get; set; }
        [StringLength(512)]
        public string Raca { get; set; }
        [Column("UnidadeTempoID")]
        [StringLength(50)]
        public string UnidadeTempoId { get; set; }
        [Column("ModalidadesRCSelecionadaID")]
        [StringLength(50)]
        public string ModalidadesRcselecionadaId { get; set; }
        [Column("EspecieAnimalID")]
        [StringLength(50)]
        public string EspecieAnimalId { get; set; }
        [StringLength(10)]
        public string CodAnimais { get; set; }
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
        [Column("PessoaID")]
        [StringLength(50)]
        public string PessoaId { get; set; }

        [ForeignKey("EspecieAnimalId")]
        [InverseProperty("Animais")]
        public virtual EspecieAnimais EspecieAnimal { get; set; }
        [ForeignKey("EstadoId")]
        [InverseProperty("Animais")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("ModalidadesRcselecionadaId")]
        [InverseProperty("Animais")]
        public virtual ModalidadesRcselecionadas ModalidadesRcselecionada { get; set; }
        [ForeignKey("PessoaId")]
        [InverseProperty("Animais")]
        public virtual Pessoa Pessoa { get; set; }
        [ForeignKey("UnidadeTempoId")]
        [InverseProperty("Animais")]
        public virtual UnidadesTempo UnidadeTempo { get; set; }
    }
}
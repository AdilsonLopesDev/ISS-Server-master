﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class PessoaMovimento
    {
        [StringLength(50)]
        public string IdPessoaMovimento { get; set; }
        [StringLength(50)]
        public string PessoaId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [StringLength(50)]
        public string CodPessoaMovimento { get; set; }
        [StringLength(50)]
        public string MovimentoId { get; set; }

        [ForeignKey("MovimentoId")]
        [InverseProperty("PessoaMovimento")]
        public virtual Pessoa Movimento { get; set; }
    }
}
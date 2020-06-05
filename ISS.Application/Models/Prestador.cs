﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class Prestador
    {
        [StringLength(50)]
        public string IdPrestador { get; set; }
        [StringLength(50)]
        public string PessoaId { get; set; }
        [StringLength(50)]
        public string CodPrestador { get; set; }
        [StringLength(50)]
        public string ApoliceId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [StringLength(50)]
        public string EstadoId { get; set; }

        [ForeignKey("ApoliceId")]
        [InverseProperty("Prestador")]
        public virtual Apolice Apolice { get; set; }
        [ForeignKey("EstadoId")]
        [InverseProperty("Prestador")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("PessoaId")]
        [InverseProperty("Prestador")]
        public virtual Pessoa Pessoa { get; set; }
    }
}
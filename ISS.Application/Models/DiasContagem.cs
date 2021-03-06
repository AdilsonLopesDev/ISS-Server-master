﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class DiasContagem
    {
        [StringLength(50)]
        public string IdDiasContagem { get; set; }
        [StringLength(50)]
        public string ApoliceId { get; set; }
        public bool? Segunda { get; set; }
        public bool? Terca { get; set; }
        public bool? Quarta { get; set; }
        public bool? Quinta { get; set; }
        public bool? Sexta { get; set; }
        public bool? Sabado { get; set; }
        public bool? Domingo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataActualizacao { get; set; }
        [StringLength(50)]
        public string EstadoId { get; set; }

        [ForeignKey("ApoliceId")]
        [InverseProperty("DiasContagem")]
        public virtual Apolice Apolice { get; set; }
        [ForeignKey("EstadoId")]
        [InverseProperty("DiasContagem")]
        public virtual Estado Estado { get; set; }
    }
}
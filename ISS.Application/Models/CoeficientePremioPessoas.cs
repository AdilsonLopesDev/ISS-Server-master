﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class CoeficientePremioPessoas
    {
        [StringLength(50)]
        public string IdCoeficientePremioPessoas { get; set; }
        public int? NumeroMax { get; set; }
        public int? NumeroMin { get; set; }
        public double? AgravamentoOuDesconto { get; set; }
        [StringLength(50)]
        public string CodCoeficientePremioPessoas { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataActualizacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [StringLength(50)]
        public string EstadoId { get; set; }
        [StringLength(50)]
        public string TipoCoberturaId { get; set; }

        [ForeignKey("EstadoId")]
        [InverseProperty("CoeficientePremioPessoas")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("TipoCoberturaId")]
        [InverseProperty("CoeficientePremioPessoas")]
        public virtual TipoCobertura TipoCobertura { get; set; }
    }
}
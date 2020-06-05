﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class CircunstanciaObjectoEnvolvido
    {
        [StringLength(50)]
        public string IdCircunstanciaObjectoEnvolvido { get; set; }
        [Column("CircunstanciaVeiculoID")]
        [StringLength(50)]
        public string CircunstanciaVeiculoId { get; set; }
        [Column("ObjectoEnvolvidoID")]
        [StringLength(50)]
        public string ObjectoEnvolvidoId { get; set; }
        [StringLength(10)]
        public string CodCircunstanciaObjectoEnvolvido { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [Column("EstadoID")]
        [StringLength(50)]
        public string EstadoId { get; set; }

        [ForeignKey("CircunstanciaVeiculoId")]
        [InverseProperty("CircunstanciaObjectoEnvolvido")]
        public virtual CircunstanciaAutomovel CircunstanciaVeiculo { get; set; }
        [ForeignKey("EstadoId")]
        [InverseProperty("CircunstanciaObjectoEnvolvido")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("ObjectoEnvolvidoId")]
        [InverseProperty("CircunstanciaObjectoEnvolvido")]
        public virtual ObjectoEnvolvido ObjectoEnvolvido { get; set; }
    }
}
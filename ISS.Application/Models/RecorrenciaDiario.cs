﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class RecorrenciaDiario
    {
        [StringLength(50)]
        public string IdRecorrenciaDiario { get; set; }
        [StringLength(50)]
        public string PadraoRecorrenciaId { get; set; }
        public int? NumeroRecorrenciaDias { get; set; }
        public int? NumRegenerarTarefa { get; set; }
        public bool? DiaSemanaRecorrencia { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [StringLength(50)]
        public string EstadoId { get; set; }

        [ForeignKey("EstadoId")]
        [InverseProperty("RecorrenciaDiario")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("PadraoRecorrenciaId")]
        [InverseProperty("RecorrenciaDiario")]
        public virtual PadraoRecorrencia PadraoRecorrencia { get; set; }
    }
}
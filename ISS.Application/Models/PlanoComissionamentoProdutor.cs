﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class PlanoComissionamentoProdutor
    {
        [StringLength(50)]
        public string IdPlanoComissionamentoProdutor { get; set; }
        [StringLength(50)]
        public string PlanoContasId { get; set; }
        [StringLength(50)]
        public string AgenteProdutorId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [StringLength(50)]
        public string EstadoId { get; set; }

        [ForeignKey("AgenteProdutorId")]
        [InverseProperty("PlanoComissionamentoProdutor")]
        public virtual Pessoa AgenteProdutor { get; set; }
        [ForeignKey("EstadoId")]
        [InverseProperty("PlanoComissionamentoProdutor")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("PlanoContasId")]
        [InverseProperty("PlanoComissionamentoProdutor")]
        public virtual PlanoContas PlanoContas { get; set; }
    }
}
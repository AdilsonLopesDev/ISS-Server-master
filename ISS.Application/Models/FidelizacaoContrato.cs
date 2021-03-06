﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class FidelizacaoContrato
    {
        [StringLength(50)]
        public string IdFidelizacaoContrato { get; set; }
        [StringLength(50)]
        public string CodFidelizacaoContrato { get; set; }
        [StringLength(50)]
        public string FidelizacaoId { get; set; }
        [StringLength(50)]
        public string ContratoId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }

        [ForeignKey("ContratoId")]
        [InverseProperty("FidelizacaoContrato")]
        public virtual Contrato Contrato { get; set; }
        [ForeignKey("FidelizacaoId")]
        [InverseProperty("FidelizacaoContrato")]
        public virtual Fidelizacao Fidelizacao { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class AgravamentoApolice
    {
        [StringLength(50)]
        public string IdAgravamentoApolice { get; set; }
        [StringLength(50)]
        public string Designacao { get; set; }
        [StringLength(50)]
        public string AgravamentoId { get; set; }
        [StringLength(50)]
        public string ApoliceId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column("DataATualizacao", TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }

        [ForeignKey("AgravamentoId")]
        [InverseProperty("AgravamentoApolice")]
        public virtual Agravamento Agravamento { get; set; }
        [ForeignKey("ApoliceId")]
        [InverseProperty("AgravamentoApolice")]
        public virtual Apolice Apolice { get; set; }
    }
}
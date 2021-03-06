﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class CotacaoDependente
    {
        [StringLength(50)]
        public string IdCotacaoDependente { get; set; }
        [StringLength(50)]
        public string CotacaoId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        public long NumOrdem { get; set; }
        [StringLength(50)]
        public string ApoliceId { get; set; }

        [ForeignKey("ApoliceId")]
        [InverseProperty("CotacaoDependente")]
        public virtual Apolice Apolice { get; set; }
        [ForeignKey("CotacaoId")]
        [InverseProperty("CotacaoDependente")]
        public virtual Cotacao Cotacao { get; set; }
    }
}
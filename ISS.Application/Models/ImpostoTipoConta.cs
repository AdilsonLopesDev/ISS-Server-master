﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class ImpostoTipoConta
    {
        [StringLength(50)]
        public string IdImpostoTipoConta { get; set; }
        [StringLength(50)]
        public string ImpostoId { get; set; }
        [StringLength(50)]
        public string TipoContaId { get; set; }
        [StringLength(50)]
        public string CodImpostoTipoConta { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }

        [ForeignKey("ImpostoId")]
        [InverseProperty("ImpostoTipoConta")]
        public virtual Imposto Imposto { get; set; }
        [ForeignKey("TipoContaId")]
        [InverseProperty("ImpostoTipoConta")]
        public virtual TipoConta TipoConta { get; set; }
    }
}
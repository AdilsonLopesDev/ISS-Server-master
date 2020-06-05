﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class TipoDeRecebimento
    {
        public TipoDeRecebimento()
        {
            SubTipoDeRecebimento = new HashSet<SubTipoDeRecebimento>();
        }

        [StringLength(50)]
        public string IdTipoDeRecebimento { get; set; }
        [StringLength(50)]
        public string Designacao { get; set; }
        [StringLength(50)]
        public string CodigoTipoDeRecebimento { get; set; }
        [StringLength(50)]
        public string EstadoId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }

        [ForeignKey("EstadoId")]
        [InverseProperty("TipoDeRecebimento")]
        public virtual Estado Estado { get; set; }
        [InverseProperty("TipoDeRecebimento")]
        public virtual ICollection<SubTipoDeRecebimento> SubTipoDeRecebimento { get; set; }
    }
}
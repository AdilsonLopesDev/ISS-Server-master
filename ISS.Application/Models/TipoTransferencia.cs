﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class TipoTransferencia
    {
        public TipoTransferencia()
        {
            Transferencia = new HashSet<Transferencia>();
        }

        [StringLength(50)]
        public string IdTipoTransferencia { get; set; }
        [StringLength(50)]
        public string Designacao { get; set; }
        [StringLength(50)]
        public string CodTipoTransferencia { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [StringLength(50)]
        public string EstadoId { get; set; }

        [ForeignKey("EstadoId")]
        [InverseProperty("TipoTransferencia")]
        public virtual Estado Estado { get; set; }
        [InverseProperty("TipoTransferencia")]
        public virtual ICollection<Transferencia> Transferencia { get; set; }
    }
}
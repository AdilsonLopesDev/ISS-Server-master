﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class TipoConstrucaoPneus
    {
        public TipoConstrucaoPneus()
        {
            Pneu = new HashSet<Pneu>();
        }

        [StringLength(50)]
        public string IdTipoConstrucaoPneus { get; set; }
        [StringLength(100)]
        public string Designacao { get; set; }
        [StringLength(10)]
        public string CodTipoConstrucaoPneus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [Column("EstadoID")]
        [StringLength(50)]
        public string EstadoId { get; set; }
        [StringLength(500)]
        public string CaminhoIcone { get; set; }

        [ForeignKey("EstadoId")]
        [InverseProperty("TipoConstrucaoPneus")]
        public virtual Estado Estado { get; set; }
        [InverseProperty("TipoConstrucaoPneus")]
        public virtual ICollection<Pneu> Pneu { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class CondicoesReSeguro
    {
        [StringLength(50)]
        public string IdCondicoesReSeguro { get; set; }
        [StringLength(500)]
        public string CaminhoDocumento { get; set; }
        [Column("CondicoesID")]
        [StringLength(50)]
        public string CondicoesId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [Column("EstadoID")]
        [StringLength(50)]
        public string EstadoId { get; set; }
        [StringLength(50)]
        public string ResseguroId { get; set; }

        [ForeignKey("CondicoesId")]
        [InverseProperty("CondicoesReSeguro")]
        public virtual Condicoes Condicoes { get; set; }
        [ForeignKey("EstadoId")]
        [InverseProperty("CondicoesReSeguro")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("ResseguroId")]
        [InverseProperty("CondicoesReSeguro")]
        public virtual Resseguro Resseguro { get; set; }
    }
}
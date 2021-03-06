﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class SubFormaResseguroInformacao
    {
        public SubFormaResseguroInformacao()
        {
            TiposContratosResseguroInformacoesTiposContratosResseguro = new HashSet<TiposContratosResseguroInformacoesTiposContratosResseguro>();
        }

        [Column("IdISubFormaFormaResseguroInformacao")]
        [StringLength(50)]
        public string IdIsubFormaFormaResseguroInformacao { get; set; }
        public double? Cedencia { get; set; }
        public double? ValorLiquido { get; set; }
        public double? TotalLiquido { get; set; }
        [StringLength(50)]
        public string MoedaId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? AnoTratado { get; set; }
        [StringLength(50)]
        public string Tratado { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [StringLength(10)]
        public string CodSubFormaResseguroInformacao { get; set; }
        [StringLength(50)]
        public string EstadoId { get; set; }
        [StringLength(50)]
        public string ComissaoId { get; set; }
        [StringLength(50)]
        public string SinistroId { get; set; }
        [StringLength(50)]
        public string Designacao { get; set; }
        [StringLength(50)]
        public string SubFormaResseguroId { get; set; }

        [ForeignKey("ComissaoId")]
        [InverseProperty("SubFormaResseguroInformacao")]
        public virtual Comissao Comissao { get; set; }
        [ForeignKey("EstadoId")]
        [InverseProperty("SubFormaResseguroInformacao")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("MoedaId")]
        [InverseProperty("SubFormaResseguroInformacao")]
        public virtual Moeda Moeda { get; set; }
        [ForeignKey("SinistroId")]
        [InverseProperty("SubFormaResseguroInformacao")]
        public virtual Sinistro Sinistro { get; set; }
        [InverseProperty("InformacoesTiposContratosResseguro")]
        public virtual ICollection<TiposContratosResseguroInformacoesTiposContratosResseguro> TiposContratosResseguroInformacoesTiposContratosResseguro { get; set; }
    }
}
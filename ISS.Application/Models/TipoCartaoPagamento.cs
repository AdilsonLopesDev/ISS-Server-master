﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class TipoCartaoPagamento
    {
        public TipoCartaoPagamento()
        {
            BandeiraTipoCartao = new HashSet<BandeiraTipoCartao>();
            CartaoPagamento = new HashSet<CartaoPagamento>();
        }

        [StringLength(50)]
        public string IdTipoCartaoPagamento { get; set; }
        [StringLength(200)]
        public string Designacao { get; set; }
        [StringLength(10)]
        public string CodTipoCartaoPagamento { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [Column("EstadoID")]
        [StringLength(50)]
        public string EstadoId { get; set; }
        [StringLength(500)]
        public string CaminhoIcone { get; set; }
        [StringLength(50)]
        public string FormaPagamentoId { get; set; }

        [ForeignKey("EstadoId")]
        [InverseProperty("TipoCartaoPagamento")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("FormaPagamentoId")]
        [InverseProperty("TipoCartaoPagamento")]
        public virtual FormaPagamento FormaPagamento { get; set; }
        [InverseProperty("TipoCartaoPagamento")]
        public virtual ICollection<BandeiraTipoCartao> BandeiraTipoCartao { get; set; }
        [InverseProperty("TipoCartaoPagamento")]
        public virtual ICollection<CartaoPagamento> CartaoPagamento { get; set; }
    }
}
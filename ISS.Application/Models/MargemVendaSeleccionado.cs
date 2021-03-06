﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class MargemVendaSeleccionado
    {
        [StringLength(50)]
        public string IdMargemVendaSeleccionado { get; set; }
        public double? Valor { get; set; }
        [Column("MargemVendaProdutoID")]
        [StringLength(50)]
        public string MargemVendaProdutoId { get; set; }
        [Column("CotacaoID")]
        [StringLength(50)]
        public string CotacaoId { get; set; }
        [StringLength(50)]
        public string PessoaId { get; set; }
        [Column("ApoliceID")]
        [StringLength(50)]
        public string ApoliceId { get; set; }
        [Column("EstadoID")]
        [StringLength(50)]
        public string EstadoId { get; set; }
        [StringLength(50)]
        public string CodMargemVendaSeleccionado { get; set; }

        [ForeignKey("ApoliceId")]
        [InverseProperty("MargemVendaSeleccionado")]
        public virtual Apolice Apolice { get; set; }
        [ForeignKey("CotacaoId")]
        [InverseProperty("MargemVendaSeleccionado")]
        public virtual Cotacao Cotacao { get; set; }
        [ForeignKey("EstadoId")]
        [InverseProperty("MargemVendaSeleccionado")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("MargemVendaProdutoId")]
        [InverseProperty("MargemVendaSeleccionado")]
        public virtual MargemVendaProduto MargemVendaProduto { get; set; }
        [ForeignKey("PessoaId")]
        [InverseProperty("MargemVendaSeleccionado")]
        public virtual Pessoa Pessoa { get; set; }
    }
}
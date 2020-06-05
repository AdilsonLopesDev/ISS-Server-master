﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class InformacaoAdicional
    {
        public InformacaoAdicional()
        {
            Automovel = new HashSet<Automovel>();
        }

        [StringLength(50)]
        public string IdInformacaoAdicional { get; set; }
        [StringLength(10)]
        public string CodInformacaoAdicional { get; set; }
        [StringLength(3000)]
        public string DescricaoInformacaoAdicional { get; set; }
        public double? PercentagemNivelFincanceiro { get; set; }
        public double? MontanteNivelFinanceiro { get; set; }
        public bool CoberturaDanosAcidentaisNecessaria { get; set; }
        [StringLength(50)]
        public string IdentificadorContrato { get; set; }
        public double? ValorClassificacao { get; set; }
        public bool? PagadorInteresseAdicional { get; set; }
        [StringLength(50)]
        public string CodigoFrequenciaFactura { get; set; }
        [StringLength(50)]
        public string CodigoFrequenciaCopiaCertificado { get; set; }
        [StringLength(2000)]
        public string DescricaoFrequenciaCopiaCertificado { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataHoraProximaRequisicaoCertificado { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataHoraUltimaEmissaoCertificado { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataHoraProximaRequisicaoApolice { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataHoraUltimaEmissaoApolice { get; set; }
        [StringLength(50)]
        public string CodigoFrequenciaCopiaApolice { get; set; }
        [StringLength(2000)]
        public string DescricaoFrequenciaCopiaApolice { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataHoraTermino { get; set; }
        public bool? FacturaApenasInformativa { get; set; }
        [Column("PessoaID")]
        [StringLength(50)]
        public string PessoaId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [StringLength(50)]
        public string EstadoId { get; set; }

        [ForeignKey("EstadoId")]
        [InverseProperty("InformacaoAdicional")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("PessoaId")]
        [InverseProperty("InformacaoAdicional")]
        public virtual Pessoa Pessoa { get; set; }
        [InverseProperty("InformacaoAdicional")]
        public virtual ICollection<Automovel> Automovel { get; set; }
    }
}
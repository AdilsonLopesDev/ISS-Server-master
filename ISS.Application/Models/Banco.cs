﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class Banco
    {
        public Banco()
        {
            ClassificacaoCaixa = new HashSet<ClassificacaoCaixa>();
            InformacaoBancaria = new HashSet<InformacaoBancaria>();
            Transferencia = new HashSet<Transferencia>();
        }

        [StringLength(50)]
        public string IdBanco { get; set; }
        [StringLength(200)]
        public string Nome { get; set; }
        [Column("CAEid")]
        [StringLength(50)]
        public string Caeid { get; set; }
        [Column("ClassificacaoEntidadeID")]
        [StringLength(50)]
        public string ClassificacaoEntidadeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [Column("EstadoID")]
        [StringLength(50)]
        public string EstadoId { get; set; }
        [Column("UltModificacaoPorID")]
        [StringLength(50)]
        public string UltModificacaoPorId { get; set; }
        [StringLength(50)]
        public string Sigla { get; set; }
        public int? SwiftCode { get; set; }
        public int? NumeroRegisto { get; set; }
        [Column(TypeName = "ntext")]
        public string CaminhoImagem { get; set; }

        [ForeignKey("Caeid")]
        [InverseProperty("Banco")]
        public virtual Cae Cae { get; set; }
        [ForeignKey("ClassificacaoEntidadeId")]
        [InverseProperty("Banco")]
        public virtual ClassificacaoEntidade ClassificacaoEntidade { get; set; }
        [ForeignKey("EstadoId")]
        [InverseProperty("Banco")]
        public virtual Estado Estado { get; set; }
        [InverseProperty("Banco")]
        public virtual ICollection<ClassificacaoCaixa> ClassificacaoCaixa { get; set; }
        [InverseProperty("NomeBanco")]
        public virtual ICollection<InformacaoBancaria> InformacaoBancaria { get; set; }
        [InverseProperty("BancoDestinoNavigation")]
        public virtual ICollection<Transferencia> Transferencia { get; set; }
    }
}
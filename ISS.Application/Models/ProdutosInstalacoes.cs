﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class ProdutosInstalacoes
    {
        public ProdutosInstalacoes()
        {
            ExportacoesProdutosInstalacoes = new HashSet<ExportacoesProdutosInstalacoes>();
        }

        [StringLength(50)]
        public string IdProdutoInstalacao { get; set; }
        [StringLength(300)]
        public string Nome { get; set; }
        public double? EstimativaVendaAnuais { get; set; }
        [StringLength(512)]
        public string CaminhoFicheiro { get; set; }
        [Column("MoedaID")]
        [StringLength(50)]
        public string MoedaId { get; set; }
        [Column("PaisFornecedorID")]
        [StringLength(50)]
        public string PaisFornecedorId { get; set; }
        [Column("CategoriaProdutoInstalacaoID")]
        [StringLength(50)]
        public string CategoriaProdutoInstalacaoId { get; set; }
        [Column("InstalacaoID")]
        [StringLength(50)]
        public string InstalacaoId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [Column("EstadoID")]
        [StringLength(50)]
        public string EstadoId { get; set; }

        [ForeignKey("CategoriaProdutoInstalacaoId")]
        [InverseProperty("ProdutosInstalacoes")]
        public virtual CategoriasProdutosInstalacoes CategoriaProdutoInstalacao { get; set; }
        [ForeignKey("EstadoId")]
        [InverseProperty("ProdutosInstalacoes")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("InstalacaoId")]
        [InverseProperty("ProdutosInstalacoes")]
        public virtual Instalacoes Instalacao { get; set; }
        [ForeignKey("MoedaId")]
        [InverseProperty("ProdutosInstalacoes")]
        public virtual Moeda Moeda { get; set; }
        [ForeignKey("PaisFornecedorId")]
        [InverseProperty("ProdutosInstalacoes")]
        public virtual Pais PaisFornecedor { get; set; }
        [InverseProperty("ProdutoInstalacao")]
        public virtual ICollection<ExportacoesProdutosInstalacoes> ExportacoesProdutosInstalacoes { get; set; }
    }
}
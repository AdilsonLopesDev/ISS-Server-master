﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class Risco
    {
        public Risco()
        {
            Exclusoes = new HashSet<Exclusoes>();
            InverseRiscoPai = new HashSet<Risco>();
            RiscoOutraSeguradoraContrato = new HashSet<RiscoOutraSeguradoraContrato>();
            SubRisco = new HashSet<SubRisco>();
        }

        [StringLength(50)]
        public string IdRisco { get; set; }
        [Column(TypeName = "text")]
        public string Designacao { get; set; }
        [Column("LinhaProdutoID")]
        [StringLength(50)]
        public string LinhaProdutoId { get; set; }
        [StringLength(10)]
        public string CodRisco { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [Column("ProdutoID")]
        [StringLength(50)]
        public string ProdutoId { get; set; }
        [Column("EstadoID")]
        [StringLength(50)]
        public string EstadoId { get; set; }
        [Column("UltModificacaoPorID")]
        [StringLength(50)]
        public string UltModificacaoPorId { get; set; }
        public double? ValorMin { get; set; }
        public double? ValorMax { get; set; }
        public double? Agravamento { get; set; }
        [Column(TypeName = "ntext")]
        public string Descricao { get; set; }
        [StringLength(50)]
        public string RiscoPaiId { get; set; }
        [StringLength(50)]
        public string TipoRiscoId { get; set; }
        public string Nota { get; set; }
        [StringLength(50)]
        public string PlanoProdutoId { get; set; }

        [ForeignKey("EstadoId")]
        [InverseProperty("Risco")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("LinhaProdutoId")]
        [InverseProperty("Risco")]
        public virtual LinhaProduto LinhaProduto { get; set; }
        [ForeignKey("PlanoProdutoId")]
        [InverseProperty("Risco")]
        public virtual PlanoProduto PlanoProduto { get; set; }
        [ForeignKey("ProdutoId")]
        [InverseProperty("Risco")]
        public virtual Produto Produto { get; set; }
        [ForeignKey("RiscoPaiId")]
        [InverseProperty("InverseRiscoPai")]
        public virtual Risco RiscoPai { get; set; }
        [ForeignKey("TipoRiscoId")]
        [InverseProperty("Risco")]
        public virtual TipoRisco TipoRisco { get; set; }
        [InverseProperty("Risco")]
        public virtual ICollection<Exclusoes> Exclusoes { get; set; }
        [InverseProperty("RiscoPai")]
        public virtual ICollection<Risco> InverseRiscoPai { get; set; }
        [InverseProperty("Risco")]
        public virtual ICollection<RiscoOutraSeguradoraContrato> RiscoOutraSeguradoraContrato { get; set; }
        [InverseProperty("Risco")]
        public virtual ICollection<SubRisco> SubRisco { get; set; }
    }
}
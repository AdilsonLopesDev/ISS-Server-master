﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class PrazosCurtos
    {
        public PrazosCurtos()
        {
            Cotacao = new HashSet<Cotacao>();
            PlanoProduto = new HashSet<PlanoProduto>();
        }

        [StringLength(50)]
        public string IdPrazo { get; set; }
        public int? DiasMin { get; set; }
        public int? DiasMax { get; set; }
        public double Porcentagem { get; set; }
        [StringLength(200)]
        public string DescricaoPrazo { get; set; }
        [StringLength(10)]
        public string CodPrazosCurtos { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [Required]
        public bool? IsTaxa { get; set; }
        [Column("EstadoID")]
        [StringLength(50)]
        public string EstadoId { get; set; }
        [Column("UltModificacaoPorID")]
        [StringLength(50)]
        public string UltModificacaoPorId { get; set; }
        [StringLength(50)]
        public string LinhaProdutoId { get; set; }
        [StringLength(50)]
        public string DuracaoTipoContratoId { get; set; }

        [ForeignKey("DuracaoTipoContratoId")]
        [InverseProperty("PrazosCurtos")]
        public virtual DuracaoTipoContrato DuracaoTipoContrato { get; set; }
        [ForeignKey("EstadoId")]
        [InverseProperty("PrazosCurtos")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("LinhaProdutoId")]
        [InverseProperty("PrazosCurtos")]
        public virtual LinhaProduto LinhaProduto { get; set; }
        [InverseProperty("PrazoCurto")]
        public virtual ICollection<Cotacao> Cotacao { get; set; }
        [InverseProperty("Prazo")]
        public virtual ICollection<PlanoProduto> PlanoProduto { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class DocumentosNecessarioPorLinha
    {
        [StringLength(50)]
        public string IdDocumentosNecessarioLinha { get; set; }
        [StringLength(50)]
        public string DocumentoLinhaId { get; set; }
        [StringLength(50)]
        public string LinhaProdutoId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [StringLength(50)]
        public string EstadoId { get; set; }
        [StringLength(50)]
        public string CodDocumentosNecessarioPorLinha { get; set; }

        [ForeignKey("DocumentoLinhaId")]
        [InverseProperty("DocumentosNecessarioPorLinha")]
        public virtual DocumentosLinha DocumentoLinha { get; set; }
        [ForeignKey("EstadoId")]
        [InverseProperty("DocumentosNecessarioPorLinha")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("LinhaProdutoId")]
        [InverseProperty("DocumentosNecessarioPorLinha")]
        public virtual LinhaProduto LinhaProduto { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class DocumentosLinha
    {
        public DocumentosLinha()
        {
            DocumentosNecessarioPorLinha = new HashSet<DocumentosNecessarioPorLinha>();
        }

        [StringLength(50)]
        public string IdDocumentoLinha { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [StringLength(50)]
        public string EstadoId { get; set; }
        [StringLength(50)]
        public string CodDocumentosLinha { get; set; }
        [StringLength(150)]
        public string Designacao { get; set; }

        [ForeignKey("EstadoId")]
        [InverseProperty("DocumentosLinha")]
        public virtual Estado Estado { get; set; }
        [InverseProperty("DocumentoLinha")]
        public virtual ICollection<DocumentosNecessarioPorLinha> DocumentosNecessarioPorLinha { get; set; }
    }
}
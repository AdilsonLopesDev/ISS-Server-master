﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class Cursos
    {
        public Cursos()
        {
            FaculdadeCurso = new HashSet<FaculdadeCurso>();
        }

        [StringLength(50)]
        public string IdCurso { get; set; }
        [StringLength(2048)]
        public string Designacao { get; set; }
        [StringLength(10)]
        public string CodCursos { get; set; }
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

        [ForeignKey("EstadoId")]
        [InverseProperty("Cursos")]
        public virtual Estado Estado { get; set; }
        [InverseProperty("Curso")]
        public virtual ICollection<FaculdadeCurso> FaculdadeCurso { get; set; }
    }
}
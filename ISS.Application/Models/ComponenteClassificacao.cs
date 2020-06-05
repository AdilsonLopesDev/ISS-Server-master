﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class ComponenteClassificacao
    {
        [Key]
        [StringLength(50)]
        public string IdComponenteClassificacao { get; set; }
        [StringLength(50)]
        public string ClassificacaoId { get; set; }
        [StringLength(50)]
        public string ComponenteId { get; set; }

        [ForeignKey("ClassificacaoId")]
        [InverseProperty("ComponenteClassificacaoClassificacao")]
        public virtual Classificacao Classificacao { get; set; }
        [ForeignKey("ComponenteId")]
        [InverseProperty("ComponenteClassificacaoComponente")]
        public virtual Classificacao Componente { get; set; }
    }
}
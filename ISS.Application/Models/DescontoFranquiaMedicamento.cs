﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class DescontoFranquiaMedicamento
    {
        [StringLength(50)]
        public string IdDescontoFranquia { get; set; }
        public double? ValorFranquia { get; set; }
        public double? ValorDesconto { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataActualizacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [StringLength(50)]
        public string TipoFranquiaId { get; set; }
        [StringLength(50)]
        public string TipoLevantamentoMedicamentoId { get; set; }
        [StringLength(50)]
        public string EstadoId { get; set; }
        [Column("CategoriaFranquiaID")]
        [StringLength(50)]
        public string CategoriaFranquiaId { get; set; }

        [ForeignKey("EstadoId")]
        [InverseProperty("DescontoFranquiaMedicamento")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("TipoFranquiaId")]
        [InverseProperty("DescontoFranquiaMedicamento")]
        public virtual TipoFranquia TipoFranquia { get; set; }
        [ForeignKey("TipoLevantamentoMedicamentoId")]
        [InverseProperty("DescontoFranquiaMedicamento")]
        public virtual TipoLevantamentoMedicamento TipoLevantamentoMedicamento { get; set; }
    }
}
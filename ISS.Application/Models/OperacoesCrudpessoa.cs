﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    [Table("OperacoesCRUDPessoa")]
    public partial class OperacoesCrudpessoa
    {
        [Column("IdOperacoesCRUDPessoa")]
        [StringLength(50)]
        public string IdOperacoesCrudpessoa { get; set; }
        [Column("ModuloCoreID")]
        [StringLength(50)]
        public string ModuloCoreId { get; set; }
        [Column("DireccaoID")]
        [StringLength(50)]
        public string DireccaoId { get; set; }
        [Column("DepartamentoID")]
        [StringLength(50)]
        public string DepartamentoId { get; set; }
        [StringLength(50)]
        public string SectorId { get; set; }
        [StringLength(50)]
        public string SeccaoId { get; set; }
        [Column("AreaID")]
        [StringLength(50)]
        public string AreaId { get; set; }
        [Column("FuncaoID")]
        [StringLength(50)]
        public string FuncaoId { get; set; }
        [Column("CargoFuncionarioID")]
        [StringLength(50)]
        public string CargoFuncionarioId { get; set; }
        [Column("PapelID")]
        [StringLength(50)]
        public string PapelId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [StringLength(50)]
        public string EstadoId { get; set; }
        [Column("OperacoesCrudID")]
        [StringLength(50)]
        public string OperacoesCrudId { get; set; }

        [ForeignKey("AreaId")]
        [InverseProperty("OperacoesCrudpessoa")]
        public virtual Area Area { get; set; }
        [ForeignKey("DepartamentoId")]
        [InverseProperty("OperacoesCrudpessoa")]
        public virtual Departamento Departamento { get; set; }
        [ForeignKey("DireccaoId")]
        [InverseProperty("OperacoesCrudpessoa")]
        public virtual Direccao Direccao { get; set; }
        [ForeignKey("EstadoId")]
        [InverseProperty("OperacoesCrudpessoa")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("FuncaoId")]
        [InverseProperty("OperacoesCrudpessoa")]
        public virtual Funcao Funcao { get; set; }
        [ForeignKey("ModuloCoreId")]
        [InverseProperty("OperacoesCrudpessoa")]
        public virtual ModuloCore ModuloCore { get; set; }
        [ForeignKey("OperacoesCrudId")]
        [InverseProperty("OperacoesCrudpessoa")]
        public virtual OperacoesCrud OperacoesCrud { get; set; }
        [ForeignKey("PapelId")]
        [InverseProperty("OperacoesCrudpessoa")]
        public virtual Papel Papel { get; set; }
        [ForeignKey("SeccaoId")]
        [InverseProperty("OperacoesCrudpessoa")]
        public virtual Seccao Seccao { get; set; }
        [ForeignKey("SectorId")]
        [InverseProperty("OperacoesCrudpessoa")]
        public virtual Sector Sector { get; set; }
    }
}
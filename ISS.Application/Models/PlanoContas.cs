﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class PlanoContas
    {
        public PlanoContas()
        {
            Area = new HashSet<Area>();
            Canal = new HashSet<Canal>();
            CentroCusto = new HashSet<CentroCusto>();
            CentroResponsabilidade = new HashSet<CentroResponsabilidade>();
            ClassificacaoCaixa = new HashSet<ClassificacaoCaixa>();
            Cliente = new HashSet<Cliente>();
            Cobertura = new HashSet<Cobertura>();
            Comite = new HashSet<Comite>();
            ContaFinanceira = new HashSet<ContaFinanceira>();
            ContratoPrestadorEmpresa = new HashSet<ContratoPrestadorEmpresa>();
            Departamento = new HashSet<Departamento>();
            Direccao = new HashSet<Direccao>();
            InverseSubClasseConta = new HashSet<PlanoContas>();
            LinhaProduto = new HashSet<LinhaProduto>();
            Mapa = new HashSet<Mapa>();
            Moeda = new HashSet<Moeda>();
            Movimento = new HashSet<Movimento>();
            Operacao = new HashSet<Operacao>();
            OperacoesPagamento = new HashSet<OperacoesPagamento>();
            Papel = new HashSet<Papel>();
            Perda = new HashSet<Perda>();
            PlanoComissionamentoProdutor = new HashSet<PlanoComissionamentoProdutor>();
            PlanoProduto = new HashSet<PlanoProduto>();
            PortfolioProduto = new HashSet<PortfolioProduto>();
            Premios = new HashSet<Premios>();
            Produto = new HashSet<Produto>();
            Seccao = new HashSet<Seccao>();
            Sector = new HashSet<Sector>();
            SegmentoProduto = new HashSet<SegmentoProduto>();
            Tarifa = new HashSet<Tarifa>();
            TarifasAutomovel = new HashSet<TarifasAutomovel>();
            TarifasDanosProprios = new HashSet<TarifasDanosProprios>();
            TarifasPremioAutoAcidentesTrabalho = new HashSet<TarifasPremioAutoAcidentesTrabalho>();
            TarifasPremioAutoAt2 = new HashSet<TarifasPremioAutoAt2>();
            TarifasResponsabilidadeCivil = new HashSet<TarifasResponsabilidadeCivil>();
            TipoComissao = new HashSet<TipoComissao>();
            TipoConta = new HashSet<TipoConta>();
            TipoOperacaoSubContaCredito = new HashSet<TipoOperacao>();
            TipoOperacaoSubContaDebito = new HashSet<TipoOperacao>();
        }

        [StringLength(50)]
        public string IdSubClasse { get; set; }
        [Required]
        [StringLength(50)]
        public string NumSubClasse { get; set; }
        [StringLength(2048)]
        public string Designacao { get; set; }
        [Column("SubClasseContaID")]
        [StringLength(50)]
        public string SubClasseContaId { get; set; }
        [Column("ClasseID")]
        [StringLength(50)]
        public string ClasseId { get; set; }
        [Column("ClassificacaoContaID")]
        [StringLength(50)]
        public string ClassificacaoContaId { get; set; }
        [Column("TipoClasseContaID")]
        [StringLength(50)]
        public string TipoClasseContaId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        public int? Grau { get; set; }
        [Column("EstadoID")]
        [StringLength(50)]
        public string EstadoId { get; set; }
        public double? Saldo { get; set; }
        public double? ValorDebitoAnterior { get; set; }
        public double? ValorCreditoAnterior { get; set; }
        public double? SaldoAnterior { get; set; }
        [StringLength(4000)]
        public string ConceitoConta { get; set; }
        public double? Valor { get; set; }
        [StringLength(50)]
        public string Conta { get; set; }
        [StringLength(50)]
        public string Risco { get; set; }
        [StringLength(50)]
        public string Auxiliar { get; set; }
        [StringLength(50)]
        public string CodPlanoContas { get; set; }

        [ForeignKey("ClasseId")]
        [InverseProperty("PlanoContas")]
        public virtual ClasseConta Classe { get; set; }
        [ForeignKey("ClassificacaoContaId")]
        [InverseProperty("PlanoContas")]
        public virtual ClassificacaoConta ClassificacaoConta { get; set; }
        [ForeignKey("EstadoId")]
        [InverseProperty("PlanoContas")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("SubClasseContaId")]
        [InverseProperty("InverseSubClasseConta")]
        public virtual PlanoContas SubClasseConta { get; set; }
        [ForeignKey("TipoClasseContaId")]
        [InverseProperty("PlanoContas")]
        public virtual TipoClasseConta TipoClasseConta { get; set; }
        [InverseProperty("SubConta")]
        public virtual ICollection<Area> Area { get; set; }
        [InverseProperty("SubConta")]
        public virtual ICollection<Canal> Canal { get; set; }
        [InverseProperty("SubConta")]
        public virtual ICollection<CentroCusto> CentroCusto { get; set; }
        [InverseProperty("SubConta")]
        public virtual ICollection<CentroResponsabilidade> CentroResponsabilidade { get; set; }
        [InverseProperty("SubConta")]
        public virtual ICollection<ClassificacaoCaixa> ClassificacaoCaixa { get; set; }
        [InverseProperty("SubClasse")]
        public virtual ICollection<Cliente> Cliente { get; set; }
        [InverseProperty("SubConta")]
        public virtual ICollection<Cobertura> Cobertura { get; set; }
        [InverseProperty("SubConta")]
        public virtual ICollection<Comite> Comite { get; set; }
        [InverseProperty("SubContaContabilistica")]
        public virtual ICollection<ContaFinanceira> ContaFinanceira { get; set; }
        [InverseProperty("ContaContabilisticaNavigation")]
        public virtual ICollection<ContratoPrestadorEmpresa> ContratoPrestadorEmpresa { get; set; }
        [InverseProperty("SubConta")]
        public virtual ICollection<Departamento> Departamento { get; set; }
        [InverseProperty("SubConta")]
        public virtual ICollection<Direccao> Direccao { get; set; }
        [InverseProperty("SubClasseConta")]
        public virtual ICollection<PlanoContas> InverseSubClasseConta { get; set; }
        [InverseProperty("SubConta")]
        public virtual ICollection<LinhaProduto> LinhaProduto { get; set; }
        [InverseProperty("Conta")]
        public virtual ICollection<Mapa> Mapa { get; set; }
        [InverseProperty("SubConta")]
        public virtual ICollection<Moeda> Moeda { get; set; }
        public virtual ICollection<Movimento> Movimento { get; set; }
        [InverseProperty("SubConta")]
        public virtual ICollection<Operacao> Operacao { get; set; }
        [InverseProperty("Conta")]
        public virtual ICollection<OperacoesPagamento> OperacoesPagamento { get; set; }
        [InverseProperty("SubConta")]
        public virtual ICollection<Papel> Papel { get; set; }
        [InverseProperty("SubConta")]
        public virtual ICollection<Perda> Perda { get; set; }
        [InverseProperty("PlanoContas")]
        public virtual ICollection<PlanoComissionamentoProdutor> PlanoComissionamentoProdutor { get; set; }
        [InverseProperty("SubConta")]
        public virtual ICollection<PlanoProduto> PlanoProduto { get; set; }
        [InverseProperty("SubConta")]
        public virtual ICollection<PortfolioProduto> PortfolioProduto { get; set; }
        [InverseProperty("SubConta")]
        public virtual ICollection<Premios> Premios { get; set; }
        [InverseProperty("SubConta")]
        public virtual ICollection<Produto> Produto { get; set; }
        [InverseProperty("SubConta")]
        public virtual ICollection<Seccao> Seccao { get; set; }
        [InverseProperty("SubConta")]
        public virtual ICollection<Sector> Sector { get; set; }
        [InverseProperty("SubConta")]
        public virtual ICollection<SegmentoProduto> SegmentoProduto { get; set; }
        [InverseProperty("SubConta")]
        public virtual ICollection<Tarifa> Tarifa { get; set; }
        [InverseProperty("SubConta")]
        public virtual ICollection<TarifasAutomovel> TarifasAutomovel { get; set; }
        [InverseProperty("SubConta")]
        public virtual ICollection<TarifasDanosProprios> TarifasDanosProprios { get; set; }
        [InverseProperty("SubConta")]
        public virtual ICollection<TarifasPremioAutoAcidentesTrabalho> TarifasPremioAutoAcidentesTrabalho { get; set; }
        [InverseProperty("SubConta")]
        public virtual ICollection<TarifasPremioAutoAt2> TarifasPremioAutoAt2 { get; set; }
        [InverseProperty("SubConta")]
        public virtual ICollection<TarifasResponsabilidadeCivil> TarifasResponsabilidadeCivil { get; set; }
        [InverseProperty("SubConta")]
        public virtual ICollection<TipoComissao> TipoComissao { get; set; }
        [InverseProperty("SubConta")]
        public virtual ICollection<TipoConta> TipoConta { get; set; }
        [InverseProperty("SubContaCredito")]
        public virtual ICollection<TipoOperacao> TipoOperacaoSubContaCredito { get; set; }
        [InverseProperty("SubContaDebito")]
        public virtual ICollection<TipoOperacao> TipoOperacaoSubContaDebito { get; set; }
    }
}
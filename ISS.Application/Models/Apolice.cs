﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISS.Application.Models
{
    public partial class Apolice
    {
        public Apolice()
        {
            AgravamentoApolice = new HashSet<AgravamentoApolice>();
            Automovel = new HashSet<Automovel>();
            Beneficiario = new HashSet<Beneficiario>();
            BoletimAdesaoSaude = new HashSet<BoletimAdesaoSaude>();
            CoPagamento = new HashSet<CoPagamento>();
            CoSeguro = new HashSet<CoSeguro>();
            Cobrador = new HashSet<Cobrador>();
            Comissao = new HashSet<Comissao>();
            ComissaoSelecionada = new HashSet<ComissaoSelecionada>();
            CondicoesApolice = new HashSet<CondicoesApolice>();
            Construcao = new HashSet<Construcao>();
            ConsumoPlafond = new HashSet<ConsumoPlafond>();
            ContaFinanceiraNavigation = new HashSet<ContaFinanceira>();
            CotacaoDependente = new HashSet<CotacaoDependente>();
            DescontoSeleccionado = new HashSet<DescontoSeleccionado>();
            DespesaSeleccionada = new HashSet<DespesaSeleccionada>();
            DiasContagem = new HashSet<DiasContagem>();
            DocumentoMembroAssegurado = new HashSet<DocumentoMembroAssegurado>();
            DocumentosAnexosApolice = new HashSet<DocumentosAnexosApolice>();
            Fornecedor = new HashSet<Fornecedor>();
            FranquiaSeleccionado = new HashSet<FranquiaSeleccionado>();
            GarantiasContratadas = new HashSet<GarantiasContratadas>();
            Instalacoes = new HashSet<Instalacoes>();
            Justificacao = new HashSet<Justificacao>();
            MargemVendaSeleccionado = new HashSet<MargemVendaSeleccionado>();
            MembroAssegurado = new HashSet<MembroAssegurado>();
            Paciente = new HashSet<Paciente>();
            Prestador = new HashSet<Prestador>();
            Recibo = new HashSet<Recibo>();
            Reclamacao = new HashSet<Reclamacao>();
            ReembolsoDespesasMedicas = new HashSet<ReembolsoDespesasMedicas>();
            ReivindicacoesFeitasApolice = new HashSet<ReivindicacoesFeitasApolice>();
            RenovacaoApolice = new HashSet<RenovacaoApolice>();
            ReservasTecnicas = new HashSet<ReservasTecnicas>();
            Segurado = new HashSet<Segurado>();
            Sinistro = new HashSet<Sinistro>();
            TermoResponsabilidade = new HashSet<TermoResponsabilidade>();
            Testemunha = new HashSet<Testemunha>();
            TomadorNavigation = new HashSet<Tomador>();
        }

        [StringLength(50)]
        public string IdApolice { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataEmissao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataInicio { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataExpiracao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataRenovacao { get; set; }
        [Column("BalcaoID")]
        [StringLength(50)]
        public string BalcaoId { get; set; }
        public bool? AssinaturaProponente { get; set; }
        public bool? ApoliceCoAssegurada { get; set; }
        public bool? AssinadaLocalPagamento { get; set; }
        public bool? ApoliceTransferida { get; set; }
        [Column("EstadoID")]
        [StringLength(50)]
        public string EstadoId { get; set; }
        [Column("CanalID")]
        [StringLength(50)]
        public string CanalId { get; set; }
        [StringLength(300)]
        public string CaminhoFicheiro { get; set; }
        [StringLength(100)]
        public string RefApolice { get; set; }
        [Column("ProdutorID")]
        [StringLength(50)]
        public string ProdutorId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCriacao { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAtualizacao { get; set; }
        [Column("UltModificacaoPorID")]
        [StringLength(50)]
        public string UltModificacaoPorId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataCancelamento { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataEstorno { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DataAnulacao { get; set; }
        [StringLength(50)]
        public string SeguradoraId { get; set; }
        [StringLength(50)]
        public string CodApolice { get; set; }
        [StringLength(50)]
        public string CentroCustoId { get; set; }
        [StringLength(50)]
        public string ClienteId { get; set; }
        [StringLength(500)]
        public string Ambito { get; set; }
        [StringLength(50)]
        public string ContaFinanceiraId { get; set; }
        [StringLength(50)]
        public string OperacoesPagamentoId { get; set; }
        [StringLength(50)]
        public string PlanoProdutoId { get; set; }
        [StringLength(50)]
        public string ModalidadeSeguroId { get; set; }
        [StringLength(50)]
        public string TipoaApoliceId { get; set; }
        public int NumOrdemApolice { get; set; }
        [StringLength(50)]
        public string TomadorId { get; set; }

        [ForeignKey("BalcaoId")]
        [InverseProperty("Apolice")]
        public virtual Balcao Balcao { get; set; }
        [ForeignKey("CanalId")]
        [InverseProperty("Apolice")]
        public virtual Canal Canal { get; set; }
        [ForeignKey("CentroCustoId")]
        [InverseProperty("Apolice")]
        public virtual CentroCusto CentroCusto { get; set; }
        [ForeignKey("ClienteId")]
        [InverseProperty("Apolice")]
        public virtual Cliente Cliente { get; set; }
        [ForeignKey("ContaFinanceiraId")]
        [InverseProperty("Apolice")]
        public virtual ContaFinanceira ContaFinanceira { get; set; }
        [ForeignKey("EstadoId")]
        [InverseProperty("Apolice")]
        public virtual Estado Estado { get; set; }
        [ForeignKey("OperacoesPagamentoId")]
        [InverseProperty("Apolice")]
        public virtual OperacoesPagamento OperacoesPagamento { get; set; }
        [ForeignKey("PlanoProdutoId")]
        [InverseProperty("Apolice")]
        public virtual PlanoProduto PlanoProduto { get; set; }
        [ForeignKey("ProdutorId")]
        [InverseProperty("ApoliceProdutor")]
        public virtual Pessoa Produtor { get; set; }
        [ForeignKey("SeguradoraId")]
        [InverseProperty("ApoliceSeguradora")]
        public virtual Pessoa Seguradora { get; set; }
        [ForeignKey("TipoaApoliceId")]
        [InverseProperty("Apolice")]
        public virtual TipoApolice TipoaApolice { get; set; }
        [ForeignKey("TomadorId")]
        [InverseProperty("ApoliceTomador")]
        public virtual Pessoa Tomador { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<AgravamentoApolice> AgravamentoApolice { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<Automovel> Automovel { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<Beneficiario> Beneficiario { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<BoletimAdesaoSaude> BoletimAdesaoSaude { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<CoPagamento> CoPagamento { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<CoSeguro> CoSeguro { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<Cobrador> Cobrador { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<Comissao> Comissao { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<ComissaoSelecionada> ComissaoSelecionada { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<CondicoesApolice> CondicoesApolice { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<Construcao> Construcao { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<ConsumoPlafond> ConsumoPlafond { get; set; }
        [InverseProperty("ApoliceNavigation")]
        public virtual ICollection<ContaFinanceira> ContaFinanceiraNavigation { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<CotacaoDependente> CotacaoDependente { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<DescontoSeleccionado> DescontoSeleccionado { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<DespesaSeleccionada> DespesaSeleccionada { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<DiasContagem> DiasContagem { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<DocumentoMembroAssegurado> DocumentoMembroAssegurado { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<DocumentosAnexosApolice> DocumentosAnexosApolice { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<Fornecedor> Fornecedor { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<FranquiaSeleccionado> FranquiaSeleccionado { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<GarantiasContratadas> GarantiasContratadas { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<Instalacoes> Instalacoes { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<Justificacao> Justificacao { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<MargemVendaSeleccionado> MargemVendaSeleccionado { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<MembroAssegurado> MembroAssegurado { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<Paciente> Paciente { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<Prestador> Prestador { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<Recibo> Recibo { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<Reclamacao> Reclamacao { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<ReembolsoDespesasMedicas> ReembolsoDespesasMedicas { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<ReivindicacoesFeitasApolice> ReivindicacoesFeitasApolice { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<RenovacaoApolice> RenovacaoApolice { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<ReservasTecnicas> ReservasTecnicas { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<Segurado> Segurado { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<Sinistro> Sinistro { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<TermoResponsabilidade> TermoResponsabilidade { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<Testemunha> Testemunha { get; set; }
        [InverseProperty("Apolice")]
        public virtual ICollection<Tomador> TomadorNavigation { get; set; }
    }
}
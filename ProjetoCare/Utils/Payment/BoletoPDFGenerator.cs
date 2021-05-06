using BoletoNetCore;
using Microsoft.AspNetCore.Hosting;
using ProjetoCare.Utils.Service;
using ProjetoCare.Utils.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCare.Utils.Payment
{
	public class BoletoPDFGenerator
	{
		private IWebHostEnvironment en;

		public BoletoPDFGenerator(IWebHostEnvironment en)
		{
			this.en = en;
		}


		public async Task GerarBoletoPDF(UserInfoViewModel user, string codigo, double total)
		{
			var endereco = Correios.GetCEP(user.CEP);
			var meuBoleto = new Boletos();

			try
			{
				meuBoleto.Banco = Banco.Instancia(001);
				meuBoleto.Banco.Cedente = new Cedente();
				meuBoleto.Banco.Cedente.CPFCNPJ = "15.590.326/0001-93";
				meuBoleto.Banco.Cedente.Nome = "Projeto Care";
				meuBoleto.Banco.Cedente.Observacoes = "Necessita ser pago no prazo de 15 dias, até " + DateTime.Today.AddDays(15).ToString("dd/MM/yyyy");

				var conta = new ContaBancaria();
				conta.Agencia = "1234";
				conta.DigitoAgencia = "0";
				conta.OperacaoConta = null;
				conta.Conta = "12345";
				conta.DigitoConta = "0";
				conta.CarteiraPadrao = "17";

				conta.VariacaoCarteiraPadrao = "027";
				conta.TipoCarteiraPadrao = TipoCarteira.CarteiraCobrancaSimples;
				conta.TipoFormaCadastramento = TipoFormaCadastramento.ComRegistro;
				conta.TipoImpressaoBoleto = TipoImpressaoBoleto.Empresa;
				conta.TipoDocumento = TipoDocumento.Tradicional;

				var ender = new BoletoNetCore.Endereco();
				ender.LogradouroEndereco = "Av. de teste";
				ender.LogradouroNumero = "555";
				ender.LogradouroComplemento = "Rua fictícia";
				ender.Bairro = "Alfajor";
				ender.Cidade = "Diademas";
				ender.UF = "SP";
				ender.CEP = "9849384";

				meuBoleto.Banco.Cedente.Codigo = "1234567";
				meuBoleto.Banco.Cedente.CodigoDV = "6";
				meuBoleto.Banco.Cedente.CodigoTransmissao = "000000";
				meuBoleto.Banco.Cedente.ContaBancaria = conta;
				meuBoleto.Banco.Cedente.Endereco = ender;

				meuBoleto.Banco.FormataCedente();


				string I = "1";
				var Titulo = new Boleto(meuBoleto.Banco);

				Titulo.Sacado = new Sacado()
				{
					CPFCNPJ = "03861018250",
					Endereco = new BoletoNetCore.Endereco()
					{
						Bairro = endereco.Bairro,
						CEP = user.CEP,
						Cidade = endereco.Cidade,
						LogradouroComplemento = endereco.Complemento,
						LogradouroEndereco = "Rua de teste",
						LogradouroNumero = "569",
						UF = endereco.UF
					},
					Nome = $"{user.Nome}",
					Observacoes = "Pagar antes do dia " + DateTime.Today.AddDays(15).ToString("dd/MM/yyyy")
				};

				Titulo.CodigoOcorrencia = "01";
				Titulo.NumeroDocumento = I;
				Titulo.NumeroControleParticipante = "12";
				Titulo.NossoNumero = "123456" + I;
				Titulo.DataEmissao = DateTime.Now;
				Titulo.DataVencimento = DateTime.Now.AddDays(15);
				Titulo.ValorTitulo = Convert.ToDecimal(total);
				Titulo.Aceite = "N";
				Titulo.EspecieDocumento = TipoEspecieDocumento.DM;
				Titulo.DataDesconto = DateTime.Now.AddDays(15);



				var instrucoes = "Visite o site da loja para acompanhar o status da compra.";

				if (string.IsNullOrEmpty(Titulo.MensagemInstrucoesCaixa))
				{
					Titulo.MensagemInstrucoesCaixa = instrucoes;
				}
				else
				{
					Titulo.MensagemInstrucoesCaixa += Environment.NewLine + instrucoes;
				}

				Titulo.CodigoProtesto = TipoCodigoProtesto.NaoProtestar;
				Titulo.DiasProtesto = 0;
				Titulo.CodigoBaixaDevolucao = TipoCodigoBaixaDevolucao.NaoBaixarNaoDevolver;
				Titulo.DiasBaixaDevolucao = 0;
				Titulo.ValidarDados();
				meuBoleto.Add(Titulo);

				int numboletos = 0;
				var path = Path.Combine(en.WebRootPath, "pdf");
				var nwpath = Path.Combine(path, $"{codigo}.pdf");


				foreach (var linha in meuBoleto.ToList())
				{
					numboletos += 1;
					var novoBoleto = new BoletoBancario();
					novoBoleto.Boleto = linha;

					await File.WriteAllBytesAsync(nwpath, novoBoleto.MontaPDFAlternativo(false));
				}

			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}

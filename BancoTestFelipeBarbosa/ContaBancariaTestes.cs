using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BancoTestFelipeBarbosa
{
	[TestClass]
	public class ContaBancariaTestes
	{
		[TestMethod]
		public void Debito_ComValorValido_Atualizado()
		{
			//arranjo
			double saldoInicial = 11.99;
			double valorDebito = 4.55; //(Fez Um Saque)
			double saldoEsperado = 7.44; //(Este numero vai ser comparado com o da conta e deve diminuir não subir)

			BancoFelipeBarbosa.ContaBancaria conta = new BancoFelipeBarbosa.ContaBancaria("Moura 2ML1: ", saldoInicial);

			//debita
			conta.Debito(valorDebito);

			//assert
			double saldoAtual = conta.Saldo;
			Assert.AreEqual(saldoEsperado, saldoAtual, 0.001, "CONTA NÃO FOI DEBITADA CORRETAMENTE");
			{
			}
		}
	}
}

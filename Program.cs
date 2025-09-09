using OOP_bank_account.Models;

Console.WriteLine("start bank-account project: ");

ContaCorrente conta = new ContaCorrente(1293094, 1000);

conta.ExibirSaldo();
conta.Sacar(500);
conta.ExibirSaldo();
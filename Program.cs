using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Atendimento;
using bytebank_ATENDIMENTO.bytebank.Util;
using System.Collections;
using System.Security.Cryptography;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

#region Exemplos Arrays em C#
void TestaArrayDeContasCorrentes()
{
    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    listaDeContas.AdicionarContaCorrente(new ContaCorrente(874, "819237-A"));
    listaDeContas.AdicionarContaCorrente(new ContaCorrente(875, "328477-B"));
    listaDeContas.AdicionarContaCorrente(new ContaCorrente(876, "328477-C"));
    listaDeContas.AdicionarContaCorrente(new ContaCorrente(877, "328477-D"));
    listaDeContas.AdicionarContaCorrente(new ContaCorrente(878, "328477-E"));
    listaDeContas.AdicionarContaCorrente(new ContaCorrente(879, "328477-F"));

    //adicionar nova conta corrente 
    var contaDoAndre = new ContaCorrente(963, "123456-X");
    listaDeContas.AdicionarContaCorrente(contaDoAndre);
    listaDeContas.ExibeLista();
    Console.WriteLine("Lista após remover conta do André"); 
    listaDeContas.Remover(contaDoAndre);
    listaDeContas.ExibeLista();

    Console.WriteLine("Aqui temos os números das contas e das agências correspondentes");
    for (int i = 0; i < listaDeContas.Tamanho; i++)
    {
        ContaCorrente conta = listaDeContas[i];
        Console.WriteLine($"Indice [{i}] = {conta.Conta}/{conta.Numero_agencia}"); 
    }
}
TestaArrayDeContasCorrentes();
#endregion


List<ContaCorrente> _listaDeContas = new List<ContaCorrente>(){
    new ContaCorrente(95, "09893-X") {Saldo=100},
    new ContaCorrente(96, "09893-Y") {Saldo=200},
    new ContaCorrente(97, "09893-Z") {Saldo=60}
}; 

AtendimentoCliente(); 
void AtendimentoCliente()
{
    char opcao = '0'; 
    while(opcao != '6')
    {
        Console.Clear();
        Console.WriteLine("===============================");
        Console.WriteLine("===       Atendimento       ===");
        Console.WriteLine("===  1 - Cadastrar Conta      ===");
        Console.WriteLine("===  2 - Listar Contas        ===");
        Console.WriteLine("===  3 - Remover Conta        ===");
        Console.WriteLine("===  4 - Ordenar Contas       ===");
        Console.WriteLine("===  5 - Pesquisar Conta      ===");
        Console.WriteLine("===  6 - Sair do Sistema      ===");
        Console.WriteLine("===============================");
        Console.WriteLine("\n\n");
        Console.Write("Digite a opção desejada: ");

        // armazenar o que estiver na primeira opção que for digitada 
        // abacaxi = a 
        opcao = Console.ReadLine()[0];
        switch (opcao)
        {
            case '1':
                CadastrarConta();
                break;
            case '2':
                ListarContas();
                break;
            default:
                Console.WriteLine("Opcao não implementada.");
                break;
        }
}
    
void CadastrarConta()
    {
        // metodo para cadastrar contas
        Console.Clear();
        Console.WriteLine("===============================");
        Console.WriteLine("===   CADASTRO DE CONTAS    ===");
        Console.WriteLine("===============================");
        Console.WriteLine("\n");
        Console.WriteLine("=== Informe dados da conta ===");
        Console.Write("Número da conta: ");
        string numeroConta = Console.ReadLine();

        Console.Write("Número da Agência: ");
        int numeroAgencia = int.Parse(Console.ReadLine());

        ContaCorrente conta = new ContaCorrente(numeroAgencia, numeroConta);

        Console.Write("Informe o saldo inicial: ");
        conta.Saldo = double.Parse(Console.ReadLine());

        Console.Write("Infome nome do Titular: ");
        conta.Titular.Nome = Console.ReadLine();

        Console.Write("Infome CPF do Titular: ");
        conta.Titular.Cpf = Console.ReadLine();

        Console.Write("Infome Profissão do Titular: ");
        conta.Titular.Profissao = Console.ReadLine();

        _listaDeContas.Add(conta);
        Console.WriteLine("... Conta cadastrada com sucesso! ...");
        Console.ReadKey();
    }
  }

void ListarContas()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===     LISTA DE CONTAS     ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");

    if(_listaDeContas.Count<=0)
    {
        Console.WriteLine("...Não há contas cadastradas! ...");
        Console.ReadKey();
        return; 
    }
    foreach(ContaCorrente item in _listaDeContas)
    {
        Console.WriteLine("===  Dados da Conta  ===");
        Console.WriteLine("Número da Conta : " + item.Conta);
        Console.WriteLine("Saldo da Conta : " + item.Saldo);
        Console.WriteLine("Titular da Conta: " + item.Titular.Nome);
        Console.WriteLine("CPF do Titular  : " + item.Titular.Cpf);
        Console.WriteLine("Profissão do Titular: " + item.Titular.Profissao);
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.ReadKey();
    }
}

Generica<int> teste1 = new Generica<int>();
teste1.MostrarMensagem(10);

Generica<string> teste2 = new Generica<string>();
teste2.MostrarMensagem("Olá mundo");
public class Generica<T>
{
    public void MostrarMensagem(T t)
    {
        Console.WriteLine($"Exibindo {t}"); 
    }
}
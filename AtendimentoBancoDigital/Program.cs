


using AtendimentoBancoDigital.banco.Modelos.Conta;
using AtendimentoBancoDigital.bytebank.Util;

void TestaArrayInt()
{
    int[] idades = new int[5];
    int acumulador;
    for (int i = 0; i < idades.Length; i++)
    {
        idades[i] = i;
        Console.WriteLine(idades[i]);
        acumulador = +i;

        Console.WriteLine($"O tamanho do Array é {idades.Length}");
        Console.WriteLine($"O a soma do Array é {acumulador}");
    }
}

void TestaArrayDeContaCorrente()
{
    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    listaDeContas.Adicionar(new ContaCorrente(874, "5679787-A"));
    listaDeContas.Adicionar(new ContaCorrente(874, "4456668-B"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
}
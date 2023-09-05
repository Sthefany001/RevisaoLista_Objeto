using Exemplo_Lista;
using System.Runtime.CompilerServices;

public class Program
{
    public static void Main(string[] args)
    {
        //ExemploLista1();

        ExemploListaObjetos();
    }

    static void ExemploLista1()
    {
        //string
        List<string> listaString = new List<string>();
        listaString.Add("Elias");//adicionar um elemento no final da lista 
        listaString.Add("Julia");
        listaString.Insert(1, "João");//adicionar um elemento em uma posição específica da lista
        listaString.Add("Ana Maria");

        //exemplo de remoção da lista
        //listaString.Remove("Julia");//remover um elemento passando o item que deseja remover
        //listaString.RemoveAt(2);//remover um elemento da lista pela posição
        //listaString.Clear();//limpar a lista

        listaString.Sort();//comando responsável por ordenar a lista

        //bool contem = listaString.Contains("Elias");//verificacao se tem um determinado item na lista ou não
        //Console.WriteLine(contem);

        List<String> listab = new List<string> { "Maria a", "Maria b" };
        listaString.AddRange(listab);//Adicionar toda a listab no final da listaString //juntar as duas listas  

        //O foreach percorre todos os elementos da lista, da primeira posição até a última
        //Para cada repetição, copia o endereço da posição atual da lista
        //ou seja, na primeira repetição a variável str recebe o valor da posição 0 da lista (Elias)
        //Na segunda repetição, str recebe o valor da posição 1 da lista (João)
        foreach (string str in listaString)
        {
            Console.WriteLine(str);
        }

        /*listaString.Count -> retorna o tamanho da lista
        for(int i = 0; i < listaString.Count; i++)//percorrer lista com for
        {
            Console.WriteLine(listaString[i]);
        }
        */

        Console.WriteLine(" ");//so pra deixar mais organizado 

        //int
        List<int> listaInt = new List<int>();
        listaInt.Add(1);
        listaInt.Add(3);
        listaInt.Insert(0, 4);//posição, numero

        //listaInt.Sort();
        /*List<int> lista2 = listaInt.OrderDescending().ToList();//organizando lista de forma decrescente
        foreach(int i in lista2)
        {
            Console.WriteLine(i);
        }*/

        foreach (int i in listaInt)//percorrer lista com foreach
        {
            Console.WriteLine(i);
        }

        //Iniciando lista com elementos
        List<double> listaDouble = new List<double> { 2.5, 3, 8.2 };
        listaDouble.Add(1);
    }

    static void ExemploListaObjetos()
    {
        List<Paciente> listaPacientes = new List<Paciente>();
        Paciente p1 = new Paciente(1, "ELIAS", "000", "elias.silva", new DateTime(1982, 07, 22));
        Paciente p2 = new Paciente(2, "Sthefany", "111", "sthefany.lorrany", new DateTime(2006, 09, 20));
        Paciente p3 = new Paciente(3, "Natália", "222", "natalia.pereira", new DateTime(2006, 05, 06));
        Paciente p4 = new Paciente(4, "Taynara", "333", "taynara.silva", new DateTime(2006, 08, 21));
        Paciente p5 = new Paciente(5, "Nathan", "444", "nathan.rocha", new DateTime(2007, 03, 13));
        //Paciente p6 = new Paciente();

        listaPacientes.Add(p1);
        listaPacientes.Add(p2);
        listaPacientes.Add(p3);
        listaPacientes.Add(p4);
        //listaPacientes.Add(p5);
        listaPacientes.Insert(0, p5);

        //O método orderBy ordena uma lista a partir de um determinado atributo
        //Esse método retorna uma lista ordenada (precisa armazenar esse resultado)
        //ToList() converte o resultado para uma lista
        //Caso queira apresentar a nova lista ordenada, somente percorre-lá
        //No exemplo, x.Nome especifica que irá ordernar pelo atributo nome
        //pode ser qualquer atributo do objeto
        List<Paciente> pOrdenado = listaPacientes.OrderBy(x => x.Nome).ToList();
        List<Paciente> pOrdenadoD = listaPacientes.OrderByDescending(x => x.Nome).ToList();//Decrescente

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Recupera determinado elemento que contem o valor passado na expressão.
        //No exemplo, recupera o paciente que contem o cpf 000.
        //Sem lógica
        //Paciente pCpf0 = listaPacientes.Single(x => x.Cpf == "000");//se ele nao encontrar oq vc procura dará erro -> Use SingleOrDefault ou TryCatch
        /*Com lógica
        foreach (Paciente P in pOrdenado)
        {
            if (P.Cpf == "000")
            {
                Paciente pCpf00 = P;
            }
        }*/
        //Console.WriteLine(pCpf0.Nome);

        /*Paciente pCpf0 = listaPacientes.Single(x => x.Cpf == "888");
        if (pCpf0 != null)
        {
            Console.WriteLine(pCpf0.Nome);
        }
        else
        {
            Console.WriteLine("Paciente não encontrado!");
        }*/

        //O método Where é utilizado para selecionar todos que atende alguma expressão
        //No exemplo abaixo, seleciona e armazena na lista busca todos os pacientes que possuem
        //o valor de Id_paciente maior que 2;
        Console.Write("Digite o nome para realizar a busca: ");
        string nomeBusca = Console.ReadLine();
        List<Paciente> busca = listaPacientes.Where(x => x.Nome.ToUpper() == nomeBusca.ToUpper()).ToList();
        
        //Buscar todos os nomes que inicia com determinada letra.
        List<Paciente> buscaL = listaPacientes.Where(x => x.Nome.ToUpper().StartsWith("E")).ToList();

        foreach (Paciente p in busca)//nao esqueça de mudar o nome da lista
        {
            Console.WriteLine($"{p.Nome} {p.Cpf} {p.Email}");
        }
    }
}

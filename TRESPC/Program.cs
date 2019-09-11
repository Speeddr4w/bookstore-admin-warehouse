using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRESPC
{
    class Program
    {

        static void Main(string[] args)
        {
            bool continua = true;
            List<Livros> listaLivros = new List<Livros>();
            do
            {
                Console.Clear();
                Menu();
                String opc = Console.ReadLine();
                switch (opc)
                {


                    // INCLUIR LIVROS
                    case "1":
                        listaLivros.Add(incluirLivro());
                        Console.Write("Inserção feita com sucesso, voltando ao menu");
                        System.Threading.Thread.Sleep(500);
                        Console.Write(" . ");
                        System.Threading.Thread.Sleep(1000);
                        Console.Write(" . ");
                        System.Threading.Thread.Sleep(1000);
                        Console.Write(" . ");
                        System.Threading.Thread.Sleep(1000);
                        break;

                    // ALTERAR LIVROS
                    case "2":
                        Console.Write("Indique o ID do livro a ser alterado: ");
                        int idAlterar = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Nome: {listaLivros[idAlterar].Nome}");
                        Console.WriteLine($"Preço: R${listaLivros[idAlterar].Preco.ToString("F")}");
                        Console.WriteLine($"Número de Páginas: {listaLivros[idAlterar].NumeroDePaginas}");
                        listaLivros[idAlterar] = alterarLivro();
                        Console.Write("Alteração feita com sucesso, voltando ao menu");
                        CounterToMenu();
                        break;

                    // EXCLUIR LIVROS
                    case "3":
                        Console.Write("Indique o ID do livro a ser excluido: ");
                        int idExcluir = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Nome: {listaLivros[idExcluir].Nome}");
                        Console.WriteLine($"Preço: R${listaLivros[idExcluir].Preco.ToString("F")}");
                        Console.WriteLine($"Número de Páginas: {listaLivros[idExcluir].NumeroDePaginas}");
                        bool continua2 = true;
                        do
                        {
                            Console.WriteLine("Prosseguir com a exclusão desse registro? S/N");
                            string x = Console.ReadLine();
                            if (x == "s" || x == "S")
                            {
                                listaLivros.RemoveAt(idExcluir);
                                continua2 = false;
                                Console.Write("Exclusão feita com sucesso, voltando ao menu");
                                CounterToMenu();
                            }
                            else if (x == "n" || x == "N")
                            {
                                Console.Write("Voltando ao menu");
                                CounterToMenu();
                                break;
                            }
                            else
                                Console.WriteLine("Comando Inválido");

                        } while (continua2);
                        break;

                    // LISTAR TODOS LIVROS
                    case "4":
                        int cont = 0;
                        foreach (Livros livros in listaLivros)
                        {

                            Console.WriteLine($"ID: {cont}, {listaLivros[cont].Nome}, " +
                                              $"R${listaLivros[cont].Preco.ToString("F")}, " +
                                              $"{listaLivros[cont].NumeroDePaginas} páginas");
                            cont++;
                        }
                        Console.WriteLine("Tecle algo para continuar");
                        Console.ReadKey();
                        break;

                    // PESQUISAR LIVROS
                    case "5":
                        Console.WriteLine("Pesquisar Livro - por qual campo deseja procurar seu livro?");
                        Console.WriteLine("1 - ID");
                        Console.WriteLine("2 - Nome");
                        Console.WriteLine("3 - Preço");
                        Console.WriteLine("4 - Número de Páginas");
                        Console.WriteLine("Digite a sua opção: ");
                        String opc2 = Console.ReadLine();
                        switch (opc2)
                        {
                            // PESQUISAR LIVROS POR ID
                            case "1":
                                Console.WriteLine("Digite o ID:");
                                int idProcurarLivros = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine($"Nome: {listaLivros[idProcurarLivros].Nome}");
                                Console.WriteLine($"Preço: R${listaLivros[idProcurarLivros].Preco.ToString("F")}");
                                Console.WriteLine($"Número de Páginas: {listaLivros[idProcurarLivros].NumeroDePaginas}");
                                Console.WriteLine("Tecle algo para continuar");
                                Console.ReadKey();
                                break;

                            // PESQUISAR LIVROS POR NOME
                            case "2":
                                Console.WriteLine("Digite o Nome:");
                                String nomeProcurarLivros = Console.ReadLine();

                                Livros aux1 = new Livros();

                                aux1 = listaLivros.Find(x => x.Nome == nomeProcurarLivros);
                                Console.WriteLine($"Nome: {aux1.Nome}");
                                Console.WriteLine($"Preço: R${aux1.Preco.ToString("F")}");
                                Console.WriteLine($"Número de Páginas: {aux1.NumeroDePaginas}");
                                Console.WriteLine("Tecle algo para continuar");
                                Console.ReadKey();

                                break;

                            // PESQUISAR LIVROS POR PRECO
                            case "3":
                                Console.WriteLine("Digite o Preço:");
                                double precoProcurarLivros = Convert.ToDouble(Console.ReadLine());

                                Livros aux2 = new Livros();

                                aux2 = listaLivros.Find(x => x.Preco == precoProcurarLivros);
                                Console.WriteLine($"Nome: {aux2.Nome}");
                                Console.WriteLine($"Preço: R${aux2.Preco.ToString("F")}");
                                Console.WriteLine($"Número de Páginas: {aux2.NumeroDePaginas}");
                                Console.WriteLine("Tecle algo para continuar");
                                Console.ReadKey();
                                break;

                            // PESQUISAR LIVROS POR NUMERO DE PAGINAS
                            case "4":
                                Console.WriteLine("Digite o Número de Páginas:");
                                int paginasProcurarLivros = Convert.ToInt32(Console.ReadLine());

                                Livros aux3 = new Livros();

                                aux3 = listaLivros.Find(x => x.NumeroDePaginas == paginasProcurarLivros);
                                Console.WriteLine($"Nome: {aux3.Nome}");
                                Console.WriteLine($"Preço: R${aux3.Preco.ToString("F")}");
                                Console.WriteLine($"Número de Páginas: {aux3.NumeroDePaginas}");
                                Console.WriteLine("Tecle algo para continuar");
                                Console.ReadKey();
                                break;

                            default:
                                Console.WriteLine("Comando Invalido");
                                break;
                        }
                        break;

                    case "9":
                        Console.Write("Saindo");
                        CounterToMenu();
                        continua = false;
                        break;

                    default:
                        Console.WriteLine("Comando Invalido");
                        break;
                }

            } while (continua);

        }

        private static Livros incluirLivro()
        {
            Livros livro = new Livros();

            Console.WriteLine("Cadastro de Livro");
            Console.Write("Nome: ");
            livro.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            livro.Preco = Convert.ToDouble(Console.ReadLine());
            Console.Write("Número de Páginas: ");
            livro.NumeroDePaginas = Convert.ToInt32(Console.ReadLine());

            return livro;
        }

        private static Livros alterarLivro()
        {
            Livros livro = new Livros();

            Console.WriteLine("Mudança do Cadastro do livro");
            Console.Write("Nome: ");
            livro.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            livro.Preco = Convert.ToDouble(Console.ReadLine());
            Console.Write("Número de Páginas: ");
            livro.NumeroDePaginas = Convert.ToInt32(Console.ReadLine());

            return livro;

        }


        private static void Menu()
        {
            Console.WriteLine("Livrarias Unibrasil - Área Administrativa");
            Console.WriteLine("1 - Incluir");
            Console.WriteLine("2 - Alterar");
            Console.WriteLine("3 - Excluir");
            Console.WriteLine("4 - Listar");
            Console.WriteLine("5 - Pesquisar");
            Console.WriteLine("9 - Sair");
            Console.WriteLine("Digite a sua opção: ");
        }
        private static void CounterToMenu()
        {
            System.Threading.Thread.Sleep(500);
            Console.Write(" . ");
            System.Threading.Thread.Sleep(1000);
            Console.Write(" . ");
            System.Threading.Thread.Sleep(1000);
            Console.Write(" . ");
            System.Threading.Thread.Sleep(1000);
        }
    }
}

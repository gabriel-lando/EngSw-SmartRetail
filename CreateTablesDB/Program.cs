using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTablesDB
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>

        [STAThread]
        static void Main()
        {
            SQLConnect sql = new SQLConnect();

            if (sql.CreateTables())
            {
                Console.Write("Tabelas adicionadas com sucesso...\n");
                if (sql.AddAdmin())
                {
                    Console.Write("Admin adicionado com sucesso...\n");
                }
                else
                {
                    Console.Write("ERRO ao adicionar o Admin...\n");
                }
            }
            else
            {
                Console.Write("ERRO ao adicionar as tabelas...\n");
            }

            Console.Write("\nPressione ENTER para sair... ");
            Console.Read();
        }
    }
}

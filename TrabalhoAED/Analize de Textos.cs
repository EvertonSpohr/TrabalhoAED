using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoAED.Analize;
using TrabalhoAED.Arqs;
using TrabalhoAED.Ordenação;

namespace TrabalhoAED
{
    public partial class Form1 : Form
    {

        public string Convert(string str)
        {
            byte[] utf8Bytes = Encoding.UTF8.GetBytes(str);
            str = Encoding.UTF8.GetString(utf8Bytes);
            return str;
        }

        public Form1()
        {
                        

            InitializeComponent();

            
            //Console.Out.WriteLine("Começou a poha lokaa");

            //Arquivos A = new Arquivos();
            //A.abrirArquivo("Teste.txt");
                       
            //Analizador.analizaLetras();
            //Console.Out.WriteLine("Analizou o texto");

            //ShellSort S = new ShellSort();

            //S.shellSort(Analizador.Vet_Texto.Length);

            //Console.Out.WriteLine("Ordenouu ");
                                    
            //Console.Out.WriteLine(" ========= \n");

            //Console.Out.WriteLine("Comp: "+ S.N_Comp + " Mov: " + S.N_Mov);

            ////imprimePosicao('a');
            

        }

        //public static void imprime(Object L)
        //{
        //    Thread.Sleep(20);
        //    int Le = Analizador.contaLetra((char)L);
        //    Console.Out.WriteLine("Numero de "+ L + ": " + Le);
        //}

        //public static void imprimePosicao(Object L)
        //{
        //    List<int> LI = Analizador.verificaPosicao((char)L);

        //    foreach (int A in LI) {
        //        Console.Out.Write(A + ", ");
        //    }


            
        //}
    }
}

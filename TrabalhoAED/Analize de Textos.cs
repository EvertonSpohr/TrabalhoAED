﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
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

            
            Console.Out.WriteLine("Começou a poha lokaa");

            Arquivos A = new Arquivos();
            A.abrirArquivo("Teste.txt");
                       
            Analizador.analizaLetras();
            Console.Out.WriteLine("Analizou o texto");

            Sort M = new Sort();

            M.shellsort(Analizador.Vet_Texto.Length - 1);

            Console.Out.WriteLine("Ordenouu ");
            Console.Out.WriteLine("Tamanho do vetor: " + Analizador.Vet_Texto.Length);

            foreach (char L in Analizador.Vet_Texto)
            {
                Console.Out.Write(L);
            }

        }
    }
}

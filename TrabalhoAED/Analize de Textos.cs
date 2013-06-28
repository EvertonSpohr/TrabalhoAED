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

        public Form1()
        {
            InitializeComponent();
            carregaCombox();

            button1.Visible = false;
            button2.Visible = false;      

        }

//CARREGA COMBOBOX COM OS ALGORITMOS DISPONIVEIS ============================================
        void carregaCombox() 
        {
            comboBox1.Items.Add("Bubble Sort");
            comboBox1.Items.Add("Heap Sort");
            comboBox1.Items.Add("Insertion Sort");
            comboBox1.Items.Add("K-Sort");
            comboBox1.Items.Add("Merge Sort");
            comboBox1.Items.Add("New Sort Middle Pivot");
            comboBox1.Items.Add("New Sort Left Pivot");
            comboBox1.Items.Add("Quick Sort");
            comboBox1.Items.Add("Selection Sort");
            comboBox1.Items.Add("Shaker Sort");
            comboBox1.Items.Add("Shell Sort");

        }

//MOSTRA A INFO DO ALGORITMO SELECIONADO ==================================================
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            button1.Visible = true;
            
            int A = comboBox1.SelectedIndex;

            switch (A)
            {
                case 0:
                    label2.Text = "Buble é uma merda";
                    break;
                case 1:
                    label2.Text = "heap fuma droga";
                    break;
                case 2:
                    label2.Text = "insertio o pau no cu";
                    break;
                case 3:
                    label2.Text = "k é o kácete";
                    break;
                case 4:
                    label2.Text = "merge = merda";
                    break;
                case 5:
                    label2.Text = "new sort a poha";
                    break;
                case 6:
                    label2.Text = "new sort a poha 2";
                    break;
                case 7:
                    label2.Text = "quick sai fora";
                    break;
                case 8:
                    label2.Text = "selectio é o caralho";
                    break;
                case 9:
                    label2.Text = "shaker só milk";
                    break;
                case 10:
                    label2.Text = "shell é posto poha";
                    break;                    
            }

        }

//BOTAO ABRIR AQUIVO ===============================================================================
        private void button1_Click(object sender, EventArgs e)
        {

            int NArq = (int)numericUpDown1.Value;            

            string[] Loc = new string[12];

            for (int i = 0; i < NArq; i++)
            {
                Console.Out.WriteLine("No for , valor de i: " + i);
                
                //if (openFileDialog1.ShowDialog() == DialogResult.OK)
                //{
                    openFileDialog1.ShowDialog();
                    Loc[i] = openFileDialog1.FileName;
                    
                //}
            }

            Arquivos.Local = Loc;
            button2.Visible = true;                   
            
        }

//BOTAO ANALIZAR ===========================================================================
        private void button2_Click(object sender, EventArgs e)
        {
            

            int Index = comboBox1.SelectedIndex;

            DateTime HoraIni, HoraFim;
            TimeSpan diff;

            int NArq = (int)numericUpDown1.Value;

            Val_Analize[] V_Anal = new Val_Analize[NArq];

            switch (Index)
            {
                case 0:
                    
                    for (int i = 0; i < NArq; i++)
                    {
                        Arquivos A = new Arquivos();
                        A.abrirArquivo(Arquivos.Local[i]);

                        Analizador.analizaLetras(Analizador.Lista_Vet[i]);

                        HoraIni = DateTime.Now;
                        BubbleSort B = new BubbleSort();
                        B.bubbleSort(Analizador.Tam, i);
                        HoraFim = DateTime.Now;
                        diff = HoraFim.Subtract(HoraIni);
                        // Obtém milissegundos

                        V_Anal[i] = new Val_Analize();

                        V_Anal[i].Tamanho = Analizador.Tam; // pega tamanho
                        V_Anal[i].N_Comp = B.N_Comp;
                        V_Anal[i].N_Mov = B.N_Mov;
                        V_Anal[i].Tempo = diff.TotalMilliseconds;                      
                        
                    }

                    for (int i = 0; i < 5; i++)
                    {
                        Console.Out.WriteLine( V_Anal[i].Tempo);
                    }

                        //label5.Text = B.N_Comp.ToString();
                        //label7.Text = B.N_Comp.ToString();

                        //String Vet = new String(Analizador.Vet_Texto);
                        //richTextBox1.Text = Vet;

                    break;
                
                //    case 1:
            //        HoraIni = DateTime.Now;
            //        HeapSort H = new HeapSort();
            //        H.heapSort(Analizador.Tam);
            //        HoraFim = DateTime.Now;
            //        diff = HoraFim.Subtract(HoraIni);
            //        // Obtém milissegundos
            //        label13.Text = diff.TotalMilliseconds.ToString();

            //        label5.Text = H.N_Comp.ToString();
            //        label7.Text = H.N_Comp.ToString();
            //        String Vet2 = new String(Analizador.Vet_Texto);
            //        richTextBox1.Text = Vet2;
            //        break;
            //    case 2:
            //        HoraIni = DateTime.Now;
            //        InsertionSort I = new InsertionSort();
            //        I.insertionSort(Analizador.Tam);
            //        HoraFim = DateTime.Now;
            //        diff = HoraFim.Subtract(HoraIni);
            //        // Obtém milissegundos
            //        label13.Text = diff.TotalMilliseconds.ToString();

            //        label5.Text = I.N_Comp.ToString();
            //        label7.Text = I.N_Comp.ToString();
            //        String Vet3 = new String(Analizador.Vet_Texto);
            //        richTextBox1.Text = Vet3;
            //        break;
            //    case 3:
            //        HoraIni = DateTime.Now;
            //        KSort K = new KSort();
            //        K.K_Sort(Analizador.Tam);
            //        HoraFim = DateTime.Now;
            //        diff = HoraFim.Subtract(HoraIni);
            //        // Obtém milissegundos
            //        label13.Text = diff.TotalMilliseconds.ToString();

            //        label5.Text = K.N_Comp.ToString();
            //        label7.Text = K.N_Comp.ToString();
            //        String Vet4 = new String(Analizador.Vet_Texto);
            //        richTextBox1.Text = Vet4;
            //        break;
            //    case 4:
            //        HoraIni = DateTime.Now;
            //        MergeSort M = new MergeSort();
            //        M.margeSort(Analizador.Tam);
            //        HoraFim = DateTime.Now;
            //        diff = HoraFim.Subtract(HoraIni);
            //        // Obtém milissegundos
            //        label13.Text = diff.TotalMilliseconds.ToString();

            //        label5.Text = M.N_Comp.ToString();
            //        label7.Text = M.N_Comp.ToString();
            //        String Vet5 = new String(Analizador.Vet_Texto);
            //        richTextBox1.Text = Vet5;
            //        break;
            //    case 5:
            //        HoraIni = DateTime.Now;
            //        NewSortMiddlePivot NM = new NewSortMiddlePivot();
            //        NM.newSortMiddlePivot(Analizador.Tam);
            //        HoraFim = DateTime.Now;
            //        diff = HoraFim.Subtract(HoraIni);
            //        // Obtém milissegundos
            //        label13.Text = diff.TotalMilliseconds.ToString();

            //        label5.Text = NM.N_Comp.ToString();
            //        label7.Text = NM.N_Comp.ToString();
            //        String Vet6 = new String(Analizador.Vet_Texto);
            //        richTextBox1.Text = Vet6;
            //        break;
            //    case 6:
            //        HoraIni = DateTime.Now;
            //        NewSortLeftPivot NL = new NewSortLeftPivot();
            //        NL.newSortLeftPivot(Analizador.Tam);
            //        HoraFim = DateTime.Now;
            //        diff = HoraFim.Subtract(HoraIni);
            //        // Obtém milissegundos
            //        label13.Text = diff.TotalMilliseconds.ToString();

            //        label5.Text = NL.N_Comp.ToString();
            //        label7.Text = NL.N_Comp.ToString();
            //        String Vet7 = new String(Analizador.Vet_Texto);
            //        richTextBox1.Text = Vet7;
            //        break;
            //    case 7:
            //        HoraIni = DateTime.Now;
            //        QuickSort Q = new QuickSort();
            //        Q.quickSort(Analizador.Tam);
            //        HoraFim = DateTime.Now;
            //        diff = HoraFim.Subtract(HoraIni);
            //        // Obtém milissegundos
            //        label13.Text = diff.TotalMilliseconds.ToString();

            //        label5.Text = Q.N_Comp.ToString();
            //        label7.Text = Q.N_Comp.ToString();
            //        String Vet8 = new String(Analizador.Vet_Texto);
            //        richTextBox1.Text = Vet8;
            //        break;
            //    case 8:
            //        HoraIni = DateTime.Now;
            //        SelectionSort SL = new SelectionSort();
            //        SL.selectionSort(Analizador.Tam);
            //        HoraFim = DateTime.Now;
            //        diff = HoraFim.Subtract(HoraIni);
            //        // Obtém milissegundos
            //        label13.Text = diff.TotalMilliseconds.ToString();

            //        label5.Text = SL.N_Comp.ToString();
            //        label7.Text = SL.N_Comp.ToString();
            //        String Vet9 = new String(Analizador.Vet_Texto);
            //        richTextBox1.Text = Vet9;
            //        break;
            //    case 9:
            //        HoraIni = DateTime.Now;
            //        ShakerSort SH = new ShakerSort();
            //        SH.shakerSort(Analizador.Tam);
            //        HoraFim = DateTime.Now;
            //        diff = HoraFim.Subtract(HoraIni);
            //        // Obtém milissegundos
            //        label13.Text = diff.TotalMilliseconds.ToString();

            //        label5.Text = SH.N_Comp.ToString();
            //        label7.Text = SH.N_Comp.ToString();
            //        String Vet10 = new String(Analizador.Vet_Texto);
            //        richTextBox1.Text = Vet10;
            //        break;
            //    case 10:
            //        HoraIni = DateTime.Now;
            //        ShellSort SS = new ShellSort();
            //        SS.shellSort(Analizador.Tam);
            //        HoraFim = DateTime.Now;
            //        diff = HoraFim.Subtract(HoraIni);
            //        // Obtém milissegundos
            //        label13.Text = diff.TotalMilliseconds.ToString();

            //        label5.Text = SS.N_Comp.ToString();
            //        label7.Text = SS.N_Comp.ToString();
            //        String Vet11 = new String(Analizador.Vet_Texto);
            //        richTextBox1.Text = Vet11;
            //        break;
            }

            label11.Text = Analizador.Tam.ToString();

        }

//ESCONDE E MOSTRA BARRA LATERAL ============================================================
        private void splitContainer1_Panel1_MouseEnter_1(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 280; //set the distance 
        }

        private void splitContainer1_Panel2_MouseEnter_1(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 1;
        }
//=========================================================================================

    }
}

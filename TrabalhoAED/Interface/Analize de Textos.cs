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
using TrabalhoAED.Interface;
using TrabalhoAED.Ordenação;

namespace TrabalhoAED
{
    public partial class Form1 : Form
    {        

//ATRIBUTOS ==================================================================================

        int NArq;

//METODOS ===================================================================================

        public Form1()
        {
            InitializeComponent();
            carregaCombox();

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

            

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
                    label2.Text = "Método muito ineficiente em relação ao número de movimentações e comparações";
                    break;
                case 1:
                    label2.Text = "Algoritmo muito bom";
                    break;
                case 2:
                    label2.Text = "Dempenho semelhante ao InsertionSort";
                    break;
                case 3:
                    label2.Text = "Melhor algoritmo em termos de comparação e movimentação";
                    break;
                case 4:
                    label2.Text = "Algoritmo Mediano";
                    break;
                case 5:
                    label2.Text = "Apresenta bons resultados";
                    break;
                case 6:
                    label2.Text = "Apresenta bons resultados";
                    break;
                case 7:
                    label2.Text = "Boa escolha, o algoritmo apresenta bons resultados";
                    break;
                case 8:
                    label2.Text = "Algoritmo mediano, apresenta resultado pouco melhor que o ShakerSort";
                    break;
                case 9:
                    label2.Text = "Método muito ineficiente em relação ao número de movimentações e comparações";
                    break;
                case 10:
                    label2.Text = "Algoritmo Mediano";
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

            NArq = (int)numericUpDown1.Value;

            Val_Analize[] V_Anal = new Val_Analize[NArq];

            Val_Analize V = new Val_Analize();
            Val_Analize V_DP = new Val_Analize();

            progressBar1.Value = 0;
            progressBar1.Maximum = NArq;

            Analizador.Lista_Vet.Clear(); //LIMPA A LISTA       

            switch (Index)
            {
                case 0:

                    for (int i = 0; i < NArq; i++)
                    {
                        Arquivos A = new Arquivos();
                        Analizador.Lista_Vet.Add(A.abrirArquivo(Arquivos.Local[i]));

                        Analizador.analizaLetras(Analizador.Lista_Vet[i]);

                        progressBar1.Value++;

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

                    V = Analizador.getMedia(V_Anal, NArq);    

                    label5.Text = V.N_Mov.ToString();
                    label7.Text = V.N_Comp.ToString();
                    label13.Text = V.Tempo.ToString();
                    label22.Text = V.Tamanho.ToString();

                    V_DP = Analizador.getDesvioPadrao(V_Anal, V, NArq);

                    label11.Text = V_DP.N_Mov.ToString();
                    label17.Text = V_DP.N_Comp.ToString();
                    label20.Text = V_DP.Tempo.ToString();
                    label24.Text = V_DP.Tamanho.ToString();
                       

                    break;

                case 1:

                    for (int i = 0; i < NArq; i++)
                    {
                        Arquivos A = new Arquivos();
                        Analizador.Lista_Vet.Add(A.abrirArquivo(Arquivos.Local[i]));

                        Analizador.analizaLetras(Analizador.Lista_Vet[i]);
                        
                        progressBar1.Value++;

                        HoraIni = DateTime.Now;
                        HoraIni = DateTime.Now;
                        HeapSort H = new HeapSort();
                        H.heapSort(Analizador.Tam, i);
                        HoraFim = DateTime.Now;
                        diff = HoraFim.Subtract(HoraIni);
                        // Obtém milissegundos

                        V_Anal[i] = new Val_Analize();

                        V_Anal[i].Tamanho = Analizador.Tam; // pega tamanho
                        V_Anal[i].N_Comp = H.N_Comp;
                        V_Anal[i].N_Mov = H.N_Mov;
                        V_Anal[i].Tempo = diff.TotalMilliseconds;
                    }

                    V = Analizador.getMedia(V_Anal, NArq);    

                    label5.Text = V.N_Mov.ToString();
                    label7.Text = V.N_Comp.ToString();
                    label13.Text = V.Tempo.ToString();
                    label22.Text = V.Tamanho.ToString();

                    V_DP = Analizador.getDesvioPadrao(V_Anal, V, NArq);

                    label11.Text = V_DP.N_Mov.ToString();
                    label17.Text = V_DP.N_Comp.ToString();
                    label20.Text = V_DP.Tempo.ToString();
                    label24.Text = V_DP.Tamanho.ToString();
                    
                    break;

                case 2:

                    for (int i = 0; i < NArq; i++)
                    {
                        Arquivos A = new Arquivos();
                        Analizador.Lista_Vet.Add(A.abrirArquivo(Arquivos.Local[i]));

                        Analizador.analizaLetras(Analizador.Lista_Vet[i]);

                        progressBar1.Value++;

                        HoraIni = DateTime.Now;
                        HoraIni = DateTime.Now;
                        InsertionSort I = new InsertionSort();
                        I.insertionSort(Analizador.Tam, i);
                        HoraFim = DateTime.Now;
                        diff = HoraFim.Subtract(HoraIni);
                        // Obtém milissegundos

                        V_Anal[i] = new Val_Analize();

                        V_Anal[i].Tamanho = Analizador.Tam; // pega tamanho
                        V_Anal[i].N_Comp = I.N_Comp;
                        V_Anal[i].N_Mov = I.N_Mov;
                        V_Anal[i].Tempo = diff.TotalMilliseconds;
                    }

                    V = Analizador.getMedia(V_Anal, NArq);    

                    label5.Text = V.N_Mov.ToString();
                    label7.Text = V.N_Comp.ToString();
                    label13.Text = V.Tempo.ToString();
                    label22.Text = V.Tamanho.ToString();

                    V_DP = Analizador.getDesvioPadrao(V_Anal, V, NArq);

                    label11.Text = V_DP.N_Mov.ToString();
                    label17.Text = V_DP.N_Comp.ToString();
                    label20.Text = V_DP.Tempo.ToString();
                    label24.Text = V_DP.Tamanho.ToString();
                    
                    break;
                case 3:

                    for (int i = 0; i < NArq; i++)
                    {
                        Arquivos A = new Arquivos();
                        Analizador.Lista_Vet.Add(A.abrirArquivo(Arquivos.Local[i]));

                        Analizador.analizaLetras(Analizador.Lista_Vet[i]);

                        progressBar1.Value++;

                        HoraIni = DateTime.Now;
                        HoraIni = DateTime.Now;
                        KSort K = new KSort();
                        K.K_Sort(Analizador.Tam, i);
                        HoraFim = DateTime.Now;
                        diff = HoraFim.Subtract(HoraIni);
                        // Obtém milissegundos

                        V_Anal[i] = new Val_Analize();

                        V_Anal[i].Tamanho = Analizador.Tam; // pega tamanho
                        V_Anal[i].N_Comp = K.N_Comp;
                        V_Anal[i].N_Mov = K.N_Mov;
                        V_Anal[i].Tempo = diff.TotalMilliseconds;

                    }

                    V = Analizador.getMedia(V_Anal, NArq);    

                    label5.Text = V.N_Mov.ToString();
                    label7.Text = V.N_Comp.ToString();
                    label13.Text = V.Tempo.ToString();
                    label22.Text = V.Tamanho.ToString();

                    V_DP = Analizador.getDesvioPadrao(V_Anal, V, NArq);

                    label11.Text = V_DP.N_Mov.ToString();
                    label17.Text = V_DP.N_Comp.ToString();
                    label20.Text = V_DP.Tempo.ToString();
                    label24.Text = V_DP.Tamanho.ToString();



                    break;

                case 4:

                   for (int i = 0; i < NArq; i++)
                    {
                        Arquivos A = new Arquivos();
                        Analizador.Lista_Vet.Add(A.abrirArquivo(Arquivos.Local[i]));

                        Analizador.analizaLetras(Analizador.Lista_Vet[i]);

                        progressBar1.Value++;

                        HoraIni = DateTime.Now;
                        HoraIni = DateTime.Now;
                        MergeSort M = new MergeSort(); 
                        M.margeSort(Analizador.Tam, i);
                        HoraFim = DateTime.Now;
                        diff = HoraFim.Subtract(HoraIni);
                        // Obtém milissegundos

                        V_Anal[i] = new Val_Analize();

                        V_Anal[i].Tamanho = Analizador.Tam; // pega tamanho
                        V_Anal[i].N_Comp = M.N_Comp;
                        V_Anal[i].N_Mov = M.N_Mov;
                        V_Anal[i].Tempo = diff.TotalMilliseconds;
                    }

                    V = Analizador.getMedia(V_Anal, NArq);    

                    label5.Text = V.N_Mov.ToString();
                    label7.Text = V.N_Comp.ToString();
                    label13.Text = V.Tempo.ToString();
                    label22.Text = V.Tamanho.ToString();

                    V_DP = Analizador.getDesvioPadrao(V_Anal, V, NArq);

                    label11.Text = V_DP.N_Mov.ToString();
                    label17.Text = V_DP.N_Comp.ToString();
                    label20.Text = V_DP.Tempo.ToString();
                    label24.Text = V_DP.Tamanho.ToString();

                    break;

                case 5:

                    for (int i = 0; i < NArq; i++)
                    {
                        Arquivos A = new Arquivos();
                        Analizador.Lista_Vet.Add(A.abrirArquivo(Arquivos.Local[i]));

                        Analizador.analizaLetras(Analizador.Lista_Vet[i]);

                        progressBar1.Value++;

                        HoraIni = DateTime.Now;
                        HoraIni = DateTime.Now;
                        NewSortMiddlePivot NS = new NewSortMiddlePivot();
                        NS.newSortMiddlePivot(Analizador.Tam, i);
                        HoraFim = DateTime.Now;
                        diff = HoraFim.Subtract(HoraIni);
                        // Obtém milissegundos

                        V_Anal[i] = new Val_Analize();

                        V_Anal[i].Tamanho = Analizador.Tam; // pega tamanho
                        V_Anal[i].N_Comp = NS.N_Comp;
                        V_Anal[i].N_Mov = NS.N_Mov;
                        V_Anal[i].Tempo = diff.TotalMilliseconds;
                    }

                    V = Analizador.getMedia(V_Anal, NArq);    

                    label5.Text = V.N_Mov.ToString();
                    label7.Text = V.N_Comp.ToString();
                    label13.Text = V.Tempo.ToString();
                    label22.Text = V.Tamanho.ToString();

                    V_DP = Analizador.getDesvioPadrao(V_Anal, V, NArq);

                    label11.Text = V_DP.N_Mov.ToString();
                    label17.Text = V_DP.N_Comp.ToString();
                    label20.Text = V_DP.Tempo.ToString();
                    label24.Text = V_DP.Tamanho.ToString();

                    break;

                case 6:

                    for (int i = 0; i < NArq; i++)
                    {
                        Arquivos A = new Arquivos();
                        Analizador.Lista_Vet.Add(A.abrirArquivo(Arquivos.Local[i]));

                        Analizador.analizaLetras(Analizador.Lista_Vet[i]);

                        progressBar1.Value++;

                        HoraIni = DateTime.Now;
                        HoraIni = DateTime.Now;
                        NewSortLeftPivot NL = new NewSortLeftPivot();
                        NL.newSortLeftPivot(Analizador.Tam, i);
                        HoraFim = DateTime.Now;
                        diff = HoraFim.Subtract(HoraIni);
                        // Obtém milissegundos

                        V_Anal[i] = new Val_Analize();

                        V_Anal[i].Tamanho = Analizador.Tam; // pega tamanho
                        V_Anal[i].N_Comp = NL.N_Comp;
                        V_Anal[i].N_Mov = NL.N_Mov;
                        V_Anal[i].Tempo = diff.TotalMilliseconds;
                    }

                    V = Analizador.getMedia(V_Anal, NArq);    

                    label5.Text = V.N_Mov.ToString();
                    label7.Text = V.N_Comp.ToString();
                    label13.Text = V.Tempo.ToString();
                    label22.Text = V.Tamanho.ToString();

                    V_DP = Analizador.getDesvioPadrao(V_Anal, V, NArq);

                    label11.Text = V_DP.N_Mov.ToString();
                    label17.Text = V_DP.N_Comp.ToString();
                    label20.Text = V_DP.Tempo.ToString();
                    label24.Text = V_DP.Tamanho.ToString();

                    break;

                case 7:

                    for (int i = 0; i < NArq; i++)
                    {
                        Arquivos A = new Arquivos();
                        Analizador.Lista_Vet.Add(A.abrirArquivo(Arquivos.Local[i]));

                        Analizador.analizaLetras(Analizador.Lista_Vet[i]);

                        progressBar1.Value++;

                        HoraIni = DateTime.Now;
                        HoraIni = DateTime.Now;
                        QuickSort Q = new QuickSort();
                        Q.quickSort(Analizador.Tam, i);
                        HoraFim = DateTime.Now;
                        diff = HoraFim.Subtract(HoraIni);
                        // Obtém milissegundos

                        V_Anal[i] = new Val_Analize();

                        V_Anal[i].Tamanho = Analizador.Tam; // pega tamanho
                        V_Anal[i].N_Comp = Q.N_Comp;
                        V_Anal[i].N_Mov = Q.N_Mov;
                        V_Anal[i].Tempo = diff.TotalMilliseconds;
                    }

                    V = Analizador.getMedia(V_Anal, NArq);    

                    label5.Text = V.N_Mov.ToString();
                    label7.Text = V.N_Comp.ToString();
                    label13.Text = V.Tempo.ToString();
                    label22.Text = V.Tamanho.ToString();

                    V_DP = Analizador.getDesvioPadrao(V_Anal, V, NArq);

                    label11.Text = V_DP.N_Mov.ToString();
                    label17.Text = V_DP.N_Comp.ToString();
                    label20.Text = V_DP.Tempo.ToString();
                    label24.Text = V_DP.Tamanho.ToString();

                    break;

                case 8:

                    for (int i = 0; i < NArq; i++)
                    {
                        Arquivos A = new Arquivos();
                        Analizador.Lista_Vet.Add(A.abrirArquivo(Arquivos.Local[i]));

                        Analizador.analizaLetras(Analizador.Lista_Vet[i]);

                        progressBar1.Value++;

                        HoraIni = DateTime.Now;
                        HoraIni = DateTime.Now;
                        SelectionSort SL = new SelectionSort();
                        SL.selectionSort(Analizador.Tam, i);
                        HoraFim = DateTime.Now;
                        diff = HoraFim.Subtract(HoraIni);
                        // Obtém milissegundos

                        V_Anal[i] = new Val_Analize();

                        V_Anal[i].Tamanho = Analizador.Tam; // pega tamanho
                        V_Anal[i].N_Comp = SL.N_Comp;
                        V_Anal[i].N_Mov = SL.N_Mov;
                        V_Anal[i].Tempo = diff.TotalMilliseconds;
                    }

                    V = Analizador.getMedia(V_Anal, NArq);    

                    label5.Text = V.N_Mov.ToString();
                    label7.Text = V.N_Comp.ToString();
                    label13.Text = V.Tempo.ToString();
                    label22.Text = V.Tamanho.ToString();

                    V_DP = Analizador.getDesvioPadrao(V_Anal, V, NArq);

                    label11.Text = V_DP.N_Mov.ToString();
                    label17.Text = V_DP.N_Comp.ToString();
                    label20.Text = V_DP.Tempo.ToString();
                    label24.Text = V_DP.Tamanho.ToString();

                    break;

                case 9:

                    for (int i = 0; i < NArq; i++)
                    {
                        Arquivos A = new Arquivos();
                        Analizador.Lista_Vet.Add(A.abrirArquivo(Arquivos.Local[i]));

                        Analizador.analizaLetras(Analizador.Lista_Vet[i]);

                        progressBar1.Value++;

                        HoraIni = DateTime.Now;
                        HoraIni = DateTime.Now;
                        ShakerSort SH = new ShakerSort();
                        SH.shakerSort(Analizador.Tam, i);
                        HoraFim = DateTime.Now;
                        diff = HoraFim.Subtract(HoraIni);
                        // Obtém milissegundos

                        V_Anal[i] = new Val_Analize();

                        V_Anal[i].Tamanho = Analizador.Tam; // pega tamanho
                        V_Anal[i].N_Comp = SH.N_Comp;
                        V_Anal[i].N_Mov = SH.N_Mov;
                        V_Anal[i].Tempo = diff.TotalMilliseconds;
                    }

                    V = Analizador.getMedia(V_Anal, NArq);    

                    label5.Text = V.N_Mov.ToString();
                    label7.Text = V.N_Comp.ToString();
                    label13.Text = V.Tempo.ToString();
                    label22.Text = V.Tamanho.ToString();

                    V_DP = Analizador.getDesvioPadrao(V_Anal, V, NArq);

                    label11.Text = V_DP.N_Mov.ToString();
                    label17.Text = V_DP.N_Comp.ToString();
                    label20.Text = V_DP.Tempo.ToString();
                    label24.Text = V_DP.Tamanho.ToString();

                    break;

                case 10:

                    for (int i = 0; i < NArq; i++)
                    {
                        Arquivos A = new Arquivos();
                        Analizador.Lista_Vet.Add(A.abrirArquivo(Arquivos.Local[i]));

                        Analizador.analizaLetras(Analizador.Lista_Vet[i]);

                        progressBar1.Value++;

                        HoraIni = DateTime.Now;
                        HoraIni = DateTime.Now;
                        ShellSort SS = new ShellSort();
                        SS.shellSort(Analizador.Tam, i);
                        HoraFim = DateTime.Now;
                        diff = HoraFim.Subtract(HoraIni);
                        // Obtém milissegundos

                        V_Anal[i] = new Val_Analize();

                        V_Anal[i].Tamanho = Analizador.Tam; // pega tamanho
                        V_Anal[i].N_Comp = SS.N_Comp;
                        V_Anal[i].N_Mov = SS.N_Mov;
                        V_Anal[i].Tempo = diff.TotalMilliseconds;
                    }

                    V = Analizador.getMedia(V_Anal, NArq);    

                    label5.Text = V.N_Mov.ToString();
                    label7.Text = V.N_Comp.ToString();
                    label13.Text = V.Tempo.ToString();
                    label22.Text = V.Tamanho.ToString();

                    V_DP = Analizador.getDesvioPadrao(V_Anal, V, NArq);

                    label11.Text = V_DP.N_Mov.ToString();
                    label17.Text = V_DP.N_Comp.ToString();
                    label20.Text = V_DP.Tempo.ToString();
                    label24.Text = V_DP.Tamanho.ToString();
                    
                    break;
            }

            button3.Visible = true;
            button4.Visible = true;


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

//BOTAO ESPAÇAMENTO ==========================================================================
        private void button3_Click(object sender, EventArgs e)
        {
            Espacamento E = new Espacamento(NArq);
            E.Show();
        }

//BOTAO SEQUENCIA ============================================================================
        private void button4_Click(object sender, EventArgs e)
        {
            Frequencia F = new Frequencia(NArq);
            F.Show();
        }
//=========================================================================================

    }
}

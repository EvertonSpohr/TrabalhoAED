using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoAED.Analize;
using TrabalhoAED.Arqs;

namespace TrabalhoAED.Interface
{
    public partial class Espacamento : Form
    {
//ATRIBUTOS ======================================================================

        int NArq;

//METODOS =======================================================================

        public Espacamento(int N)
        {
            NArq = N;
            InitializeComponent();
            carregaCombox();
        }

//CARREGA COMBOBOX ==============================================================
        void carregaCombox()
        {

            for (int i = 1; i <= NArq; i++)
            {
                comboBox1.Items.Add("Arquivo " + i.ToString());
            }
        }

//FAZ TODA A PUTARIA ===================================================================
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //PARTE DO ESPAÇAMENTO ===========================================================================================================    
        
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            int Index = comboBox1.SelectedIndex;
            

            Arquivos A = new Arquivos();
            char[] Vet =  A.abrirArquivo(Arquivos.Local[Index]);



            Analizador.analizaLetras(Vet);
            //--------------------------------------------------------

            String Separator = "__________________________________________________________________________________________________________________";

            listBox1.Items.Add("CARACTER  -  ESPAÇAMENTO ENTRE OS CARACTERES ");
            listBox2.Items.Add("CARACTER     -      MÉDIA      -      DESVIO PADRÃO");
            listBox1.Items.Add(Separator);
            listBox2.Items.Add(Separator);
            
            for (int i = 32; i <= 64; i++)
            {
                                              

                char C = (char)i;
                List<int> Esp = Analizador.verificaPosicao(C, Vet);

                String TexEsp = " ";

                if (Esp.Count == 0)
                {
                    TexEsp = " O texto não possui este caracter! ";
                }
                else
                {
                    foreach (int B in Esp)
                    {
                        TexEsp += B.ToString() + ", ";
                    }
                }



                if (i == 32)
                {
                    int Media = Analizador.getMediaCaracter(Esp, Esp.Count);
                    int DesvP = Analizador.getDesvioPadraoCaracter(Esp, Media, Esp.Count);

                    String Text = " Space   - " + TexEsp;
                    listBox1.Items.Add(Separator);
                    listBox1.Items.Add(Text);

                    String Text2 = " Space            -                   " + Media + "              -               " + DesvP;
                    listBox2.Items.Add(Separator);
                    listBox2.Items.Add(Text2);

                }
                else
                {
                    int Media = Analizador.getMediaCaracter(Esp, Esp.Count);
                    int DesvP = Analizador.getDesvioPadraoCaracter(Esp, Media, Esp.Count);

                    String Text = "    " + C + "   - " + TexEsp;
                    listBox1.Items.Add(Separator);
                    listBox1.Items.Add(Text);

                    String Text2 = "     " + C + "              -               " + Media + "              -               " + DesvP;
                    listBox2.Items.Add(Separator);
                    listBox2.Items.Add(Text2);

                }
            }

            for (int i = 123; i <= 125; i++)
            {
                char C = (char)i;
                List<int> Esp = Analizador.verificaPosicao(C, Vet);

                String TexEsp = " ";

                if (Esp.Count == 0)
                {
                    TexEsp = " O texto não possui este caracter! ";
                }
                else
                {
                    foreach (int B in Esp)
                    {
                        TexEsp += B.ToString() + ", ";
                    }
                }


                int Media = Analizador.getMediaCaracter(Esp, Esp.Count);
                int DesvP = Analizador.getDesvioPadraoCaracter(Esp, Media, Esp.Count);

                String Text = "    " + C + "   - " + TexEsp;
                listBox1.Items.Add(Separator);
                listBox1.Items.Add(Text);

                String Text2 = "     " + C + "              -               " + Media + "              -               " + DesvP;
                listBox2.Items.Add(Separator);
                listBox2.Items.Add(Text2);

            }

            for (int i = 97; i <= 122; i++)
            {
                char C = (char)i;
                List<int> Esp = Analizador.verificaPosicao(C, Vet);

                String TexEsp = " ";

                if (Esp.Count == 0)
                {
                    TexEsp = " O texto não possui este caracter! ";
                }
                else
                {
                    foreach (int B in Esp)
                    {
                        TexEsp += B.ToString() + ", ";
                    }
                }


                int Media = Analizador.getMediaCaracter(Esp, Esp.Count);
                int DesvP = Analizador.getDesvioPadraoCaracter(Esp, Media, Esp.Count);

                String Text = "    " + C + "   - " + TexEsp;
                listBox1.Items.Add(Separator);
                listBox1.Items.Add(Text);

                String Text2 = "     " + C + "              -               " + Media + "              -               " + DesvP;
                listBox2.Items.Add(Separator);
                listBox2.Items.Add(Text2);

            }

            listBox1.Items.Add(Separator);
            //=============================================================================================================




        }


    }
}

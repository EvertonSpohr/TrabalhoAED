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

namespace TrabalhoAED.Interface
{


    public partial class Frequencia : Form
    {

//ATRIBUTOS ======================================================================

        int NArq;

//METODOS =======================================================================

        public Frequencia(int N)
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

//FAZ TODA  A PUTARIA =====================================================================
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Index = comboBox1.SelectedIndex;

            listBox1.Items.Clear();

            String Separator = "___________________________________________________________________";

            listBox1.Items.Add("CARACTER     -          FREQUENCIA ");
            listBox1.Items.Add(Separator);

            for (int i = 32; i <= 64; i++)
            {


                char C = (char)i;
                
                int Quant = Analizador.contaLetra((char)i, Analizador.Lista_Vet[Index]);

                String TexEsp = " ";

                if (Quant == 0)
                {
                    TexEsp = " 0 ";
                }
                else
                {
                    TexEsp += Quant.ToString();     
                }



                if (i == 32)
                {
                    String Text = " Space            -           " + TexEsp;
                    listBox1.Items.Add(Separator);
                    listBox1.Items.Add(Text);
                }
                else
                {
                    String Text = "    " + C + "                -             " + TexEsp;
                    listBox1.Items.Add(Separator);
                    listBox1.Items.Add(Text);
                }
            }

            for (int i = 123; i <= 125; i++)
            {
                char C = (char)i;

                int Quant = Analizador.contaLetra((char)i, Analizador.Lista_Vet[Index]);

                String TexEsp = " ";

                if (Quant == 0)
                {
                    TexEsp = " 0 ";
                }
                else
                {
                    TexEsp += Quant.ToString();
                }

                String Text = "    " + C + "                -             " + TexEsp;
                listBox1.Items.Add(Separator);
                listBox1.Items.Add(Text);

            }

            for (int i = 97; i <= 122; i++)
            {
                char C = (char)i;

                int Quant = Analizador.contaLetra((char)i, Analizador.Lista_Vet[Index]);

                String TexEsp = " ";

                if (Quant == 0)
                {
                    TexEsp = " 0 ";
                }
                else
                {
                    TexEsp += Quant.ToString();
                }

                String Text = "    " + C + "                -             " + TexEsp;
                listBox1.Items.Add(Separator);
                listBox1.Items.Add(Text);

            }

            listBox1.Items.Add(Separator);
            //=============================================================================================================


        }
    }
}

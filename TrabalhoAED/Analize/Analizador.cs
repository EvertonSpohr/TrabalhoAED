using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 *  Esta classe implementa os algoritmos responsaveis pela analize de textos, calculos de media e desvio padrao
 *  e tambem nela esta a a List com os vetores, implementada de forma estatica para economizar recursos computacionais.
 * 
 */





namespace TrabalhoAED.Analize
{
    public class Analizador
    {
    //ATRIBUTOS ===============================================================
               
        public static int Tam = 0;
        
        public static List<char[]> Lista_Vet = new List<char[]>(); //LISTA COM OS VETORES QUE VAO SER ORDENADOS.
               

    //=========================================================================
    
    //METODOS =================================================================
       
        //O arquivo deve ser salvo em qualquer padrao menos ANSI
        public static void analizaLetras(char[] Vet_Texto)
        {
            
            int i;

            for (i = 0; Vet_Texto[i] != '\0'; i++)
            {
                int CodA = (int)Vet_Texto[i]; //CONVERTE O CHAR PRA INT
                                
                //Verifica acentos no A (maiusculo)
                if ((CodA >= 192 && CodA <= 195) || (CodA >= 224 && CodA <= 227))
                {
                    Vet_Texto[i] = (char)(97);
                }

                //Verifica Ç (maiusculo) e ç (minusculo)
                if ((CodA == 199) || (CodA == 231))
                {
                    Vet_Texto[i] = (char)(99);
                }

                //Verifica acentos no E (maiusculo) e e (Minusculo)
                if ((CodA >= 200 && CodA <= 202) || (CodA >= 232 && CodA <= 234))
                {
                    Vet_Texto[i] = (char)(101);
                }

                //Verifica acentos no I (maiusculo) e i (minusculo)
                if ((CodA >= 204 && CodA <= 206) || (CodA >= 236 && CodA <= 238))
                {
                    Vet_Texto[i] = (char)(105);
                }

                //Verifica acentos no N (maiusculo) e n (minusculo)
                if ((CodA == 209) || (CodA == 241))
                {
                    Vet_Texto[i] = (char)(110);
                }

                //Verifica acentos no O (maiusculo) e o (minusculo)
                if ((CodA >= 210 && CodA <= 213) || (CodA >= 242 && CodA <= 245))
                {
                    Vet_Texto[i] = (char)(111);
                }

                //Verifica acentos no U (maiusculo) e u (minusculo)
                if ((CodA >= 217 && CodA <= 219) || (CodA >= 249 && CodA <= 251))
                {
                    Vet_Texto[i] = (char)(117);
                }

                //Verifica se é maiuscula
                if (CodA >= 65 && CodA <= 90)
                {
                    Vet_Texto[i] = (char)(CodA + 32);
                }

                Tam = i;
            }

            Tam = i++;

        }

        //Conta numero de caracteres L dentro do vetor
        public static int contaLetra(char L, char[] Vet_Texto)
        {         
            int contador = 0;

            foreach (char A in Vet_Texto) 
            {
                if ((int)A > (int)L) break;

                if ((int)A == (int)L)
                {                    
                    contador++;
                }
            }           

            return contador;
        }

//==========================================================================================

        //verifica as posisoes que o caracter se encontra, retorna uma lista
        public static List<int> verificaPosicao(char L, char[] Vet_Texto)
        {
            List<int> ListaPos = new List<int>();
                        
            for(int i = 0; Vet_Texto[i] != (char)0 ; i++)
            {
                if ((int)Vet_Texto[i] == (int)L)
                {
                    ListaPos.Add(i);                    
                }
            }
            
            return ListaPos;

        }

//CALCULA MEDIA DOS ALGORITMOS ==============================================================================

        public static Val_Analize getMedia(Val_Analize[] Anal, int Quant)
        {
            Val_Analize V = new Val_Analize();

            int Comp = 0, Mov = 0, Tam = 0;
            double Time = 0.0;

            if (Quant > 1)
            {

                for (int i = 0; i < Quant; i++)
                {
                    Comp += Anal[i].N_Comp;
                    Mov += Anal[i].N_Mov;
                    Time += Anal[i].Tempo;
                    Tam += Anal[i].Tamanho;
                }

                V.N_Comp = (Comp / Quant);
                V.N_Mov = (Mov / Quant);
                V.Tempo = (Time / Quant);
                V.Tamanho = (Tam / Quant);
                
            }
            else 
            {
                V.N_Comp = Anal[0].N_Comp;
                V.N_Mov = Anal[0].N_Mov;
                V.Tempo = Anal[0].Tempo;
                V.Tamanho = Anal[0].Tamanho;
            }

            return V;
        }

//CALCULA O DESVIO PADRAO DOS ALGORITMOS ==========================================================================

        public static Val_Analize getDesvioPadrao(Val_Analize[] Anal, Val_Analize Med, int Quant)
        {
            Val_Analize V_DP = new Val_Analize();

            double Comp = 0, Mov = 0, Tam = 0;
            double Time = 0.0;

            if (Quant > 1)
            {

                for (int i = 0; i < Quant; i++)
                {
                    Comp += (Anal[i].N_Comp - Med.N_Comp) * (Anal[i].N_Comp - Med.N_Comp);
                    Mov += (Anal[i].N_Mov - Med.N_Mov) * (Anal[i].N_Mov - Med.N_Mov);
                    Time += (Anal[i].Tempo - Med.Tempo) * (Anal[i].Tempo - Med.Tempo);
                    Tam += (Anal[i].Tamanho - Med.Tamanho) * (Anal[i].Tamanho - Med.Tamanho);
                }

                V_DP.N_Comp = (int)Math.Sqrt(Comp / (Quant - 1));
                V_DP.N_Mov = (int)Math.Sqrt(Mov / (Quant - 1));
                V_DP.Tempo = Math.Sqrt(Time / (Quant - 1));
                V_DP.Tamanho = (int)Math.Sqrt(Tam / (Quant - 1));
                                
            }
            else
            {
                V_DP.N_Comp = 0;
                V_DP.N_Mov = 0;
                V_DP.Tempo = 0;
                V_DP.Tamanho = 0;
            }

            return V_DP;
        }

//CALCULA MEDIA DOS ESPAÇAMENTOS DE CARCTERES ==============================================================================

        public static int getMediaCaracter(List<int> Anal, int Quant)
        {
            int Media;

            int Soma = 0;
            
            if (Quant >= 1)
            {

                for (int i = 0; i < Quant; i++)
                {
                    Soma += Anal[i];
                }
                               
                Media = (Soma / Quant);

            }
            else
            {               
                Media = 0;
            }

            return Media;
        }

//CALCULA O DESVIO PADRAO DOS ESPACAMENTO DE CARACTERES ==========================================================================

        public static int getDesvioPadraoCaracter(List<int> Anal, int Med, int Quant)
        {
            int DesvP;
                        
            double Soma = 0.0;

            if (Quant > 1)
            {

                for (int i = 0; i < Quant; i++)
                {
                    Soma += (Anal[i] - Med) * (Anal[i] - Med);
                }

                DesvP = (int)Math.Sqrt(Soma / (Quant - 1));

            }
            else
            {
                DesvP = 0;
            }

            return DesvP;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAED.Analize
{
    public class Analizador
    {
    //ATRIBUTOS ===============================================================

        public static char[] Vet_Texto = new char[10000]; 


    //=========================================================================
    
    //METODOS =================================================================
       
        //O arquivo deve ser salvo em qualquer padrao menos ANSI
        public static void analizaLetras()
        {
            int Tam = Vet_Texto.Length;

            for (int i = 0; /*i < Tam*/ Vet_Texto[i] != '\0'; i++)
            {
                int CodA = (int)Vet_Texto[i]; //CONVERTE O CHAR PRA INT

                Console.Out.WriteLine(CodA);

                
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

            }



        }

        //Conta numero de caracteres L dentro do vetor
        public static int contaLetra(char L)
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

        public static List<int> verificaPosicao(char L)
        {
            List<int> ListaPos = new List<int>();
                        
            for(int i = 0; Vet_Texto[i] != '\0'; i++)
            {
                if ((int)Vet_Texto[i] == (int)L)
                {
                    ListaPos.Add(i);                    
                }
            }
            
            return ListaPos;

        }



    }
}

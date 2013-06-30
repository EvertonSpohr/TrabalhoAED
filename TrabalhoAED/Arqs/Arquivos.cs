using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoAED.Analize;


/*
 *  Classe para tratar o arquivo de entrada.
 * 
 *  Everton R. Spohr
 */


namespace TrabalhoAED.Arqs
{
    class Arquivos
    {

//ATRIBUTOS =================================================================================================

        public static string[] Local = new string[15];

//METODOS ===================================================================================================

        // Abre o arquivo e coloca cada letra em um vetor
        public char[] abrirArquivo(string Local)
        {
            int ContL = 0; //Contador para as letras
            
            char[] Vet_Texto = new char[10000];
            
            StreamReader Read = new StreamReader(Local);

            while (!Read.EndOfStream && (ContL < 9999))     //ENQUANTO NAO FOR O FIM DO ARQUIVO... NO MAX 9999 LETRAS
            {
                string L = Read.ReadLine();

                foreach(char Letra in L){                    
                    Vet_Texto[ContL] = Letra;                    
                    ContL++;
                }                              
            }            
            Vet_Texto[ContL] = '\0';

            Read.Close();
           
            return(Vet_Texto);

                       
                
        } // Fim do abrirArquivo
    }    
}

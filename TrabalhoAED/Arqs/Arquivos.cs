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

        // Abre o arquivo e coloca cada letra em um vetor
        public void abrirArquivo(string Local)
        {
            int ContL = 0; //Contador para as letras

            StreamReader Read = new StreamReader(Local);

            while ( !Read.EndOfStream && (ContL < 9999) )     //ENQUANTO NAO FOR O FIM DO ARQUIVO... NO MAX 9999 LETRAS
            {
                string L = Read.ReadLine();

                foreach(char Letra in L){                    
                    Analizador.Vet_Texto[ContL] = Letra;                    
                    ContL++;
                }                              
            }            
            Analizador.Vet_Texto[ContL] = '\0';

            Read.Close();           
                
        } // Fim do abrirArquivo
    }    
}

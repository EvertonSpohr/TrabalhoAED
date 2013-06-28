using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoAED.Analize;

namespace TrabalhoAED.Ordenação
{
    class KSort
    {
//ATRIBUTOS ===============================================================================

        public int N_Comp = 0;
        public int N_Mov = 0;

        int meio = 0; ///VARIAVEL GLOBAL PARA O MEIO 

//METODOS =================================================================================

//K-SORT ==================================================================================================
       int reorganizaK(int esq, int dir, int pos) 
       {   
           int i = esq, j = dir + 1,  p = esq + 1, k = p, flag = 0;
           char temp = '0', key = Analizador.Lista_Vet[pos][esq];
	
	                while( (j - i) >= 2 ){

                        N_Comp++;
                        if ((int)key <= (int)Analizador.Lista_Vet[pos][p])
                        {
                            N_Comp++;
                            if( (p != j) && (j != (dir + 1)) ){
                                N_Mov++;

                                Analizador.Lista_Vet[pos][j] = Analizador.Lista_Vet[pos][p];                                                
			                }
			                else if( j == dir+1 ){
                                N_Mov++;

                                temp = Analizador.Lista_Vet[pos][p];
				                flag = 1;
			                }
			                j--;
			                p = j;
		                }
		                else{
                            N_Mov++;

                            Analizador.Lista_Vet[pos][i] = Analizador.Lista_Vet[pos][p];
			                i++;
			                k++;
			                p = k;		                }
	                }

                    N_Mov++;
                    Analizador.Lista_Vet[pos][i] = key;
	                        
	                if(flag == 1) {
                        Analizador.Lista_Vet[pos][i + 1] = temp;
                    }        
                        
	                return i;
            }
//------------------------------------------------------------------------------------------------------
       void SortK(int esq, int dir, int pos)
       {
           N_Comp++;
           if (esq < dir)
           {   
               meio = reorganizaK(esq, dir, pos);
               SortK(esq, meio - 1, pos);
               SortK(meio + 1, dir, pos);
           }
       }
//------------------------------------------------------------------------------------------------------
        public void K_Sort(int n, int pos)
        {
            SortK(0, n-1, pos);
        }
//==========================================================================================================

    }
}

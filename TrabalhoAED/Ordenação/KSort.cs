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
       int reorganizaK(int esq, int dir) 
       {   
           int i = esq, j = dir + 1,  p = esq + 1, k = p, flag = 0;
           char temp = '0', key = Analizador.Vet_Texto[esq];
	
	                while( (j - i) >= 2 ){

                        N_Comp++;
		                if((int)key <= (int)Analizador.Vet_Texto[p]){
                            N_Comp++;
                            if( (p != j) && (j != (dir + 1)) ){
                                N_Mov++;
				                
                                Analizador.Vet_Texto[j] = Analizador.Vet_Texto[p];                                                
			                }
			                else if( j == dir+1 ){
                                N_Mov++;

				                temp = Analizador.Vet_Texto[p];
				                flag = 1;
			                }
			                j--;
			                p = j;
		                }
		                else{
                            N_Mov++;

			                Analizador.Vet_Texto[i] = Analizador.Vet_Texto[p];
			                i++;
			                k++;
			                p = k;		                }
	                }

                    N_Mov++;
	                Analizador.Vet_Texto[i] = key;
	                        
	                if(flag == 1) {
                            Analizador.Vet_Texto[i+1] = temp;
                    }        
                        
	                return i;
            }
//------------------------------------------------------------------------------------------------------
       void SortK(int esq, int dir)
       {
           N_Comp++;
           if (esq < dir)
           {   
               meio = reorganizaK(esq, dir);
               SortK(esq, meio - 1);
               SortK(meio + 1, dir);
           }
       }
//------------------------------------------------------------------------------------------------------
        public void K_Sort(int n)
        {
            SortK(0, n-1);
        }
//==========================================================================================================

    }
}

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

//METODOS =================================================================================

//K-SORT ==================================================================================================

        public int Reorganiza(int esq, int dir, int pos)
        {
            char Key = Analizador.Lista_Vet[pos][esq];

            int i = esq; 
            int  j = dir + 1, p = esq + 1, k = p; 
            bool flag = false;

            char temp = ' ';  

            while ((j - i) >= 2)
            {
                N_Comp++;
                if ( (int)Key <= (int)Analizador.Lista_Vet[pos][p] )
                {
                    N_Comp++;
                    if ( (p != j) && (j != (dir + 1)) )
                    {
                        N_Mov++;
                        Analizador.Lista_Vet[pos][j] = Analizador.Lista_Vet[pos][p];
                    }
                    else if ( j == (dir + 1) )
                    {
                        temp = Analizador.Lista_Vet[pos][p];
                        flag = true;
                    }

                    j--;
                    p = j;
                }
                else
                {
                    N_Mov++;
                    Analizador.Lista_Vet[pos][i] = Analizador.Lista_Vet[pos][p];
                    i++;
                    k++;
                    p = k;
                }
            }
            N_Mov++;
            Analizador.Lista_Vet[pos][i] = Key;

            N_Comp++;
            if (flag == true)
            {
                N_Mov++;
                Analizador.Lista_Vet[pos][i + 1] = temp;
            }
            
            return i;
        }




//-------------------------------------------------------------------------------------------------------

        private void Sort(int esq, int dir, int pos)
        {

            if (esq < dir)
            {
                N_Comp++;
                int meio = Reorganiza(esq, dir, pos);
                Sort(esq, meio - 1, pos);
                Sort(meio + 1, dir, pos);
            }
        }
        

//------------------------------------------------------------------------------------------------------
        public void K_Sort(int n, int pos)
        {
            Sort(0, n - 1, pos);
        }
//==========================================================================================================
        
    }
}

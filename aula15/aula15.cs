using System;

class aula15
{
    static void Main()
    {
        int[] array=new int[5];
        int[] arnew=new int[5];
        int[] newarr=new int[3]{1,2,2};
        int[] arrev= new int[5];
        int[] revarr= new int[3];
        for (int i=0; i<array.Length;i++){
            array[i]=i+1;
            arnew[i]=i;
            arrev[i]=((int)array.Length)-i;
            if(i <3){
                revarr[i] = ((int)array.Length)-i-2;
            }
        }
        int aux=0;
        inicio:
        for(int i =0; i<array.Length;i++){
            if(aux ==0){
                Console.Write(" {0}",array[i]);
            }
            else if(aux == 1){
                Console.Write(" {0}",arnew[i]);
            }
            else if (aux == 2){
                if (i<3){
                    if (i == 2){
                        newarr[i]=3;
                    }
                    Console.Write(" {0}",newarr[i]);
                } 
            }
            else if( aux== 3){
                Console.Write(" {0}",arrev[i]);
            }
            else{
                if(i<3){
                    Console.Write(" {0}",revarr[i]);
                }
            }
        }
        if(aux <4){
            aux++;
            Console.WriteLine("\n");
            goto inicio;
        }
    }

}
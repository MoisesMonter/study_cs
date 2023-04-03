using System;

class aula14
{



    static void Main()
    {
        int x=0;
        start:
            
        if (x == 0){
            Console.Write("{0}",x++);
            goto start;
        }
        else if(x <= 10){
            Console.Write(",{0}",x++);  
            goto start;
        }
        Console.Write(".");
    }
}
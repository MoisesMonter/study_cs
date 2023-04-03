using System;
/*Conversões
    Implicitas e não Implicitas
    
    */
class aula11{

    static void Main()
    {
        int n1=10;
        float n2=n1;
        Console.WriteLine("\nConversão Segura(Inplicita):{0}\n",n2);
        float n3=10.5f;
        /*int n4= n3; Nesse caso necessita de Cast para converter*/
        int n4=(int)n3;
        Console.WriteLine("\nConversão Não Segura(Não Inplicita):{0}\n",n2);
    }
}
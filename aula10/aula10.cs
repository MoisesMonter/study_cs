using System;


class aula10
{   
    enum DiasSemana{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sábado};
    static void Main()
    {
        DiasSemana ds = DiasSemana.Sábado;
        DiasSemana dt = (DiasSemana)2;
        int dd = (int)DiasSemana.Domingo; //(int) força converter, pegando indicie de domingo
        Console.WriteLine(ds);
        Console.WriteLine(dt);
        Console.WriteLine(dd);
    }
}
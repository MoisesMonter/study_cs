using System;

class aula09
{
    static void Main()
    {
        int num=10;
        num = num<<1;

        Console.WriteLine(num);
    }
}

    /*  << Bitwize Dobra
        >> BitWize Metade
        var<< 1; desloca um bit para esquerda.
        var>> 2; desloca dois para direita.
        Bitwize ou Operadores de Shitf

/*
| 00000000 |  0|    | 00000110 |  6|    | 00001100 |  12|    | 00010010 |  18|    | 00011000 |  24|    | 00011110 |  30|    | 00100100 |  36|    | 00101010 |  42|    | 00101111 |  48|    | 00110101 |  54|    | 00111011 |  60|
| 00000001 |  1|    | 00000111 |  7|    | 00001101 |  13|    | 00010011 |  19|    | 00011001 |  25|    | 00011111 |  31|    | 00100101 |  37|    | 00101011 |  43|    | 00110000 |  49|    | 00110110 |  55|    | 00111100 |  61|
| 00000010 |  2|    | 00001000 |  8|    | 00001110 |  14|    | 00010100 |  20|    | 00011010 |  26|    | 00100000 |  32|    | 00100110 |  38|    | 00101100 |  44|    | 00110001 |  50|    | 00110111 |  56|    | 00111101 |  62|
| 00000011 |  3|    | 00001001 |  9|    | 00001111 |  15|    | 00010101 |  21|    | 00011011 |  27|    | 00100001 |  33|    | 00100111 |  39|    | 00101100 |  45|    | 00110010 |  51|    | 00111000 |  57|    | 00111110 |  63|
| 00000100 |  4|    | 00001010 | 10|    | 00010000 |  16|    | 00010110 |  22|    | 00011100 |  28|    | 00100010 |  34|    | 00101000 |  40|    | 00101101 |  46|    | 00110011 |  52|    | 00111001 |  58|    | 00111111 |  64|
| 00000101 |  5|    | 00001011 | 11|    | 00010001 |  17|    | 00010111 |  23|    | 00011101 |  29|    | 00100011 |  35|    | 00101001 |  41|    | 00101110 |  47|    | 00110100 |  53|    | 00111010 |  59|    | 01000000 |  65|
*/
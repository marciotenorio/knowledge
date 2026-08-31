package academy.devdojo.maratonajava.introducao;

public class Aula04Operadores {
    public static void main(String[] args) {

        //All binary operators except for the assignment operators are evaluated from left to right;
        // assignment operators are evaluated right to left.

        // + - / *
        int numero01 = 10;
        int numero02 = 20;
        double resultado = numero01 / (double) numero02;
        System.out.println(resultado);

        // %
        int resto = 21 % 7;
        System.out.println(resto);

        // < > <= >= == !=
        boolean isDezMaiorQueVinte = 10 >= 20;
        boolean isDezMenorQueVinte = 10 <= 20;
        boolean isDezIgualVinte = 10 == 20;
        boolean isDezIgualDez = 10 == 10.0;
        boolean isDezDiferenteDez = 10 != 10.0;

        System.out.println("isDezMaiorQueVinte " + isDezMaiorQueVinte);
        System.out.println("isDezMenorQueVinte " + isDezMenorQueVinte);
        System.out.println("isDezIgualVinte " + isDezIgualVinte);
        System.out.println("isDezIgualDez " + isDezIgualDez);
        System.out.println("isDezDiferenteDez " + isDezDiferenteDez);

        // && (AND) || (or) !
        int idade = 29;
        float salario = 3500F;
        boolean isDentroDaLeiMaiorQueTrinta = idade >= 30 && salario >= 4612;
        boolean isDentroDaLeiMenorQueTrinta = idade < 30 && salario >= 3381;

        System.out.println("isDentroDaLeiMaiorQueTrinta " + isDentroDaLeiMaiorQueTrinta);
        System.out.println("isDentroDaLeiMenorQueTrinta " + isDentroDaLeiMenorQueTrinta);

        double valorTotalContaCorrente = 200;
        double valorTotalContaPoupanca = 10000;
        float valorPlaystation = 5000F;
        boolean isPlaystationCincoCompravel = valorTotalContaCorrente > valorPlaystation || valorTotalContaPoupanca > valorPlaystation;
        System.out.println("isPlaystationCincoCompravel " + isPlaystationCincoCompravel);

        // = += -= *= /= %=
        double bonus = 1800; // 1800
        bonus += 1000; // 2800
        bonus -= 1000; // 1800
        bonus *= 2;
        bonus /= 2;
        bonus %= 2;
        System.out.println(bonus);

        // ++ --
        int contador = 0;
        contador += 1; // contador = contador + 1;
        contador++; //incrementa depois
        contador--;
        ++contador; //incrementa antes
        --contador;
        int contador2 = 0;
        System.out.println(contador2++);

//        First, the operands are converted to their binary representation
//        Next, the operator is applied to each binary number and the result is calculated
//        Finally, the result is converted back to its decimal representation

        int bitwise7 = 7; //0000 0111 binary
        int bitwise6 = 6; //0000 0110 binary
        int resultOrInclusive = bitwise7 | bitwise6;
        int resultOrExclusive = bitwise7 ^ bitwise6;
        int resultAnd = bitwise7 & bitwise6;

        System.out.println("Bitwise logical operations examples: \n");

        System.out.println("~ -> Negation/Complement bits of " + bitwise7 + ": " + ~bitwise7);
        System.out.println("| -> OR Inclusive bits of " + bitwise7 + " and "
                + bitwise6 + ": " + resultOrInclusive);
        System.out.println("^ -> XOR (both different) bits of " + bitwise7 + " and "
                + bitwise6 + ": " + resultOrExclusive);
        System.out.println("& -> And bits of " + bitwise7 + " and "
                + bitwise6 + ": " + resultAnd);

        System.out.println("Bitwise Shift Operations: \n");

        //value <operator> <number_of_times>

        // >>
//        The left shift operator shifts the bits to the left by the number of times
//        specified by the right side of the operand. After the left shift,
//        the empty space in the right is filled with 0.

//        Another important point to note is that shifting a number by one is
//        equivalent to multiplying it by 2, or, in general,
//        left shifting a number by n positions is equivalent to multiplication by 2^n.
        int resultSignedLeftShift = 12 << 2;
        int resultSignedRightShift = 12 >> 2;
        int resultUnsignedRightShift = -11 >>> 2;

        System.out.println("<< -> Signed Left Shift of 12 << 2: " + resultSignedLeftShift);

        // >>
//        The right shift operator shifts all the bits to the right.
//        The empty space on the left side is filled depending on the input number:
//
//        When an input number is negative, where the leftmost bit is 1,
//                then the empty spaces will be filled with 1
//        When an input number is positive, where the leftmost bit is 0,
//                then the empty spaces will be filled with 0

        System.out.println(">> -> Signed Right Shift of 12 >> 2: " + resultSignedRightShift);


        //>>>
//        This operator is very similar to the signed right shift operator. The only difference is that the empty
//        spaces in the left are filled with 0 irrespective of whether the number is positive or negative.
//        Therefore, the result will always be a positive integer.
        System.out.println(">>> -> Unsigned Right Shift of -11 >>> 2: " + resultUnsignedRightShift);

    }
}

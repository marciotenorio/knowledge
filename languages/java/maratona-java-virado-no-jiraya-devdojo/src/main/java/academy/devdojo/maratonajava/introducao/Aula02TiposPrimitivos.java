package academy.devdojo.maratonajava.introducao;

public class Aula02TiposPrimitivos {
    public static void main(String[] args) {
        // int, double, float, char, byte, short, long, boolean
        //The integral types are byte , short , int , and long

        int idade = (int) 10000000000L;     //4 bytes
        long numeroGrande = (long) 155.23; //8 bytes
        double salarioDouble = 2000.0D;   // 8 bytes
        float salarioFloat = (float) 2500.0D; // 4 bytes
        byte idadeByte = 127;             //1 byte
        short idadeShort = 32000;         //2 bytes
        boolean verdadeiro = true;        //1 bit (não é precisamente definido, ta na oracle xD)
        boolean falso = false;
        char caractere = '\u0041';       //2 bytes
        String nome = "Goku";

        System.out.println("A idade é "+idade+" anos");
        System.out.println(falso);
        System.out.println("char "+caractere);
        System.out.println(numeroGrande);
        System.out.println("Oi meu nome é "+nome);
    }
}

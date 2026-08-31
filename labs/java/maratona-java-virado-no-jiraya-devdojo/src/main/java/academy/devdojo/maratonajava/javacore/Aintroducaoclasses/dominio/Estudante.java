package academy.devdojo.maratonajava.javacore.Aintroducaoclasses.dominio;

public class Estudante {
    public String nome = "Zoro";
    public int idade;
    public char sexo;

    @Override
    public String toString() {
        return "Estudante{" +
                "nome='" + nome + '\'' +
                ", idade=" + idade +
                ", sexo=" + sexo +
                '}';
    }
}

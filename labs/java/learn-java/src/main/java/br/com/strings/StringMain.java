package br.com.strings;

public class StringMain {
    public static void main(String[] args) {
        String a = "First String";
        String b = new String("First String");
        //a and b have different address
        System.out.println(a.equals(b) ? "Equals" : "Not equals");

        //Compiler allocate one time and points c and d to same address
        String c = "Some strange string...";
        String d = "Some strange string...";
        System.out.println(c == d ? "Same reference" : "Not the same reference");

    }
}

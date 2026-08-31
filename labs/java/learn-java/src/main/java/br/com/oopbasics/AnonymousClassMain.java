package br.com.oopbasics;

/**
 * An Anonymous Class is an expression.
 * Can be made with an interface or extending an existent class
 */
public class AnonymousClassMain {
    public static void main(String[] args) {

        var comparator = new Comparable<String>() {

            public String own = "oi";

            @Override
            public int compareTo(String o) {
                return own.compareToIgnoreCase(o);
            }

            @Override
            public String toString() {
                return "anonymous Comparable{" +
                        "own='" + own + '\'' +
                        '}';
            }
        };

        var suv = new Car() {
            public String ownSuvField = "suv";

            @Override
            public String toString() {
                return "anonymous suv {" +
                        "own='" + ownSuvField + '\'' +
                        '}';
            }
        };

        System.out.println(comparator);
        System.out.println(suv);
    }
}

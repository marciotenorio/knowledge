package br.com.oopbasics;

/**
 * When someone implements an inteface, it could invoke Interface.super.method().
 * I think that could be useful when you face when diamond problem.
 */
public interface Printable {

    /**
     * It's not encouraged, but you can declare fields and all of them is public static final
     * and should be initialized when declared.
     */
    public static final String NAME = "PRINTABLE";

    /**
     * Can have private methods
     * Only private methods can be implemented without default keyword
     */
    private void print2() {}

    /**
     * The contract of interface
     */
    void print();

    /**
     * Just to print the field
     */
    default void printStatic() {
        System.out.println(NAME);
    }
}

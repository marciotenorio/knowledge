package br.com.updowncasting;

/**
 * Static type => The declared type
 * Dynamic type => The object the variable refer
 */
public class UpDownCastingMain {
    public static void main(String[] args) {
        //Upcasting
        Item up = new CD("Oi upcasting", 10, 10F);
        System.out.println("--- Upcasting ---");
        System.out.println(up);

        //Not works
        //CD down = new Item("Title down", 10);

        //Works downcasting
        CD down = new CD("CD Oi", 10, 10F);
        Item itemDown = down;
        System.out.println("--- Downcasting ---");
        System.out.println(itemDown);

        //Upcasting and casting to get subclass method.
        //Need to do this because late binding searching for the method first in Item
        Item upying = new CD("Oi upying", 10, 10F);
        System.out.println("--- Casting to get specific method ---");
        ((CD)upying).print();
    }
}

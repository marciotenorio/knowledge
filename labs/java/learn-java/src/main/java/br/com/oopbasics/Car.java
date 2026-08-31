package br.com.oopbasics;

public class Car extends AbstractVehicle implements Printable {
    private int doors;

    public int getDoors() {
        return doors;
    }

    public void setDoors(int doors) {
        this.doors = doors;
    }

    @Override
    public boolean move(int kms) {
        if(kms <= 0) return false;

        System.out.println("Car moving " + kms + " kms in ground.");
        return true;
    }

    @Override
    public void print() {
        /**
         * More explanations in Printable interface.
         */
        System.out.println("=> CONSTANT FROM INTERFACE: " + this.NAME + " <=");
        Printable.super.printStatic();
        System.out.println(this);
    }

    @Override
    public String toString() {
        return "Car{" +
                "doors=" + doors +
                ", wheelsQty=" + getWheelsQty() +
                '}';
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (!(o instanceof Car car)) return false;
        return doors == car.doors;
    }

    // Typical hashCode method
    @Override
    public int hashCode() {
        int result = Integer.hashCode(this.doors);
        result = 31 * result + Integer.hashCode(this.wheelsQty);
        return result;
    }
}

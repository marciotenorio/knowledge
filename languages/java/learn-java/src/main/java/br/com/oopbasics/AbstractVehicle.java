package br.com.oopbasics;

public abstract class AbstractVehicle {
    protected int wheelsQty;

    public int getWheelsQty() {
        return wheelsQty;
    }

    public void setWheelsQty(int wheelsQty) {
        this.wheelsQty = wheelsQty;
    }

    public abstract boolean move(int kms);
}

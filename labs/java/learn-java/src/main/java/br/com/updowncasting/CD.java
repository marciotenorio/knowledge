package br.com.updowncasting;

public class CD extends Item {
    private double price;

    public CD(String title, float duration, double price) {
        super(title, duration);
        this.price = price;
    }

    public double getPrice() {
        return price;
    }

    public void setPrice(double price) {
        this.price = price;
    }

    public void print(){
        System.out.println("CD printing...");
    }

    @Override
    public String toString() {
        return "CD{" +
                "price=" + price +
                "} " + super.toString();
    }
}

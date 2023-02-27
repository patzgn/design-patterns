package com.patzgn.decorator;

class Decaf extends Beverage {
    public Decaf() {
        setDescription("Decaf Coffee");
    }

    @Override
    public double cost() {
        return 5.35;
    }
}

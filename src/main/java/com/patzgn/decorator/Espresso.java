package com.patzgn.decorator;

class Espresso extends Beverage {
    public Espresso() {
        setDescription("Espresso");
    }

    @Override
    public double cost() {
        return 6.49;
    }
}

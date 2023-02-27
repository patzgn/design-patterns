package com.patzgn.decorator;

abstract class CondimentDecorator extends Beverage {
    Beverage beverage;

    public abstract String getDescription();
}

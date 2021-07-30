package me.yochran.doxlol.utils.world;

public class City {

    private Country country;

    public City(Country country) {
        this.country = country;
    }

    public Country getCountry() { return country; }
}

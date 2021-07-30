package me.yochran.doxlol.utils.world;

import me.yochran.doxlol.utils.Human;

import java.util.Map;

public class World {

    public static Map<Human, String[]> getHumans() {
        return Human.humans;
    }

    public static Country[] getCountries() {
        return new Country[] {

        };
    }
}

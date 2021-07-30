package me.yochran.doxlol.utils.world;;

import java.util.Arrays;
import java.util.Random;

public class Country {

    private static String[] names = new String[] {
            "America",
            "United Kingdom",
            "Israel",
            "Palestine",
            "China",
            "Russia",
            "Japan",
            "Brazil",
            ""
    };

    public static String getName() {
        return Arrays.asList(names).get(new Random().nextInt(names.length));
    }

    public static boolean isRecognizedByUN() {
        return !getName().equalsIgnoreCase("Palestine");
    }

    public static City[] getCities() {
        return new City[] {

        };
    }
}

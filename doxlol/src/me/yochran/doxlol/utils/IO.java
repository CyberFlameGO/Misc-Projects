package me.yochran.doxlol.utils;

import java.text.SimpleDateFormat;
import java.util.Scanner;

public class IO {

    private static final Scanner scanner = new Scanner(System.in);
    private static final SimpleDateFormat sdf = new SimpleDateFormat("MM/dd/yyyy, HH:mm:ss");

    public static void output(String message) {
        System.out.println("[" + sdf.format(System.currentTimeMillis()) + "] " + message);
    }

    public static String input() {
        return scanner.nextLine();
    }

    public static String input(String message) {
        output(message);
        return scanner.nextLine();
    }
}

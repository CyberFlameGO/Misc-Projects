package me.yochran.spambot.utils;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class FileUtil {

    public static List<String> FILE_DATA(File FILE) throws FileNotFoundException {
        Scanner READER = new Scanner(FILE);
        List<String> DATA = new ArrayList<>();

        while (READER.hasNextLine())
            DATA.add(READER.nextLine());

        READER.close();

        return DATA;
    }
}

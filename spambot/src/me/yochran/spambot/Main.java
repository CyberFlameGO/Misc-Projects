package me.yochran.spambot;

import me.yochran.spambot.utils.FileUtil;

import java.awt.*;
import java.awt.datatransfer.Clipboard;
import java.awt.datatransfer.StringSelection;
import java.awt.event.KeyEvent;
import java.io.File;
import java.io.FileNotFoundException;
import java.util.List;

public class Main {

    private static Robot ROBOT;

    public static void main(String[] args) throws FileNotFoundException, InterruptedException, AWTException {
        ROBOT  = new Robot();

        File file = new File("text.txt");

        List<String> FILE_CONTENT = FileUtil.FILE_DATA(file);

        System.out.println("Spamming will start in 5 seconds.");
        Thread.sleep(5000);

        StringSelection STRING_SELECTION;
        
        for (String LINE : FILE_CONTENT) {
            STRING_SELECTION = new StringSelection(LINE);
            Clipboard CLIPBOARD = Toolkit.getDefaultToolkit().getSystemClipboard();
            CLIPBOARD.setContents(STRING_SELECTION, null);

            Thread.sleep(1);

            ROBOT.keyPress(KeyEvent.VK_CONTROL);
            ROBOT.keyPress(KeyEvent.VK_V);
            ROBOT.keyRelease(KeyEvent.VK_CONTROL);
            ROBOT.keyRelease(KeyEvent.VK_V);

            Thread.sleep(1);

            ROBOT.keyPress(KeyEvent.VK_ENTER);
            ROBOT.keyRelease(KeyEvent.VK_END);

            System.out.println("Spammed line: " + LINE);
            Thread.sleep(100);
        }
    }
}

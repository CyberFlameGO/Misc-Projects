package me.yochran.doxlol.exceptions;

public class InvalidDiscordTagException extends Exception {

    public InvalidDiscordTagException(String inputted) {
        super("Invalid discord tag! (" + inputted + ")");
    }
}

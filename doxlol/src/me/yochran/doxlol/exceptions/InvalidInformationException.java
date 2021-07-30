package me.yochran.doxlol.exceptions;

public class InvalidInformationException extends Exception {

    public InvalidInformationException(int enteredSize) {
        super("Invalid information entered! (" + enteredSize + "=/=" + "7");
    }

    public InvalidInformationException() {
        super("Invalid information entered!");
    }
}

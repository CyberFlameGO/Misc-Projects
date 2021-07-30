package me.yochran.doxlol.exceptions;

public class HumanAlreadyExistsException extends Exception {

    public HumanAlreadyExistsException() {
        super("A human with that information already exists!");
    }
}

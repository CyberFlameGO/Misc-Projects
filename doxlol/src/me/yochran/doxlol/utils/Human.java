package me.yochran.doxlol.utils;

import me.yochran.doxlol.exceptions.HumanAlreadyExistsException;
import me.yochran.doxlol.exceptions.InvalidInformationException;
import me.yochran.doxlol.utils.world.Country;

import java.util.HashMap;
import java.util.Map;

public class Human {

    private String[] information;

    public static Map<Human, String[]> humans;

    static {
        humans = new HashMap<>();
    }

    public Human(String[] information) throws HumanAlreadyExistsException, InvalidInformationException {
        if (information.length != 7)
            throw new InvalidInformationException(information.length);

        this.information = information;

        if (humans.containsValue(this.information))
            throw new HumanAlreadyExistsException();

        humans.put(this, information);
    }

    public String[] getInformation() { return information; }

    public void setInformation(String[] information) { this.information = information; }

    public void replaceInformationEntry(int entry, String replacement) throws InvalidInformationException {
        if (this.information[entry] == null)
            throw new InvalidInformationException();
    }
}

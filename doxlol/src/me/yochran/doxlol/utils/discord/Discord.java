package me.yochran.doxlol.utils.discord;

import me.yochran.doxlol.exceptions.InvalidDiscordTagException;

public class Discord {

    public static DiscordUser getUserFromString(String entry) throws InvalidDiscordTagException {
        InvalidDiscordTagException exception = new InvalidDiscordTagException(entry);

        if (!entry.contains("#"))
            throw exception;

        String[] separated = entry.split("#");

        String username = separated[0];
        short tag;

        try { tag = Short.parseShort(separated[1]); }
        catch (NumberFormatException ignored) { throw exception; }

        return new DiscordUser(username, tag);
    }
}

package me.yochran.doxlol;

import me.yochran.doxlol.exceptions.InvalidDiscordTagException;
import me.yochran.doxlol.utils.IO;
import me.yochran.doxlol.utils.discord.Discord;
import me.yochran.doxlol.utils.discord.DiscordUser;

public class Main {

    public static void main(String[] args) throws InvalidDiscordTagException {
        IO.output("Dox program has loaded up.");

        String inputted = IO.input("Enter a discord tag (Name & Numbers): ");
        DiscordUser discordUser = Discord.getUserFromString(inputted);

        String ip = discordUser.getIP();

        IO.output(discordUser.getUsername() + "'s IP is: " + ip);
    }
}

package me.yochran.doxlol.utils.discord;

import java.util.Random;

public class DiscordUser {

    private String username;
    private int tag;

    public DiscordUser(String username, short tag) {
        this.username = username;
        this.tag = tag;
    }

    public String getUsername() { return username; }
    public int getTag() { return tag; }

    public String getIP() {
        int maxDigits = 3;

        StringBuilder first = new StringBuilder();
        StringBuilder second = new StringBuilder();
        StringBuilder third = new StringBuilder();
        StringBuilder fourth = new StringBuilder();

        for (int i = 0; i < Math.round(Math.random() * maxDigits); i++) {
            first.append(Math.round(Math.random() * 9));
            second.append(Math.round(Math.random() * 9));
            third.append(Math.round(Math.random() * 9));
            fourth.append(Math.round(Math.random() * 9));
        }

        return first.toString() + "." + second.toString() + "." + third.toString() + "." + fourth.toString();
    }
}

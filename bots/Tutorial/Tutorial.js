const Discord = require("discord.js");
const ChannelCommand = require("./commands/ChannelCommand");
const bot = new Discord.Client();

bot.once("ready", () => {
    console.log("Bot has loaded.");
});

bot.on("message", (msg) => {
    if (!msg.content.startsWith("!") || msg.author.bot) return;

    const args = msg.content.slice(1).trim().split(" ");
    const command = args.shift().toLowerCase();

    switch (command) {
        case "channel":
            ChannelCommand.Execute(msg, args);
            break;
    }
});

bot.login("");
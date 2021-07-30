const Discord = require("discord.js");
const bot = new Discord.Client();

const { MessageEmbed } = require("discord.js");

bot.on("ready", () => {
    console.log("Party animals started up. yay.");
    sendMessage();
    setInterval(() => {
        sendMessage();
    }, 1000 * 1800)
});

function sendMessage() {
    const guild = bot.guilds.cache.find(g => g.name.toLowerCase() === "champons domain");
    const channel = guild.channels.cache.find(c => c.id === "798053350103842827");
    channel.send(`Party Animals <@629745111684612128>`);
    const embed = new MessageEmbed()
    .setTitle("squish")
    .setDescription("squish")
    .addFields(
        {name: "squish", value: "squish", inline: true},
        {name: "squish", value: "squish", inline: true},
        {name: "squish", value: "squish", inline: true}
    )
    .setTimestamp()
    .setFooter("squish", "https://cdn.discordapp.com/avatars/270683949330726914/a4b009aaa7869d0db5897fdb263ada04.png?size=256")
    .setImage("https://cdn.discordapp.com/avatars/270683949330726914/a4b009aaa7869d0db5897fdb263ada04.png?size=256")
    .setThumbnail("https://cdn.discordapp.com/avatars/270683949330726914/a4b009aaa7869d0db5897fdb263ada04.png?size=256")
    .setAuthor("squish", "https://cdn.discordapp.com/avatars/270683949330726914/a4b009aaa7869d0db5897fdb263ada04.png?size=256", "https://cdn.discordapp.com/avatars/270683949330726914/a4b009aaa7869d0db5897fdb263ada04.png?size=256")
    .setDescription("squish")
    .setURL("https://cdn.discordapp.com/avatars/270683949330726914/a4b009aaa7869d0db5897fdb263ada04.png?size=256");

    channel.send(embed);
}

bot.login("");

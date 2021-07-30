module.exports = {
    Execute: function(msg, args) {
        if (args.length < 1) return msg.channel.send("Incorrect Usage! `^channel <name>`");

        var name = "";
        for (const word in args) {
            if (name === "") name = args[word];
            else name = name + "-" + args[word];
        }

        const category = msg.guild.channels.cache.find(ch => ch.id === "866141578778771476");

        if (category.type === "category") {
            msg.guild.channels.create(
                name,
                {type: "text"}
            ).then((channel) => {
                channel.setParent(category.id);

                channel.updateOverwrite(
                    msg.guild.roles.everyone,
                    {
                        "VIEW_CHANNEL": true,
                        "SEND_MESSAGES": false
                    }
                );
        
                setTimeout(() => {
                    channel.updateOverwrite(
                        msg.author,
                        {"SEND_MESSAGES": true}
                    )
                }, 50);
            });
    
            msg.channel.send("The channel " + name + " has been created.");
        }
    }
}
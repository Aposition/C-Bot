using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace Test.modules
{
    public class Misc : ModuleBase<SocketCommandContext>
    {
        [Command("Echo")]
        public async Task echo([Remainder]string message)
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("Echoed message");
            embed.WithDescription(message);
            embed.WithColor(new Color(255, 0, 0));

            await Context.Channel.SendMessageAsync("", false, embed);
        }

        [Command("pick")]
        public async Task Pick([Remainder]string message)
        {
            string[] options = message.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            Random r = new Random();
            string selection = options[r.Next(0, options.Length)];


            var embed = new EmbedBuilder();
            embed.WithTitle("Choice for " + Context.User.Username);
            embed.WithDescription(selection);
            embed.WithColor(new Color(105, 67, 145));
            embed.WithThumbnailUrl("https://goo.gl/rfVK1P");

            await Context.Channel.SendMessageAsync("", false, embed);
        }

        [Command("Choose")]
        public async Task Choose([Remainder]string message)
        {
            string[] options = message.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            Random r = new Random();
            string selection = options[r.Next(0, options.Length)];


            var embed = new EmbedBuilder();
            embed.WithTitle("Choice for " + Context.User.Username);
            embed.WithDescription(selection);
            embed.WithColor(new Color(105, 67, 145));
            embed.WithThumbnailUrl("https://mylittlepony.hasbro.com/images/pick_MLP_rainbowdash.png");

            await Context.Channel.SendMessageAsync("", false, embed);
        }

        [Command("smug")]
        public async Task smug(string message)
        {

            var embed = new EmbedBuilder();
            embed.WithTitle("Choice for " + Context.User.Username);
            embed.WithDescription(message);
            embed.WithColor(new Color(105, 67, 145));
            embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/423281486066745356/425505281670381568/2017-10-03_09.11.55.jpg");

            await Context.Channel.SendMessageAsync("Here", false, embed);
        }

    }
}
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JufBOT
{
    class Commands : BaseCommandModule
    {
        [Command("juf_retard")]
        public async Task JufRetard(CommandContext ctx) {
            await ctx.Channel.SendMessageAsync("To nechápu ").ConfigureAwait(false);
        }


        //Image commands
        [Command("nechapu")]
        public async Task Nechapu(CommandContext ctx)
        {
            var embed = new DiscordEmbedBuilder();
            Uri uri = new Uri("https://i.imgur.com/nlWXnmM.jpg");
            embed.WithImageUrl(uri);
            await ctx.Channel.SendMessageAsync("", embed).ConfigureAwait(false);
        }

        [Command("elektrikar")]
        public async Task Elektrikar(CommandContext ctx)
        {
            var embed = new DiscordEmbedBuilder();
            Uri uri = new Uri("https://www.fieldvibe.com/blog/wp-content/uploads/2019/11/aYYbARx_460swp.jpg");
            embed.WithImageUrl(uri);
            await ctx.Channel.SendMessageAsync("", embed).ConfigureAwait(false);
        }

        [Command("drzpicu")]
        public async Task DrzPicu(CommandContext ctx)
        {
            var embed = new DiscordEmbedBuilder();
            Uri uri = new Uri("https://i.imgur.com/M9SchOF.jpg");
            embed.WithImageUrl(uri);
            await ctx.Channel.SendMessageAsync("", embed).ConfigureAwait(false);
        }

        [Command("ojeb")]
        public async Task Ojeb(CommandContext ctx)
        {
            var embed = new DiscordEmbedBuilder();
            Uri uri = new Uri("https://i.imgur.com/yN1xpLm.png");
            embed.WithImageUrl(uri);
            await ctx.Channel.SendMessageAsync("", embed).ConfigureAwait(false);
        }

        [Command("picoviny")]
        public async Task Picoviny(CommandContext ctx)
        {
            var embed = new DiscordEmbedBuilder();
            Uri uri = new Uri("https://i.imgur.com/qcuk1Wm.jpg");
            embed.WithImageUrl(uri);
            await ctx.Channel.SendMessageAsync("", embed).ConfigureAwait(false);
        }

        [Command("krk")]
        public async Task Krk(CommandContext ctx)
        {
            var embed = new DiscordEmbedBuilder();
            Uri uri = new Uri("https://i.imgur.com/ls6AQVy.png");
            embed.WithImageUrl(uri);
            await ctx.Channel.SendMessageAsync("", embed).ConfigureAwait(false);
        }

        [Command("taktik")]
        public async Task Taktik(CommandContext ctx)
        {
            var embed = new DiscordEmbedBuilder();
            Uri uri = new Uri("https://i.imgur.com/IpmYskV.png");
            embed.WithImageUrl(uri);
            await ctx.Channel.SendMessageAsync("", embed).ConfigureAwait(false);
        }
    }
}

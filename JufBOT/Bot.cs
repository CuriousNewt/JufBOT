using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.EventArgs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace JufBOT
{
    class Bot
    {
        public DiscordClient client  { get; set; }

        public CommandsNextExtension commands { get; set; }

        public async Task Run() {
            var json = string.Empty;
            using (var fs = File.OpenRead("config.json"))
            using (var sr = new StreamReader(fs, new UTF8Encoding(false)))
                json = await sr.ReadToEndAsync().ConfigureAwait(false);

            var configJson = JsonConvert.DeserializeObject<configJSON>(json);

            var config = new DiscordConfiguration {
                Token = configJson.token,
                TokenType = TokenType.Bot,
                AutoReconnect = true

        };
            client = new DiscordClient(config);
            client.Ready += OnClientReady;

            var commandsConfig = new CommandsNextConfiguration {
                StringPrefixes = new string[] { configJson.prefix },
                EnableDms = false,
                EnableMentionPrefix = true
            };
            commands = client.UseCommandsNext(commandsConfig);
            commands.RegisterCommands<Commands>();
            await client.ConnectAsync();

            await Task.Delay(-1);
        }

        public Task OnClientReady(DiscordClient sender, ReadyEventArgs e) {
            return Task.CompletedTask;
        }
    }
}

public struct configJSON { 
    [JsonProperty("token")]
    public string token { get; private set; }

    [JsonProperty("prefix")]
    public string prefix { get; private set; }
}

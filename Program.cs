using System;
using System.Threading.Tasks;
using DSharpPlus;
namespace OsuIndiaBot
{
    class Program
    
    {
        static DiscordClient discord;

        static void Main(string[] args)
        {
            MainAsync(args).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        static async Task MainAsync(string[] args)
        {
            discord = new DiscordClient(new DiscordConfiguration
            {
                Token = "<Bot Token>",
                TokenType = TokenType.Bot
            });

            discord.MessageCreated += async e =>
            {
                if (e.Message.Content.ToLower().StartsWith("$ping"))
                    await e.Message.RespondAsync("pong!");
            };

            discord.MessageCreated += async e =>
            
            {
                if (e.Message.Content.ToLower().StartsWith("$8pool"))
                  
                 {
                     Random random = new Random();
                     var rnd = random.Next(1, 5);
                 if(rnd==1)
                 {
                     await e.Message.RespondAsync("Yes!");
                 }
                  if(rnd==2)
                 {
                     await e.Message.RespondAsync("Maybe?");
                 }
                  if(rnd==3)
                 {
                     await e.Message.RespondAsync("Hmmmmmmm");
                 }
                  if(rnd==4)
                 {
                     await e.Message.RespondAsync("I press X... I doubt");
                 }
                  if(rnd==5)
                 {
                     await e.Message.RespondAsync("No!");
                 }
                 }
            };

            await discord.ConnectAsync();
            await Task.Delay(-1);
        }
    }
}

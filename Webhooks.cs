using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lumina
{
    class Webhooks
    {
        public static void WebhookLaunch()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"Launching software...\", \"title\":\"\", \"color\":6618908}]  }"
            );
        }
        public static void KillingProcessHook()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"Killing roblox to reconnect...\", \"title\":\"\", \"color\":25424691}]  }"
            );
        }

        public static void ReconnectingRoblox()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"Reconnecting to private server...\", \"title\":\"\", \"color\":7221041}]  }"
            );
        }

        public static void WebhookReset()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"Reset Character\", \"title\":\"\", \"color\":16723502}]  }"
            );
        }

        public static void WebhookCollecting()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"Collecting Items\", \"title\":\"\", \"color\":1184274}]  }"
            );
        }

        public static void WebhookResetCharacter()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"Resetting Character Position\", \"title\":\"\", \"color\":2039583}]  }"
            );
        }

        public static void WebhookMovingToArea()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"Moving to next area\", \"title\":\"\", \"color\":6284940}]  }"
            );
        }

        public static void WebhookJack()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"Moving to Jake's Workshop\", \"title\":\"\", \"color\":16774912}]  }"
            );
        }

        public static void WebhookPermaFrost()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"You rolled Permafrost...\", \"title\":\"**Rare Found: 1 IN 24,500**\", \"color\":8322783}]  }"
            );
        }

        public static void WebhookFlushed()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"You rolled Flushed : Lobotomy...\", \"title\":\"**Rare Found: 1 IN 69,000**\", \"color\":16754944}]  }"
            );
        }

        public static void WebhookUndead()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"You rolled Undead...\", \"title\":\"**Rare Found: 1 IN 10,000**\", \"color\":494848}]  }"
            );
        }

        public static void WebhookAquatic()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"You rolled Aquatic...\", \"title\":\"**Rare Found: 1 IN 40,000**\", \"color\":4949238}]  }"
            );
        }

        public static void WebhookNautilus()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"You rolled Nautilus...\", \"title\":\"**Rare Found: 1 IN 70,000**\", \"color\":5464061}]  }"
            );
        }

        public static void WebhookExotic()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"You rolled Exotic...\", \"title\":\"**Rare Found: 1 IN 99,999**\", \"color\":3720154}]  }"
            );
        }

        public static void WebhookJade()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"You rolled Jade...\", \"title\":\"**Rare Found: 1 IN 125,000**\", \"color\":616247}]  }"
            );
        }

        public static void WebhookBounded()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"You rolled Bounded...\", \"title\":\"**Rare Found: 1 IN 200,000**\", \"color\":2447359}]  }"
            );
        }

        public static void WebhookCelestial()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"You rolled Celestial...\", \"title\":\"**Rare Found: 1 IN 350,000**\", \"color\":9937151}]  }"
            );
        }

        public static void WebhookKyawthuite()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"You rolled Kyawthuite...\", \"title\":\"**Rare Found: 1 IN 850,000**\", \"color\":2627217}]  }"
            );
        }

        public static void WebhookArcane()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"You rolled Arcane...\", \"title\":\"**Rare Found: 1 IN 1,000,000**\", \"color\":4950783}]  }"
            );
        }

        public static void WebhookGravitational()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"You rolled Gravitational...\", \"title\":\"**Rare Found: 1 IN 2,000,000**\", \"color\":8807414}]  }"
            );
        }

        public static void WebhookVirtual()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"You rolled Virtual...\", \"title\":\"**Rare Found: 1 IN 2,500,000**\", \"color\":4950783}]  }"
            );
        }

        public static void WebhookComet()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"You rolled Comet...\", \"title\":\"**Rare Found: 1 IN 12,000**\", \"color\":12242682}]  }"
            );
        }

        public static void WebhookGalaxy()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"You rolled Galaxy...\", \"title\":\"**Rare Found: 1 IN 500,000**\", \"color\":8807414}]  }"
            );
        }

        public static void WebhookStarscourge()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"You rolled Starscourge...\", \"title\":\"**Rare Found: 1 IN 1,000,000**\", \"color\":15697796}]  }"
            );
        }
        public static void WebhookTwilight()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"You rolled Twilight...\", \"title\":\"**Rare Found: 1 IN 600,000**\", \"color\":8807414}]  }"
            );
        }
        public static void WebhookStormal()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"You rolled Stormal...\", \"title\":\"**Rare Found: 1 IN 30,000**\", \"color\":9079434}]  }"
            );
        }
    }
}

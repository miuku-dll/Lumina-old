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
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"You rolled Permafrost...\", \"title\":\"\", \"color\":6618908}]  }"
            );
        }

        public static void WebhookFlushed()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"You rolled Flushed : Lobotomy...\", \"title\":\"\", \"color\":6618908}]  }"
            );
        }

        public static void WebhookUndead()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"You rolled Undead...\", \"title\":\"\", \"color\":6618908}]  }"
            );
        }

        public static void WebhookAquatic()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"You rolled Aquatic...\", \"title\":\"\", \"color\":6618908}]  }"
            );
        }

        public static void WebhookNautilus()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"You rolled Nautilus...\", \"title\":\"\", \"color\":6618908}]  }"
            );
        }

        public static void WebhookExotic()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"You rolled Exotic...\", \"title\":\"\", \"color\":6618908}]  }"
            );
        }

        public static void WebhookJade()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"You rolled Jade...\", \"title\":\"\", \"color\":6618908}]  }"
            );
        }

        public static void WebhookBounded()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"You rolled Bounded...\", \"title\":\"\", \"color\":6618908}]  }"
            );
        }

        public static void WebhookCelestial()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"You rolled Celestial...\", \"title\":\"\", \"color\":6618908}]  }"
            );
        }

        public static void WebhookKyawthuite()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"You rolled Kyawthuite...\", \"title\":\"\", \"color\":6618908}]  }"
            );
        }

        public static void WebhookArcane()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"You rolled Arcane...\", \"title\":\"\", \"color\":6618908}]  }"
            );
        }

        public static void WebhookGravitational()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"You rolled Gravitational...\", \"title\":\"\", \"color\":6618908}]  }"
            );
        }

        public static void WebhookVirtual()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"You rolled Virtual...\", \"title\":\"\", \"color\":6618908}]  }"
            );
        }

        public static void WebhookComet()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"You rolled Comet...\", \"title\":\"\", \"color\":6618908}]  }"
            );
        }

        public static void WebhookGalaxy()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"You rolled Galaxy...\", \"title\":\"\", \"color\":6618908}]  }"
            );
        }

        public static void WebhookStarscourge()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"You rolled Starscourge...\", \"title\":\"\", \"color\":6618908}]  }"
            );
        }
        public static void WebhookTwilight()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"You rolled Twilight...\", \"title\":\"\", \"color\":6618908}]  }"
            );
        }
        public static void WebhookStormal()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"You rolled Stormal...\", \"title\":\"**Rare Found: 1 IN 30,000**\", \"color\":6618908}]  }"
            );
        }
    }
}

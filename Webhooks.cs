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

        public static void WebhookStart()
        {
            Util.sendDiscordWebhook(
                File.ReadAllText(@"./config/Webhook.txt"),
                "{\"username\": \"Sute's Macro\",\"embeds\":[    {\"description\":\"Starting macro...\", \"title\":\"\", \"color\":6618908}]  }"
            );
        }
    }
}

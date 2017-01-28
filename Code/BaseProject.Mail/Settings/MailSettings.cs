using System.Configuration;

namespace BaseProject.Modules.Mail.Settings
{
    public class MailSettings : ConfigurationSection
    {
        private static readonly MailSettings settings = ConfigurationManager.GetSection("MailSettings") as MailSettings;
        public static MailSettings Settings { get { return settings; } }

        [ConfigurationProperty("SenderEmail", DefaultValue = "olliecaine@gmail.com")]
        public string SenderEmail
        {
            get { return (string)this["SenderEmail"]; }
            set { this["SenderEmail"] = value; }
        }

        [ConfigurationProperty("SenderName", DefaultValue = "Ollie")]
        public string SenderName
        {
            get { return (string)this["SenderName"]; }
            set { this["SenderName"] = value; }
        }

        [ConfigurationProperty("MailPickupDirectory", DefaultValue = "c:\\mail-pickup-directory")]
        public string MailPickupDirectory
        {
            get { return (string)this["MailPickupDirectory"]; }
            set { this["MailPickupDirectory"] = value; }
        }
    }
}
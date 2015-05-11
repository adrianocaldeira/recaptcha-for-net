using System.Configuration;

namespace Recaptcha4Net
{
    /// <summary>
    ///     Recaptcha Configuration
    /// </summary>
    public static class Configuration
    {
        static Configuration()
        {
            var configurationSection = (ConfigurationSection) ConfigurationManager.GetSection("recaptcha");

            Secret = configurationSection.Secret;
            VerifyUrl = configurationSection.VerifyUrl;
            Site = configurationSection.Site;

            if (string.IsNullOrWhiteSpace(VerifyUrl))
            {
                VerifyUrl = "https://www.google.com/recaptcha/api/siteverify";
            }
        }

        /// <summary>
        ///     Get secret key
        /// </summary>
        public static string Secret { get; private set; }

        /// <summary>
        ///     Get site key
        /// </summary>
        public static string Site { get; private set; }

        /// <summary>
        ///     Get verify url
        /// </summary>
        public static string VerifyUrl { get; private set; }
    }
}
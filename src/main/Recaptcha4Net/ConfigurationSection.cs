using System.Configuration;

namespace Recaptcha4Net
{
    /// <summary>
    ///     Configuration Section
    /// </summary>
    public class ConfigurationSection : System.Configuration.ConfigurationSection
    {
        /// <summary>
        ///     Get or set secret key
        /// </summary>
        [ConfigurationProperty("secret", IsRequired = true)]
        public string Secret
        {
            get { return (string) base["secret"]; }
            set { base["secret"] = value; }
        }

        /// <summary>
        ///     Get or set site key
        /// </summary>
        [ConfigurationProperty("site", IsRequired = true)]
        public string Site
        {
            get { return (string)base["site"]; }
            set { base["site"] = value; }
        }

        /// <summary>
        ///     Get or set verify url
        /// </summary>
        [ConfigurationProperty("verifyUrl")]
        public string VerifyUrl
        {
            get { return (string) base["verifyUrl"]; }
            set { base["verifyUrl"] = value; }
        }
    }
}
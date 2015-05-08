using System.Web;

namespace Recaptcha4Net
{
    /// <summary>
    ///     Recaptcha Request
    /// </summary>
    public class RecaptchaRequest
    {
        private string _remoteIp;
        private string _response;

        /// <summary>
        ///     Initializa new instance of classe <see cref="RecaptchaRequest" />
        /// </summary>
        public RecaptchaRequest()
        {
            Secret = Configuration.Secret;
        }

        /// <summary>
        ///     Get or set the shared key between your site and reCAPTCHA
        /// </summary>
        public string Secret { get; set; }

        /// <summary>
        ///     Get the user response token provided by the reCAPTCHA to the user and provided to your site on
        /// </summary>
        public string Response
        {
            get
            {
                if (_response == null && HttpContext.Current != null)
                {
                    _response = HttpContext.Current.Request.Form["g-recaptcha-response"];
                }

                return _response;
            }
        }

        /// <summary>
        ///     Get remote user ip
        /// </summary>
        public string RemoteIp
        {
            get
            {
                if (_remoteIp == null && HttpContext.Current != null)
                {
                    _remoteIp = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] ??
                                HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
                }

                return _remoteIp;
            }
        }
    }
}
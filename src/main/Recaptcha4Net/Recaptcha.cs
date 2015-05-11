using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Recaptcha4Net
{
    /// <summary>
    ///     Recaptcha
    /// </summary>
    public static class Recaptcha
    {
        /// <summary>
        ///     Verify recaptcha
        /// </summary>
        /// <returns>
        ///     <see cref="RecaptchaResponse" />
        /// </returns>
        public static RecaptchaResponse Verify()
        {
            return Verify(new RecaptchaRequest());
        }

        /// <summary>
        ///     Verify recaptcha
        /// </summary>
        /// <param name="request">
        ///     <see cref="RecaptchaRequest" />
        /// </param>
        /// <returns>
        ///     <see cref="RecaptchaResponse" />
        /// </returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static RecaptchaResponse Verify(RecaptchaRequest request)
        {
            if (request == null) throw new ArgumentNullException("request");

            using (var client = new WebClient())
            {
                var data = string.Format("secret={0}&response={1}&remoteip={2}", request.Secret, request.Response,
                    request.RemoteIp);
                var serializer = new DataContractJsonSerializer(typeof (RecaptchaResponse));

                client.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded;");

                var result = client.UploadString(Configuration.VerifyUrl, data);

                using (var ms = new MemoryStream(Encoding.ASCII.GetBytes(result)))
                {
                    return serializer.ReadObject(ms) as RecaptchaResponse;
                }
            }
        }
    }
}
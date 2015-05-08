using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Recaptcha4Net
{
    public static class Recaptcha
    {
        public static RecaptchaResponse Verify()
        {
            return Verify(new RecaptchaRequest());
        }

        public static RecaptchaResponse Verify(RecaptchaRequest request)
        {
            if (request == null) throw new ArgumentNullException("request");

            using (var client = new WebClient())
            {
                var data = string.Format("secret={0}&response={1}&remoteip={2}", request.Secret, request.Response, request.RemoteIp);
                var serializer = new DataContractJsonSerializer(typeof(RecaptchaResponse));

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
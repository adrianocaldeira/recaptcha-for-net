using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Recaptcha4Net
{
    /// <summary>
    ///     Recaptcha Response
    /// </summary>
    [DataContract]
    public class RecaptchaResponse
    {
        [DataMember(Name = "error-codes")] private List<string> _errorCodes = null;
        private IDictionary<string, string> _errors;

        /// <summary>
        ///     Get or set success information
        /// </summary>
        [DataMember(Name = "success")]
        public bool Success { get; set; }

        /// <summary>
        ///     Get errors
        /// </summary>
        public IDictionary<string, string> Errors
        {
            get
            {
                if (_errors != null) return _errors;

                _errors = new Dictionary<string, string>();

                if (_errorCodes == null || !_errorCodes.Any()) return _errors;

                if (_errorCodes.Contains("missing-input-secret"))
                    _errors.Add("missing-input-secret", "The secret parameter is missing.");

                if (_errorCodes.Contains("invalid-input-secret"))
                    _errors.Add("invalid-input-secret", "The secret parameter is invalid or malformed.");

                if (_errorCodes.Contains("missing-input-response"))
                    _errors.Add("missing-input-response", "The response parameter is missing.");

                if (_errorCodes.Contains("invalid-input-response"))
                    _errors.Add("invalid-input-response", "The response parameter is invalid or malformed.");

                return _errors;
            }
        }
    }
}
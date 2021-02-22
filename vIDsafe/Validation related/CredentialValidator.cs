﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vIDsafe
{
    public class CredentialValidator : DetailValidator
    {
        /// <summary>
        /// Checks if the URL, username and password are valid
        /// </summary>
        /// <returns>
        /// True if valid, false if not
        /// </returns>
        public static bool IsValid(string URL, string username, string password)
        {
            if (ValidateURL(URL))
            {
                if (ValidateUsername(username))
                {
                    if (ValidatePassword(password))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Checks if the URL is valid
        /// </summary>
        /// <returns>
        /// True if valid, false if not
        /// </returns>
        private static bool ValidateURL(string URL)
        {
            if (string.IsNullOrEmpty(URL))
            {
                ShowError("Validation error", "Please enter a URL");
                return false;
            }
            else
            {
                bool result = Uri.TryCreate(URL, UriKind.Absolute, out Uri uriResult)
                && (uriResult.Scheme.Equals(Uri.UriSchemeHttp) || uriResult.Scheme.Equals(Uri.UriSchemeHttps));

                if (result)
                {
                    return true;
                }
                else
                {
                    ShowError("Validation error", "Invalid URL format");
                    return false;
                }
            }
        }
    }
}

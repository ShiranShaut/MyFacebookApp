using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace HoroscopeController
{
    public delegate string GetHoroscopeTextDelegate(string i_Data, string i_ZodiacSign);

    public abstract class ZodiacSign
    {
        protected readonly string r_SignName = null;
        protected readonly string r_DailyHoroscopeWebUrl = "https://www.astrology.com/horoscope/daily/today/";
        protected readonly string r_MatchHoroscopeWebUrl = "https://www.astrology.com/love/compatibility/";
        protected readonly List<string> r_MatchPartners = new List<string>();
        protected string m_SignPhotoUrl;
        
        public string SignName
        {
            get { return r_SignName; }
        }

        public string SignPhotoUrl
        {
            get { return m_SignPhotoUrl; }
        }

        public List<string> MatchPartners
        {
            get { return r_MatchPartners; }
        }

        public ZodiacSign(string i_SignName)
        {
            r_SignName = i_SignName;
        }

        protected void setPhotoUrl(string i_ZodiacSign)
        {
            string directory = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString();

            m_SignPhotoUrl = directory + "\\Resources\\" + i_ZodiacSign + ".jpg";
        }

        protected abstract void addMatchPartners();

        public abstract string SetWebUrlBySignAndGetDailyHoroscope();

        public abstract string SetWebUrlBySignAndGetDescriptionOnMatch(string i_PartnerZodiacSign);

        protected string GetHoroscope(string i_ZodiacSign, string i_WebUrl, GetHoroscopeTextDelegate i_GetHoroscopeTextMethod)
        {
            string webData = (new System.Net.WebClient()).DownloadString(i_WebUrl);

            return i_GetHoroscopeTextMethod(webData, i_ZodiacSign);
        }

        protected string ConvertDailyHoroscopeHtmlToPlainText(string i_Data, string i_ZodiacSign)
        {
            StringBuilder regularExpressionPattern = new StringBuilder();
            string plainTextString = null;

            regularExpressionPattern.Append("(?<=<i class=");
            regularExpressionPattern.Append("\"icon-");
            regularExpressionPattern.Append(i_ZodiacSign);
            regularExpressionPattern.Append(" bg sign-color\"");
            regularExpressionPattern.Append("></i>\r\n  <p>)[^<]+");

            try
            {
                var regex = new Regex(regularExpressionPattern.ToString(), RegexOptions.Singleline);
                Match plainText = regex.Match(i_Data);
                plainTextString = plainText.Value;
            }
            catch (Exception ex)
            {
                plainTextString = @"The server not availeble right now.
Please try later.";
            }

            return plainTextString;
        }
        
        protected string ConvertMatchHoroscopeHtmlToPlainText(string i_Data, string i_PartnerSign)
        {
            StringBuilder regularExpressionPattern = new StringBuilder();
            string plainTextString = null;

            regularExpressionPattern.Append("(?<=</div> <!-- /row -->\\r\\n\\t\\t\\t\\t\\t\\t<p>)(.*?)(?=</p>)");

            try
            {
                var regex = new Regex(regularExpressionPattern.ToString(), RegexOptions.Singleline);
                Match plainText = regex.Match(i_Data);
                plainTextString = plainText.Value.Replace("<br>", string.Empty).Replace("ג€™", "'").Replace(";", ".");
            }
            catch(Exception ex)
            {
                plainTextString = @"The server not availeble right now.
Please try later.";
            }

            return plainTextString;
        }
    }
}
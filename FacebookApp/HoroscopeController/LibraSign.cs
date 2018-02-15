using System;
using System.Text;
using System.Text.RegularExpressions;

namespace HoroscopeController
{
    internal class LibraSign : ZodiacSign
    {
        public LibraSign() : base("Libra")
        {
            setPhotoUrl("libra");
            addMatchPartners();
        }

        protected override void addMatchPartners()
        {
            r_MatchPartners.Add("Aquarius");
            r_MatchPartners.Add("Gemini");
            r_MatchPartners.Add("Leo");
            r_MatchPartners.Add("Sagittarus");
        }
        
        public override string SetWebUrlBySignAndGetDailyHoroscope()
        {
            string websiteUrl = r_DailyHoroscopeWebUrl + "libra.html";

            return GetHoroscope("libra", websiteUrl, ConvertDailyHoroscopeHtmlToPlainText);
        }

        public override string SetWebUrlBySignAndGetDescriptionOnMatch(string i_PartnerZodiacSign)
        {
            string websiteUrl = r_MatchHoroscopeWebUrl + "libra-" + i_PartnerZodiacSign + ".html";

            return GetHoroscope(i_PartnerZodiacSign, websiteUrl, ConvertMatchHoroscopeHtmlToPlainText);
        }
    }
}

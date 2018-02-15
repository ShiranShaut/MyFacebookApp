using System;
using System.Text;
using System.Text.RegularExpressions;

namespace HoroscopeController
{
    internal class VirgoSign : ZodiacSign
    {         
        public VirgoSign() : base("Virgo")
        {
            setPhotoUrl("virgo");
            addMatchPartners(); 
        }

        protected override void addMatchPartners()
        {
            r_MatchPartners.Add("Capricorn");
            r_MatchPartners.Add("Taurus");
            r_MatchPartners.Add("Scorpio");
        }

        public override string SetWebUrlBySignAndGetDailyHoroscope()
        {
            string websiteUrl = r_DailyHoroscopeWebUrl + "virgo.html";

            return GetHoroscope("virgo", websiteUrl, ConvertDailyHoroscopeHtmlToPlainText);
        }

        public override string SetWebUrlBySignAndGetDescriptionOnMatch(string i_PartnerZodiacSign)
        {
            string websiteUrl = r_MatchHoroscopeWebUrl + "virgo-" + i_PartnerZodiacSign + ".html";

            return GetHoroscope(i_PartnerZodiacSign, websiteUrl, ConvertMatchHoroscopeHtmlToPlainText);
        }
    }
}

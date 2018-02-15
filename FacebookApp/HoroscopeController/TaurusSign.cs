using System;
using System.Text;
using System.Text.RegularExpressions;

namespace HoroscopeController
{
    internal class TaurusSign : ZodiacSign
    {
        public TaurusSign() : base("Taurus")
        {
            setPhotoUrl("taurus");
            addMatchPartners();
        }

        protected override void addMatchPartners()
        {
            r_MatchPartners.Add("Capricorn");
            r_MatchPartners.Add("Virgo");
        }
        
        public override string SetWebUrlBySignAndGetDailyHoroscope()
        {
            string websiteUrl = r_DailyHoroscopeWebUrl + "taurus.html";

            return GetHoroscope("taurus", websiteUrl, ConvertDailyHoroscopeHtmlToPlainText);
        }

        public override string SetWebUrlBySignAndGetDescriptionOnMatch(string i_PartnerZodiacSign)
        {
            string websiteUrl = r_MatchHoroscopeWebUrl + "taurus-" + i_PartnerZodiacSign + ".html";

            return GetHoroscope(i_PartnerZodiacSign, websiteUrl, ConvertMatchHoroscopeHtmlToPlainText);
        }
    }
}

using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace HoroscopeController
{
    internal class ScorpioSign : ZodiacSign
    {
        public ScorpioSign() : base("Scorpio")
        {
            setPhotoUrl("scorpio");
            addMatchPartners();
        }

        protected override void addMatchPartners()
        {
            r_MatchPartners.Add("Pisces");
            r_MatchPartners.Add("Cancer");
            r_MatchPartners.Add("Virgo");
        }
        
        public override string SetWebUrlBySignAndGetDailyHoroscope()
        {
            string websiteUrl = r_DailyHoroscopeWebUrl + "scorpio.html";

            return GetHoroscope("scorpio", websiteUrl, ConvertDailyHoroscopeHtmlToPlainText);
        }

        public override string SetWebUrlBySignAndGetDescriptionOnMatch(string i_PartnerZodiacSign)
        {
            string websiteUrl = r_MatchHoroscopeWebUrl + "scorpio-" + i_PartnerZodiacSign + ".html";

            return GetHoroscope(i_PartnerZodiacSign, websiteUrl, ConvertMatchHoroscopeHtmlToPlainText);
        }
    }
}

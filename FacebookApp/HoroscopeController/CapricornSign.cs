using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace HoroscopeController
{
    internal class CapricornSign : ZodiacSign
    {
        public CapricornSign() : base("Capricorn")
        {
            setPhotoUrl("capricorn");
            addMatchPartners();
        }

        protected override void addMatchPartners()
        {
            r_MatchPartners.Add("Pisces");
            r_MatchPartners.Add("Taurus");
            r_MatchPartners.Add("Virgo");
            r_MatchPartners.Add("Capricorn");
        }
        
        public override string SetWebUrlBySignAndGetDailyHoroscope()
        {
            string websiteUrl = r_DailyHoroscopeWebUrl + "capricorn.html";

            return GetHoroscope("capricorn", websiteUrl, ConvertDailyHoroscopeHtmlToPlainText);
        }

        public override string SetWebUrlBySignAndGetDescriptionOnMatch(string i_PartnerZodiacSign)
        {
            string websiteUrl = r_MatchHoroscopeWebUrl + "capricorn-" + i_PartnerZodiacSign + ".html";

            return GetHoroscope(i_PartnerZodiacSign, websiteUrl, ConvertMatchHoroscopeHtmlToPlainText);
        }
    }
}

using System;
using System.Text.RegularExpressions;
using System.Text;
using System.IO;

namespace HoroscopeController
{
    internal class AriesSign : ZodiacSign
    {
        public AriesSign() : base("Aries")
        {
            setPhotoUrl("aries");
            addMatchPartners();
        }

        protected override void addMatchPartners()
        {
            r_MatchPartners.Add("Leo");
            r_MatchPartners.Add("Sagittarus");
        }
        
        public override string SetWebUrlBySignAndGetDailyHoroscope()
        {
            string websiteUrl = r_DailyHoroscopeWebUrl + "aries.html";

            return GetHoroscope("aries", websiteUrl, ConvertDailyHoroscopeHtmlToPlainText);
        }

        public override string SetWebUrlBySignAndGetDescriptionOnMatch(string i_PartnerZodiacSign)
        {
            string websiteUrl = r_MatchHoroscopeWebUrl + "aries-" + i_PartnerZodiacSign + ".html";

            return GetHoroscope(i_PartnerZodiacSign, websiteUrl, ConvertMatchHoroscopeHtmlToPlainText);
        }
    }
}

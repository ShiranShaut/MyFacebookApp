using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace HoroscopeController
{
    internal class CancerSign : ZodiacSign
    {
        public CancerSign() : base("Cancer")
        {
            setPhotoUrl("cancer");
            addMatchPartners();
        }

        protected override void addMatchPartners()
        {
            r_MatchPartners.Add("Pisces");
            r_MatchPartners.Add("Scorpio");
        }
        
        public override string SetWebUrlBySignAndGetDailyHoroscope()
        {
            string websiteUrl = r_DailyHoroscopeWebUrl + "cancer.html";

            return GetHoroscope("cancer", websiteUrl, ConvertDailyHoroscopeHtmlToPlainText);
        }

        public override string SetWebUrlBySignAndGetDescriptionOnMatch(string i_PartnerZodiacSign)
        {
            string websiteUrl = r_MatchHoroscopeWebUrl + "cancer-" + i_PartnerZodiacSign + ".html";

            return GetHoroscope(i_PartnerZodiacSign, websiteUrl, ConvertMatchHoroscopeHtmlToPlainText);
        }
    }
}

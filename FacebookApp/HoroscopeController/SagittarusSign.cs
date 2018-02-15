using System;
using System.Text;
using System.Text.RegularExpressions;

namespace HoroscopeController
{
    internal class SagittarusSign : ZodiacSign
    {
        public SagittarusSign() : base("Sagittarus")
        {
            setPhotoUrl("sagittarus");
            addMatchPartners();
        }

        protected override void addMatchPartners()
        {
            r_MatchPartners.Add("Libra");
            r_MatchPartners.Add("Leo");
            r_MatchPartners.Add("Aries");
        }
        
        public override string SetWebUrlBySignAndGetDailyHoroscope()
        {
            string websiteUrl = r_DailyHoroscopeWebUrl + "sagittarus.html";

            return GetHoroscope("sagittarus", websiteUrl, ConvertDailyHoroscopeHtmlToPlainText);
        }

        public override string SetWebUrlBySignAndGetDescriptionOnMatch(string i_PartnerZodiacSign)
        {
            string websiteUrl = r_MatchHoroscopeWebUrl + "sagittarus-" + i_PartnerZodiacSign + ".html";

            return GetHoroscope(i_PartnerZodiacSign, websiteUrl, ConvertMatchHoroscopeHtmlToPlainText);
        }
    }
}

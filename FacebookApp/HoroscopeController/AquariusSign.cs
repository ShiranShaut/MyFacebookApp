using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace HoroscopeController
{
    internal class AquariusSign : ZodiacSign
    {
        public AquariusSign() : base("Aquarius")
        {
            setPhotoUrl("aquarius");
            addMatchPartners();
        }

        protected override void addMatchPartners()
        {
            r_MatchPartners.Add("Pisces");
            r_MatchPartners.Add("Libra");
        }

        public override string SetWebUrlBySignAndGetDailyHoroscope()
        {
            string websiteUrl = r_DailyHoroscopeWebUrl + "aquarius.html";

            return GetHoroscope("aquarius", websiteUrl, ConvertDailyHoroscopeHtmlToPlainText);
        }

        public override string SetWebUrlBySignAndGetDescriptionOnMatch(string i_PartnerZodiacSign)
        {
            string websiteUrl = r_MatchHoroscopeWebUrl + "aquarius-" + i_PartnerZodiacSign + ".html";

            return GetHoroscope(i_PartnerZodiacSign, websiteUrl, ConvertMatchHoroscopeHtmlToPlainText);
        }
    }
}
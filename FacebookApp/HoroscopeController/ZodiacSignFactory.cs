namespace HoroscopeController
{
    public static class ZodiacSignFactory
    {
        public static ZodiacSign GetZodiacSignByDate(string i_Birthday)
        {
            ZodiacSign sign = null;
            string[] birthdayDate = i_Birthday.Split(new char[] { '/' });
            int day = int.Parse(birthdayDate[1]);
            int month = int.Parse(birthdayDate[0]);

            switch (month)
            {
                case 1:
                    {
                        if (day <= 19)
                        {
                            sign = new CapricornSign();
                        }
                        else
                        {
                            sign = new AquariusSign();
                        }

                        break;
                    }

                case 2:
                    {
                        if (day <= 18)
                        {
                            sign = new AquariusSign();
                        }
                        else
                        {
                            sign = new PiscesSign();
                        }

                        break;
                    }

                case 3:
                    {
                        if (day <= 20)
                        {
                            sign = new PiscesSign();
                        }
                        else
                        {
                            sign = new AriesSign();
                        }

                        break;
                    }

                case 4:
                    {
                        if (day <= 19)
                        {
                            sign = new AriesSign();
                        }
                        else
                        {
                            sign = new TaurusSign();
                        }

                        break;
                    }

                case 5:
                    {
                        if (day <= 20)
                        {
                            sign = new TaurusSign();
                        }
                        else
                        {
                            sign = new GeminiSign();
                        }

                        break;
                    }

                case 6:
                    {
                        if (day <= 21)
                        {
                            sign = new GeminiSign();
                        }
                        else
                        {
                            sign = new CancerSign();
                        }

                        break;
                    }

                case 7:
                    {
                        if (day <= 22)
                        {
                            sign = new CancerSign();
                        }
                        else
                        {
                            sign = new LeoSign();
                        }

                        break;
                    }

                case 8:
                    {
                        if (day <= 22)
                        {
                            sign = new LeoSign();
                        }
                        else
                        {
                            sign = new VirgoSign();
                        }

                        break;
                    }

                case 9:
                    {
                        if (day <= 22)
                        {
                            sign = new VirgoSign();
                        }
                        else
                        {
                            sign = new LibraSign();
                        }

                        break;
                    }

                case 10:
                    {
                        if (day <= 22)
                        {
                            sign = new LibraSign();
                        }
                        else
                        {
                            sign = new ScorpioSign();
                        }

                        break;
                    }

                case 11:
                    {
                        if (day <= 21)
                        {
                            sign = new ScorpioSign();
                        }
                        else
                        {
                            sign = new SagittarusSign();
                        }

                        break;
                    }

                case 12:
                    {
                        if (day <= 21)
                        {
                            sign = new SagittarusSign();
                        }
                        else
                        {
                            sign = new CapricornSign();
                        }

                        break;
                    }
            }

            return sign;
        }

        public static ZodiacSign GetZodiacSignBySign(string i_Sign)
        {
            ZodiacSign sign = null;

            switch(i_Sign.ToLower())
            {
                case "capricorn":
                    {
                        sign = new CapricornSign();
                        break;
                    }

                case "aquarius":
                    {
                        sign = new AquariusSign();
                        break;
                    }

                case "pisces":
                    {
                        sign = new PiscesSign();
                        break;
                    }

                case "aries":
                    {
                        sign = new AriesSign();
                        break;
                    }

                case "taurus":
                    {
                        sign = new TaurusSign();
                        break;
                    }

                case "gemini":
                    {
                        sign = new GeminiSign();
                        break;
                    }

                case "cancer":
                    {
                        sign = new CancerSign();
                        break;
                    }

                case "leo":
                    {
                        sign = new LeoSign();
                        break;
                    }

                case "virgo":
                    {
                        sign = new VirgoSign();
                        break;
                    }

                case "libra":
                    {
                        sign = new LibraSign();
                        break;
                    }

                case "scorpio":
                    {
                        sign = new ScorpioSign();
                        break;
                    }

                case "sagittarus":
                    {
                        sign = new SagittarusSign();
                        break;
                    }
            }

            return sign;
        }
    }
}

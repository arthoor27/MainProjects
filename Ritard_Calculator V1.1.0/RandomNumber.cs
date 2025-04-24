using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ritard_Calculator
{
    public class RandomNumber
    {
        public void RNumber(out string RandomString, out int RandomNumber, out bool outputvalue)
        {
            Random random = new Random();
            string str1 = ("نمیدانم اکبر جان ");
            string str2 = ("شگفت انگیزه");
            string str3 = ("غان غان غان غان غاننننننن ");
            string str4 = ("خابم میاد واقعیتش ");
            string str5 = ("سخته ");
            string str6 = ("بشینیم ی دست شطرنج بازی کنیم؟");
            string str7 = ("برو خونتون ");
            string[] StringList = { str1, str2, str3, str4, str5, str6, str7 };
            int IndexStringList = random.Next(StringList.Count());
            RandomString = StringList[IndexStringList];
            RandomNumber = random.Next(-10000, 10000);
            int SN = random.Next(3);
            switch (SN)
            {
                case 0:
                    outputvalue = false;
                    break;
                case 1:
                    outputvalue = true;
                    break;
                case 2:
                    outputvalue = false;
                    break;
                default:
                    outputvalue = true;
                    break;
                    //this switch is for show SN as a bool for betteer risults 
            }
        }
        public void RString(out string RamdomStringEm, out string RandomStringE)
        {
            Random random = new Random();
            string strE1 = (" درسته احمقم ولی احمق بودنم حدی داره  ");
            string strE2 = ("باید عدد وارد کنی!!!! ");
            string strE3 = ("مردکه چجوری اینی ک گفتی رو انجام بدم ؟");
            string strE4 = ("همینو تو گوگل سرچ کن جوابشو بهم بگو");
            string strEm1 = ("اکبر جون از من چه انتاری داری ؟");
            string strEm2 = ("خودم عدد بزارم ؟ چشم ! جوابت میشه منفی انتگرال ایکس به توان منفی ای ایکس  دی ایکس  ");
            string strEm3 = ("باباتو در میارم چی فک کردی  ");
            string[] StringEList = { strE1, strE2, strE3, strE4 };
            string[] StringEmList = { strEm1, strEm2, strEm3 };
            int IndexStringEList = random.Next(StringEList.Count());
            int IndexStringEmList = random.Next(StringEmList.Count());
            RandomStringE = StringEList[IndexStringEList];
            RamdomStringEm = StringEmList[IndexStringEmList];
        }
    }
}
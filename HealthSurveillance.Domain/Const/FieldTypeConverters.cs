using System;
using System.Collections.Generic;
using System.Text;

namespace HealthSurveillance.Domain.Converters
{
    public static class FieldTypeConverters
    {
        public static string FieldConverter(int type)
        {
            string result = "نامعلوم";

            switch (type)
            {
                case 1:
                    result = "رشته ای";
                    break;
                case 2:
                    result = "عددی";
                    break;
                case 3:
                    result = "بلی/خیر";
                    break;
                case 4:
                    result = "تقویم";
                    break;
                case 5:
                    result = "بارگزاری";
                    break;
                case 6:
                    result = "متن چندخطی";
                    break;
                case 7:
                    result = "لیست کشویی";
                    break;
                case 8:
                    result = "بازه ای";
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}

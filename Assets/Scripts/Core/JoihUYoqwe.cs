using System;
using System.Linq;
using UnityEngine;

namespace GYUikoqwlebh
{
    public static class JoihUYoqwe
    {
        public static string HUiohYiqweJIO(int jijaodiqwe)
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            if (jijaodiqwe > 999999999)
                return ">1B";
            if (jijaodiqwe > 999999)
                return $"{jijaodiqwe / 1000000},{jijaodiqwe / 100000 % 10}M";
            if (jijaodiqwe > 999)
                return $"{jijaodiqwe / 1000},{jijaodiqwe / 100 % 10:D1}K";

            return $"{jijaodiqwe}";
        }

        public static string JOIhIUqweqwe(int wqeqwed)
        {
            int po987ygbhnjkml = 350;
po987ygbhnjkml += (int)Vector3.zero.x * 15;
var dubeuwg4i12 = (float)po987ygbhnjkml * 2.2;
string pijhviuqowie1 = "tejzkbhjwe.asu" + dubeuwg4i12
.ToString();            return $"{wqeqwed / 60:D2}:{wqeqwed % 60:D2}";
        }
    }
}
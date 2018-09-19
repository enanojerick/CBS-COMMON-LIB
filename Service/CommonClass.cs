using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using CBS.Common.Services.Dto;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CBS.Common.Services.Service
{
    public static class CommonClass
    {

        public static string CreatePassword(int lower, int upper, int num, int special)
        {
            const string lowervalid = "abcdefghijklmnopqrstuvwxyz";

            const string uppervalid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            const string numvalid = "1234567890";

            const string specialchar = "!@#$%&+=";

            var totallength = special + num + upper + lower;

            StringBuilder res = new StringBuilder();

            Random rnd = new Random();

            while (0 < lower--)
            {
                res.Append(lowervalid[rnd.Next(lowervalid.Length)]);
            }

            while (0 < upper--)
            {
                res.Append(uppervalid[rnd.Next(uppervalid.Length)]);
            }

            while (0 < num--)
            {
                res.Append(numvalid[rnd.Next(numvalid.Length)]);
            }

            while (0 < special--)
            {
                res.Append(specialchar[rnd.Next(specialchar.Length)]);
            }

            return res.ToString();
        }

    }

   
}

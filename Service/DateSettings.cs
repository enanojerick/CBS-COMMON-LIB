using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CBS.Common.Services.Service
{
    public class DateSettings
    {

        #region DateCommonClass

        public static DateRange ThisYear(DateTime date)
        {
            DateRange range = new DateRange();

            range.Start = new DateTime(date.Year, 1, 1);
            range.End = range.Start.AddYears(1).AddSeconds(-1);

            return range;
        }

        public static DateRange LastYear(DateTime date)
        {
            DateRange range = new DateRange();

            range.Start = new DateTime(date.Year - 1, 1, 1);
            range.End = range.Start.AddYears(1).AddSeconds(-1);

            return range;
        }

        public static DateRange ThisMonth(DateTime date)
        {
            DateRange range = new DateRange();

            range.Start = new DateTime(date.Year, date.Month, 1);
            range.End = range.Start.AddMonths(1).AddSeconds(-1);

            return range;
        }

        public static DateRange LastMonth(DateTime date)
        {
            DateRange range = new DateRange();

            range.Start = (new DateTime(date.Year, date.Month, 1)).AddMonths(-1);
            range.End = range.Start.AddMonths(1).AddSeconds(-1);

            return range;
        }

        public static DateRange ThisWeek(DateTime date)
        {
            DateRange range = new DateRange();

            range.Start = date.Date.AddDays(-(int)date.DayOfWeek);
            range.End = range.Start.AddDays(7).AddSeconds(-1);

            return range;
        }

        public static DateRange LastWeek(DateTime date)
        {
            DateRange range = ThisWeek(date);

            range.Start = range.Start.AddDays(-7);
            range.End = range.End.AddDays(-7);

            return range;
        }

        public static DateRange SetDefaultDates(string datefrom, string dateto)
        {
            DateRange range = new DateRange();

            if (datefrom == "" || datefrom == null)
            {
                datefrom = "01/01/1990";
            }

            DateTime DateFromR = DateTime.ParseExact(datefrom, "M/d/yyyy", new CultureInfo("en-US"));
            DateTime DateToR = DateTime.Now;

            if (dateto != "" && dateto != null)
            {
                DateToR = DateTime.ParseExact(dateto, "M/d/yyyy", new CultureInfo("en-US"));
            }

            range.Start = DateFromR;
            range.End = DateToR;

            return range;

        }

        public static DateTime? ConvertStringToDate(string stringdate)
        {
            try
            {
                return DateTime.Parse(stringdate, new CultureInfo("en-US"));
            }
            catch (Exception)
            {
                return null;
            }
            
        }

        public static int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }
        #endregion


    }

    public class DateRange
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}

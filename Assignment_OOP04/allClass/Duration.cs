using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP04.allClass
{
    internal class Duration
    {
        #region Part02 

        #region Q1 
        public int Hours { get; private set; }
        public int Minutes { get; private set; }
        public int Seconds { get; private set; }
        #endregion

        #region Q2
        public override string ToString()
        {
            if (Hours > 0)
                return $"Hours: {Hours}, Minutes :{Minutes}, Seconds :{Seconds}";
            else if (Minutes > 0)
                return $"Minutes :{Minutes}, Seconds :{Seconds}";
            else
                return $"Seconds :{Seconds}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Duration other)
                return this.TotalSeconds() == other.TotalSeconds();
            return false;
        }

        public override int GetHashCode()
        {
            return TotalSeconds().GetHashCode();
        }
        #endregion

        #region Q3
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
            Normalize();
        }

        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            Minutes = (totalSeconds % 3600) / 60;
            Seconds = totalSeconds % 60;
        }
        #endregion

        #region Q4 
        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.TotalSeconds() + d2.TotalSeconds());
        }

        public static Duration operator +(Duration d1, int seconds)
        {
            return new Duration(d1.TotalSeconds() + seconds);
        }

        public static Duration operator +(int seconds, Duration d)
        {
            return new Duration(d.TotalSeconds() + seconds);
        }

        public static Duration operator ++(Duration d)
        {
            return new Duration(d.TotalSeconds() + 60);
        }

        public static Duration operator --(Duration d)
        {
            return new Duration(Math.Max(0, d.TotalSeconds() - 60));
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            return new Duration(Math.Max(0, d1.TotalSeconds() - d2.TotalSeconds()));
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() > d2.TotalSeconds();
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() < d2.TotalSeconds();
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() >= d2.TotalSeconds();
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() <= d2.TotalSeconds();
        }

        public static bool operator true(Duration d)
        {
            return d.TotalSeconds() > 0;
        }

        public static bool operator false(Duration d)
        {
            return d.TotalSeconds() == 0;
        }

        public static explicit operator DateTime(Duration d)
        {
            return new DateTime().AddSeconds(d.TotalSeconds());
        }
        #endregion

        #region Method
        private void Normalize()
        {
            if (Seconds >= 60)
            {
                Minutes += Seconds / 60;
                Seconds %= 60;
            }

            if (Minutes >= 60)
            {
                Hours += Minutes / 60;
                Minutes %= 60;
            }
        }

        private int TotalSeconds()
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
        }
        #endregion


        #endregion
    }
}

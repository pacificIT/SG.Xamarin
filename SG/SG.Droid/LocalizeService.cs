using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SG.Droid
{
    public class Localize: ILocalizeService
    {
        public void SetLocale( )
        {
            var locale = Java.Util.Locale.Default.ToString().Replace("_","-");
            var cultureInfo = new System.Globalization.CultureInfo(locale);

            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
        }

        public System.Globalization.CultureInfo GetCurrentCultureInfo( )
        {
            var language = Java.Util.Locale.Default.ToString().Replace("_","-");

            var cultureInfo = new System.Globalization.CultureInfo(language);
            return cultureInfo;
        }

        public string GetCurrent( )
        {
            var locale = Java.Util.Locale.Default;
            var language = locale.Language.Replace("_","-");
            var netLocale = locale.ToString().Replace("_","-");

            var cultureInfo = new System.Globalization.CultureInfo(netLocale);
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
            return netLocale;
        }
    }
}
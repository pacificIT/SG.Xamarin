using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Foundation;
using UIKit;
using Xamarin.Forms;


[assembly:Dependency(typeof(SG.iOS.Locale))]

namespace SG.iOS
{
    public class Locale: ILocalizeService
    {
        public void SetLocale ()
        {
            var iosLocaleAuto = NSLocale.AutoUpdatingCurrentLocale.LocaleIdentifier;
            var locale = iosLocaleAuto.Replace ("_", "-");
            System.Globalization.CultureInfo cultureInfo;
            try {
                cultureInfo = new System.Globalization.CultureInfo (locale);
            } catch {
                cultureInfo = new System.Globalization.CultureInfo (GetCurrent ());
            }
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
        }

        public string GetCurrent ()
        {
            var localeAuto = NSLocale.AutoUpdatingCurrentLocale.LocaleIdentifier;
            var languageAuto = NSLocale.AutoUpdatingCurrentLocale.LanguageCode;
            var locale = localeAuto.Replace ("_", "-");
            var language = languageAuto.Replace ("_", "-");
        
            System.Globalization.CultureInfo cultureInfo;
            try{
                cultureInfo = new System.Globalization.CultureInfo (locale);
            } catch {
                cultureInfo = new System.Globalization.CultureInfo (NSLocale.PreferredLanguages [0]);
            }
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;

            if (NSLocale.PreferredLanguages.Length > 0) 
            {
                var pref = NSLocale.PreferredLanguages [0];
                language = pref.Replace ("_", "-");                
            } else {
                language = "en"; 
            }
            return language;
        }
    }
}


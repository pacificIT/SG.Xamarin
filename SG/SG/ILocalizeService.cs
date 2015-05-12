using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SG
{
    public interface ILocalizeService
    {
        CultureInfo GetCurrentCultureInfo( );
        string GetCurrent( );
        void SetLocale( );
    }
}

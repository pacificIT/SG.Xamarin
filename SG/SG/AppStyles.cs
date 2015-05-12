using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SG
{
    public static class AppStyles
    {
        public static Color LightGrey = Color.FromHex("929292");
        public static Color DarkGrey = Color.FromHex("707070");

        public static Style LabelStyle
        {
            get
            {
                return new Style(typeof(Label))
                {
                    Setters = {
                        new Setter { Property = Label.FontSizeProperty, Value = 14 },
                        new Setter { Property = Label.TextColorProperty, Value = LightGrey },
                        new Setter { Property = Label.FontAttributesProperty,Value = FontAttributes.Bold }
                    }
                };
            }
        }
    }
}

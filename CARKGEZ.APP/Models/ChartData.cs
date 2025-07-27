
using CARKGEZ.APP.Helpers;
using SkiaSharp;
using SkiaSharp.Views.Maui;

namespace CARKGEZ.APP.Models
{
    public class ChartData
    {
        public string Text => $"{Constants.EmptySpaces}{Sector.Venue}";
        public SKColor Color => Microsoft.Maui.Graphics.Color.FromHex(Sector.Color).ToSKColor();

        public RotarySector Sector { get; set; }
    }
}

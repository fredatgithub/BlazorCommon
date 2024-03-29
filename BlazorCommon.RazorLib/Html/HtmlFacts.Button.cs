﻿using BlazorCommon.RazorLib.Dimensions;

namespace BlazorCommon.RazorLib.Html;

public static partial class HtmlFacts
{
    public static class Button
    {
        public const int PADDING_IN_PIXELS = 6;
        
        public static string ButtonPaddingHorizontalTotalInPixelsCssValue =>
            $"2 * {PADDING_IN_PIXELS.ToCssValue()}px";
    }
}
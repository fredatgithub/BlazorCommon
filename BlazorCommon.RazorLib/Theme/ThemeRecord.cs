﻿using System.Collections.Immutable;

namespace BlazorCommon.RazorLib.Theme;

public record ThemeRecord(
    ThemeKey ThemeKey,
    string DisplayName,
    string CssClassString,
    ThemeContrastKind ThemeContrastKind,
    ThemeColorKind ThemeColorKind,
    ImmutableList<ThemeScope> ThemeScopes);
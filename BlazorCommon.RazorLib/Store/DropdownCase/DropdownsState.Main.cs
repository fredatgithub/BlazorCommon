﻿using System.Collections.Immutable;
using BlazorCommon.RazorLib.Dropdown;
using Fluxor;

namespace BlazorCommon.RazorLib.Store.DropdownCase;

/// <summary>
/// <see cref="DropdownsState"/> can stay as a record.
/// The "avoid record value comparisons when Fluxor checks
/// if the <see cref="FeatureStateAttribute"/> has been replaced."
/// issue is not as pertinent here as the replacements are infrequent.
/// </summary>
[FeatureState]
public partial record DropdownsState(ImmutableList<DropdownKey> ActiveDropdownKeys)
{
    public DropdownsState() : this(ImmutableList<DropdownKey>.Empty)
    {
        
    }
}
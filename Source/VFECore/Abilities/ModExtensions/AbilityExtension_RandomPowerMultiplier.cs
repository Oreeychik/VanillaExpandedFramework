﻿using Verse;

namespace VFECore.Abilities;

/// power (after stat offsets) becomes a random number within a range.
///
/// The formula used is power * Rand.Range(range.min, range.max)
/// Example XML:
/// <li Class="VFECore.Abilities.AbilityExtension_RandomPowerMultiplier">
///   <range>
///     <min>0.5 </min>
///     <!-- Because max is not provided, it defaults to 1f -->
///   </range>
/// </li>
public class AbilityExtension_RandomPowerMultiplier : DefModExtension
{
    public FloatRange range = FloatRange.One;
}

using System;
using Godot;

namespace AutoBattler.Events
{
    public record DamageEvent(
        float BaseDamage,
        Node Source,
        Node Target,
        float CriticalChance,
        float CriticalMultiplier,
        string AbilityName
    ) { }
}

using System;
using AutoBattler.Stats;
using Godot;

namespace AutoBattler.Abilities
{
    public partial class Fireball : Resource
    {
        public DamageComponent DamageComponent;

        public CooldownComponent CooldownComponent;
    }
}

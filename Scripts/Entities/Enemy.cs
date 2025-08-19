using System;
using AutoBattler.Components;
using Godot;

namespace AutoBattler.Entities
{
    public partial class Enemy : Node2D
    {
        private HealthComponent _health;
        private ManaComponent _mana;
        private StaminaComponent _stamina;

        public HealthComponent HealthComponent => _health;
        public ManaComponent ManaComponent => _mana;
        public StaminaComponent StaminaComponent => _stamina;
    }
}

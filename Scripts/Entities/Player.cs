using System;
using AutoBattler.Components;
using AutoBattler.Stats;
using Godot;

namespace AutoBattler.Entities
{
    public partial class Player : Node2D
    {
        private HealthComponent _health;
        private ManaComponent _mana;
        private StaminaComponent _stamina;

        [Export]
        public CharacterBaseStats PlayerBaseStats { get; set; }

        public HealthComponent Health => _health;
        public ManaComponent Mana => _mana;
        public StaminaComponent Stamina => _stamina;

        public override void _Ready()
        {
            try
            {
                _health = new HealthComponent(PlayerBaseStats.MaxHealth);
                AddChild(_health);

                _mana = new ManaComponent(PlayerBaseStats.MaxMana);
                AddChild(_mana);

                _stamina = new StaminaComponent(PlayerBaseStats.MaxStamina);
                AddChild(_stamina);

                GD.Print(
                    $"HP={_health.MaxHealth}, Mana={_mana.MaxMana}, Stamina={_stamina.MaxStamina}"
                );
            }
            catch (Exception e)
            {
                GD.PrintErr("Error readying Player: " + e);
            }
        }
    }
}

using System;
using AutoBattler.Stats;
using Godot;

namespace AutoBattler.PlayerNS
{
    public partial class Player : Node2D
    {
        private HealthComponent _health;
        private ManaComponent _mana;
        private StaminaComponent _stamina;

        [Export]
        public BaseStats PlayerBaseStats { get; set; }

        public HealthComponent Health => _health;
        public ManaComponent Mana => _mana;
        public StaminaComponent Stamina => _stamina;

        public override void _Ready()
        {
            try
            {
                _health = new HealthComponent();
                AddChild(_health);
                _health.Initialize(this);
                _health.MaxHP = PlayerBaseStats.MaxHealth;
                _health.CurrentHP = _health.MaxHP;

                _mana = new ManaComponent();
                AddChild(_mana);
                _mana.Initialize(this);
                _mana.MaxMana = PlayerBaseStats.MaxMana;
                _mana.CurrentMana = _mana.MaxMana;

                _stamina = new StaminaComponent();
                AddChild(_stamina);
                _stamina.Initialize(this);
                _stamina.MaxStamina = PlayerBaseStats.MaxStamina;
                _stamina.CurrentStamina = _stamina.MaxStamina;

                GD.Print(
                    $"HP={_health.MaxHP}, Mana={_mana.MaxMana}, Stamina={_stamina.MaxStamina}"
                );
            }
            catch (Exception e)
            {
                GD.PrintErr(e);
            }
        }
    }
}

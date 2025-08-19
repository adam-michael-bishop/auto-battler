using System;
using AutoBattler.Components;
using AutoBattler.Stats;
using Godot;

namespace AutoBattler.Entities
{
    public partial class Enemy : Node2D
    {
        private HealthComponent _health;
        private ManaComponent _mana;
        private StaminaComponent _stamina;

        [Export]
        public EnemyBaseStats EnemyBaseStats { get; set; }

        public HealthComponent HealthComponent => _health;
        public ManaComponent ManaComponent => _mana;
        public StaminaComponent StaminaComponent => _stamina;

        public override void _Ready()
        {
            try
            {
                _health = new HealthComponent(EnemyBaseStats.MaxHealth);
                AddChild(_health);

                _mana = new ManaComponent(EnemyBaseStats.MaxMana);
                AddChild(_mana);

                _stamina = new StaminaComponent(EnemyBaseStats.MaxStamina);
                AddChild(_stamina);

                GD.Print(
                    $"HP={_health.MaxHealth}, Mana={_mana.MaxMana}, Stamina={_stamina.MaxStamina}"
                );
            }
            catch (Exception e)
            {
                GD.PrintErr($"Error readying {this.Get(Node2D.PropertyName.Name)}: " + e);
            }
        }
    }
}

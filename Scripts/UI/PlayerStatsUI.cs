using AutoBattler.Entities;
using Godot;

namespace AutoBattler.UI
{
    public partial class PlayerStatsUI : PanelContainer
    {
        [Export]
        public Player Player { get; set; }

        [Export]
        private Label _healthValue;

        [Export]
        private Label _manaValue;

        [Export]
        private Label _staminaValue;

        public override void _Ready()
        {
            if (Player != null)
            {
                if (Player.IsInsideTree())
                {
                    ConnectToPlayer();
                }
                else
                {
                    Player.Ready += ConnectToPlayer;
                }
            }
            else
            {
                GD.PrintErr("PlayerStatsUI: No player found to connect to.");
            }
        }

        private void ConnectToPlayer()
        {
            SetHealth(Player.Health.CurrentHealth, Player.Health.MaxHealth);
            SetMana(Player.Mana.CurrentMana, Player.Mana.MaxMana);
            SetStamina(Player.Stamina.CurrentStamina, Player.Stamina.MaxStamina);

            Player.Health.Connect("HealthChanged", Callable.From<float, float>(SetHealth));
            Player.Mana.Connect("ManaChanged", Callable.From<float, float>(SetMana));
            Player.Stamina.Connect("StaminaChanged", Callable.From<float, float>(SetStamina));
        }

        public void SetHealth(float value, float max)
        {
            _healthValue.Text = $"{value} / {max}";
        }

        public void SetMana(float value, float max)
        {
            _manaValue.Text = $"{value} / {max}";
        }

        public void SetStamina(float value, float max)
        {
            _staminaValue.Text = $"{value} / {max}";
        }
    }
}

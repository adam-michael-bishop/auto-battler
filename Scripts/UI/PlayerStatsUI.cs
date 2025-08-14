using AutoBattler.PlayerNS;
using Godot;

namespace AutoBattler.UI
{
    public partial class PlayerStatsUI : PanelContainer
    {
        public Player Player { get; set; }

        [Export]
        private Label _healthValue;

        [Export]
        private Label _manaValue;

        [Export]
        private Label _staminaValue;

        public override void _Ready()
        {
            Player ??= GetTree().CurrentScene.GetNode<Player>("Player");

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
            SetHealth(Player.Health.CurrentHP, Player.Health.MaxHP);
            SetMana(Player.Mana.CurrentMana, Player.Mana.MaxMana);
            SetStamina(Player.Stamina.CurrentStamina, Player.Stamina.MaxStamina);

            Player.Health.Connect("HealthChanged", Callable.From<int, int>(SetHealth));
            Player.Mana.Connect("ManaChanged", Callable.From<int, int>(SetMana));
            Player.Stamina.Connect("StaminaChanged", Callable.From<int, int>(SetStamina));
        }

        public void SetHealth(int value, int max)
        {
            _healthValue.Text = $"{value} / {max}";
        }

        public void SetMana(int value, int max)
        {
            _manaValue.Text = $"{value} / {max}";
        }

        public void SetStamina(int value, int max)
        {
            _staminaValue.Text = $"{value} / {max}";
        }
    }
}

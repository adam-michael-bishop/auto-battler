using System;
using AutoBattler.PlayerNS;
using AutoBattler.UI;
using Godot;

namespace AutoBattler
{
    public partial class GameManager : Node
    {
        [Export]
        public Player Player { get; set; }

        [Export]
        public PlayerStatsUI PlayerStatsUI { get; set; }

        public override void _Ready()
        {
            // Hook up the Player stats UI and the Player scenes
            PlayerStatsUI.Player = Player;
        }
    }
}

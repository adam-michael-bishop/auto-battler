using System;
using AutoBattler.PlayerNS;
using AutoBattler.UI;
using Godot;

namespace AutoBattler
{
    public partial class GameManager : Node2D
    {
        [Export]
        public Player Player { get; set; }

        [Export]
        public PlayerStatsUI PlayerStatsUI { get; set; }

        public override void _Ready()
        {
            PlayerStatsUI.Player = Player;
        }
    }
}

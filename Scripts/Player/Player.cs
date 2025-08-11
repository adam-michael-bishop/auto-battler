using Godot;
using System;
using AutoBattler.Stats;
using AutoBattler.Characters;

namespace AutoBattler.Player
{
	public partial class Player : Node2D
	{
		private HealthComponent _health;
		private ManaComponent _mana;
		private StaminaComponent _stamina;

		[Export]
		public CharacterClassResource ClassType { get; set; }

		private Character _character;

		public override void _Ready()
		{
			// Build character from data-driven class
			_character = new Character(ClassType);

			_health = new HealthComponent();
			AddChild(_health);
			_health.Initialize(this);
			_health.MaxHP = _character.FinalStats.Health;

			_mana = new ManaComponent();
			AddChild(_mana);
			_mana.Initialize(this);
			_mana.MaxMana = _character.FinalStats.Mana;

			_stamina = new StaminaComponent();
			AddChild(_stamina);
			_stamina.Initialize(this);
			_stamina.MaxStamina = _character.FinalStats.Stamina;

			GD.Print($"Player Class: {ClassType?.ClassName ?? "None"} | HP={_health.MaxHP}, Mana={_mana.MaxMana}, Stamina={_stamina.MaxStamina}");
		}
	}
}

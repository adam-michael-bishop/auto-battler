using Godot;
using System;
using AutoBattler.Stats;

namespace AutoBattler
{
	public partial class Player : Node2D
	{
		private HealthComponent _health;
		private ManaComponent _mana;
		private StaminaComponent _stamina;

		public override void _Ready()
		{
			_health = new HealthComponent();
			AddChild(_health);
			_health.Initialize(this);

			_mana = new ManaComponent();
			AddChild(_mana);
			_mana.Initialize(this);

			_stamina = new StaminaComponent();
			AddChild(_stamina);
			_stamina.Initialize(this);
		}
	}
}

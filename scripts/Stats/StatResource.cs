using Godot;
using System;

namespace AutoBattler.Stats
{
	public interface IComponent
	{
		void Initialize(Node owner);
	}

	public partial class StatResource : Node, IComponent
	{
		[Export]
		public int HP { get; set; }
		[Export]
		public int Mana { get; set; }
		[Export]
		public int Stamina { get; set; }
		[Export]
		public float AttackSpeed { get; set; }
		[Export]
		public float Armor { get; set; }
		[Export]
		public int Strength { get; set; }
		[Export]
		public int Dexterity { get; set; }
		[Export]
		public int Intelligence { get; set; }

		public void Initialize(Node owner)
		{
			// Optionally store reference to owner or perform setup
		}
	}
}

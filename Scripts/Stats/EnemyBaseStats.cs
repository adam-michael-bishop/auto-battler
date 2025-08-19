using Godot;

namespace AutoBattler.Stats
{
    [GlobalClass]
    public partial class EnemyBaseStats : Resource
    {
        [Export]
        public float MaxHealth { get; set; }

        [Export]
        public float MaxMana { get; set; }

        [Export]
        public float MaxStamina { get; set; }

        [Export]
        public int Strength { get; set; }

        [Export]
        public int Intelligence { get; set; }

        [Export]
        public int Dexterity { get; set; }

        [Export]
        public int Luck { get; set; }
    }
}

using Godot;

namespace AutoBattler.Stats
{
    [GlobalClass]
    public partial class BaseStats : Resource
    {
        [Export]
        public int MaxHealth { get; set; }

        [Export]
        public int MaxMana { get; set; }

        [Export]
        public int MaxStamina { get; set; }

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

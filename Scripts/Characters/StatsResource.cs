using Godot;

namespace AutoBattler.Characters
{
    [GlobalClass]
    public partial class StatsResource : Resource
    {
        [Export]
        public int Health { get; set; } = 0;

        [Export]
        public int Mana { get; set; } = 0;

        [Export]
        public int Stamina { get; set; } = 0;
    }
}



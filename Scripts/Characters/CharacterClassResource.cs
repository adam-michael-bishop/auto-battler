using Godot;

namespace AutoBattler.Characters
{
    [GlobalClass]
    public partial class CharacterClassResource : Resource
    {
        [Export]
        public string ClassName { get; set; } = "";

        [Export]
        public StatsResource BaseStats { get; set; }
            = new StatsResource();

        [Export]
        public int BonusHealth { get; set; } = 0;

        [Export]
        public int BonusMana { get; set; } = 0;

        [Export]
        public int BonusStamina { get; set; } = 0;

        public StatsResource GetFinalStats()
        {
            var result = new StatsResource
            {
                Health = (BaseStats?.Health ?? 0) + BonusHealth,
                Mana = (BaseStats?.Mana ?? 0) + BonusMana,
                Stamina = (BaseStats?.Stamina ?? 0) + BonusStamina,
            };
            return result;
        }
    }
}



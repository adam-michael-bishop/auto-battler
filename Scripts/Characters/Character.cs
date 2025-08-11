using Godot;

namespace AutoBattler.Characters
{
    public class Character
    {
        public CharacterClassResource CharacterClass { get; }
        public StatsResource FinalStats { get; }

        public Character(CharacterClassResource characterClass)
        {
            CharacterClass = characterClass;
            FinalStats = characterClass?.GetFinalStats() ?? new StatsResource();
        }
    }
}



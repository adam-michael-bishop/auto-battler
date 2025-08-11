using Godot;

namespace AutoBattler.Stats
{
    public partial class HealthComponent : Node, IComponent
    {
        [Export]
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }

        public override void _Ready()
        {
            CurrentHP = MaxHP;
        }

        public void Initialize(Node owner)
        {
            // Optional: store reference to owner or setup
        }
    }
}

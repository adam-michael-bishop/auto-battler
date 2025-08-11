using Godot;

namespace AutoBattler.Stats
{
    public partial class ManaComponent : Node, IComponent
    {
        [Export]
        public int MaxMana { get; set; }
        public int CurrentMana { get; set; }

        public override void _Ready()
        {
            CurrentMana = MaxMana;
        }

        public void Initialize(Node owner)
        {
            // Optional: store reference to owner or setup
        }
    }
}

using Godot;

namespace AutoBattler.Stats
{
    public partial class StaminaComponent : Node, IComponent
    {
        [Export]
        public int MaxStamina { get; set; }
        public int CurrentStamina { get; set; }

        public override void _Ready()
        {
            CurrentStamina = MaxStamina;
        }

        public void Initialize(Node owner)
        {
            // Optional: store reference to owner or setup
        }
    }
}

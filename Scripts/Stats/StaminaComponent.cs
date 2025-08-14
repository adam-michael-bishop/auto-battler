using Godot;

namespace AutoBattler.Stats
{
    public partial class StaminaComponent : Node, IComponent
    {
        [Signal]
        public delegate void StaminaChangedEventHandler(int current, int max);

        [Export]
        public int MaxStamina { get; set; }

        private int _currentStamina;
        public int CurrentStamina
        {
            get => _currentStamina;
            set
            {
                if (_currentStamina != value)
                {
                    _currentStamina = value;
                    EmitSignal(nameof(StaminaChanged), _currentStamina, MaxStamina);
                }
            }
        }

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

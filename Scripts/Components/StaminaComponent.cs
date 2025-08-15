using Godot;

namespace AutoBattler.Components
{
    public partial class StaminaComponent(float maxStamina) : Node, IComponent
    {
        [Signal]
        public delegate void StaminaChangedEventHandler(int current, int max);

        [Export]
        public float MaxStamina { get; set; } = maxStamina;

        private float _currentStamina = maxStamina;
        public float CurrentStamina
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
    }
}

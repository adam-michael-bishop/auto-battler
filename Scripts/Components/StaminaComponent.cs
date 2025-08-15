using Godot;

namespace AutoBattler.Components
{
    public partial class StaminaComponent : Node, IComponent
    {
        [Signal]
        public delegate void StaminaChangedEventHandler(int current, int max);

        [Export]
        public float MaxStamina { get; set; }

        private float _currentStamina;
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

        public StaminaComponent(float maxStamina)
        {
            MaxStamina = maxStamina;
            _currentStamina = maxStamina;
        }
    }
}

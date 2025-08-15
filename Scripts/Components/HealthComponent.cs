using Godot;

namespace AutoBattler.Components
{
    public partial class HealthComponent(float maxHealth) : Node, IComponent
    {
        [Signal]
        public delegate void HealthChangedEventHandler(int current, int max);

        [Export]
        public float MaxHealth { get; set; } = maxHealth;

        private float _currentHealth = maxHealth;
        public float CurrentHealth
        {
            get => _currentHealth;
            set
            {
                if (_currentHealth != value)
                {
                    _currentHealth = value;
                    EmitSignal(nameof(HealthChanged), _currentHealth, MaxHealth);
                }
            }
        }
    }
}

using Godot;

namespace AutoBattler.Components
{
    public partial class HealthComponent : Node, IComponent
    {
        [Signal]
        public delegate void HealthChangedEventHandler(int current, int max);

        [Export]
        public float MaxHealth { get; set; }

        private float _currentHealth;
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

        public HealthComponent(float maxHealth)
        {
            MaxHealth = maxHealth;
            _currentHealth = maxHealth;
        }
    }
}

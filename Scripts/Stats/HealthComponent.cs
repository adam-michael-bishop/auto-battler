using Godot;

namespace AutoBattler.Stats
{
    public partial class HealthComponent : Node, IComponent
    {
        [Signal]
        public delegate void HealthChangedEventHandler(int current, int max);

        [Export]
        public int MaxHP { get; set; }

        private int _currentHP;
        public int CurrentHP
        {
            get => _currentHP;
            set
            {
                if (_currentHP != value)
                {
                    _currentHP = value;
                    EmitSignal(nameof(HealthChanged), _currentHP, MaxHP);
                }
            }
        }

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

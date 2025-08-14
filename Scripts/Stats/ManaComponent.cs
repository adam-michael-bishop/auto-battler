using Godot;

namespace AutoBattler.Stats
{
    public partial class ManaComponent : Node, IComponent
    {
        [Signal]
        public delegate void ManaChangedEventHandler(int current, int max);

        [Export]
        public int MaxMana { get; set; }

        private int _currentMana;
        public int CurrentMana
        {
            get => _currentMana;
            set
            {
                if (_currentMana != value)
                {
                    _currentMana = value;
                    EmitSignal(nameof(ManaChanged), _currentMana, MaxMana);
                }
            }
        }

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

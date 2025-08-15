using Godot;

namespace AutoBattler.Components
{
    public partial class ManaComponent(float maxMana) : Node, IComponent
    {
        [Signal]
        public delegate void ManaChangedEventHandler(int current, int max);

        [Export]
        public float MaxMana { get; set; } = maxMana;

        private float _currentMana = maxMana;
        public float CurrentMana
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
    }
}

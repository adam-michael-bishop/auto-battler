using Godot;

namespace AutoBattler.Components
{
    public partial class ManaComponent : Node, IComponent
    {
        [Signal]
        public delegate void ManaChangedEventHandler(int current, int max);

        [Export]
        public float MaxMana { get; set; }

        private float _currentMana;
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

        public ManaComponent(float maxMana)
        {
            MaxMana = maxMana;
            _currentMana = maxMana;
        }
    }
}

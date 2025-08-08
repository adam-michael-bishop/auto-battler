using Godot;

namespace AutoBattler.Stats
{
    public partial class DamageComponent : Node, IComponent
    {
        public void Initialize(Node owner)
        {
            // Optional: store reference to owner or setup
        }

        public static void DealDamage(Node target, int amount)
        {
            var health = target.GetNodeOrNull<HealthComponent>("HealthComponent");
            if (health != null)
            {
                health.CurrentHP = Mathf.Max(health.CurrentHP - amount, 0);
            }
        }
    }
}

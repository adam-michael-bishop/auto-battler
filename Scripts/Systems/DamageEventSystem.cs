using System;
using System.Collections.Generic;
using AutoBattler.Components;
using AutoBattler.Events;
using Godot;

namespace AutoBattler.Systems
{
    public class DamageEventSystem
    {
        public void Process(List<DamageEvent> damageEvents)
        {
            foreach (var damageEvent in damageEvents)
            {
                ProcessDamageEvent(damageEvent);
            }
        }

        private void ProcessDamageEvent(DamageEvent damageEvent)
        {
            if (damageEvent.Target.HasNode("HealthComponent"))
            {
                var healthComponent = damageEvent.Target.GetNode<HealthComponent>(
                    "HealthComponent"
                );

                float finalDamage = damageEvent.BaseDamage;

                var random = new Random();
                if (random.NextDouble() < damageEvent.CriticalChance)
                {
                    finalDamage *= damageEvent.CriticalMultiplier;
                    GD.Print(
                        $"Critical hit! {damageEvent.AbilityName} dealt {finalDamage} damage!"
                    );
                }

                healthComponent.CurrentHealth -= finalDamage;

                GD.Print(
                    $"{damageEvent.Source.Name} used {damageEvent.AbilityName} on {damageEvent.Target.Name} for {finalDamage} damage"
                );
            }
            else
            {
                GD.PrintErr($"Target {damageEvent.Target.Name} does not have a HealthComponent!");
            }
        }
    }
}

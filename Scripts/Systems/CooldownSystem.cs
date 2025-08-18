using System;
using System.Collections.Generic;
using AutoBattler.Components;
using Godot;

namespace AutoBattler.Systems
{
    public class CooldownSystem
    {
        private readonly List<CooldownComponent> _cooldowns;

        public List<CooldownComponent> Cooldowns { get; }

        public CooldownSystem(List<CooldownComponent> cooldowns)
        {
            _cooldowns = cooldowns;
        }

        public void Process()
        {
            foreach (var cooldown in _cooldowns)
            {
                ProccessCooldown(cooldown);
            }
        }

        public void StopAllCooldowns()
        {
            foreach (var cooldown in _cooldowns)
            {
                cooldown.Timer.Stop();
            }
        }

        private static void ProccessCooldown(CooldownComponent cooldown)
        {
            if (cooldown.Timer.IsStopped())
            {
                cooldown.Timer.Start(cooldown.Length);
            }
        }
    }
}

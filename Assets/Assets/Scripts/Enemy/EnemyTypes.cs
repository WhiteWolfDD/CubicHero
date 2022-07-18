using UnityEngine;

namespace Assets.Scripts.Enemy
{
    public enum EnemyTypes
    {
        Basic,      // Basic enemy (no special abilities)
        Strong,     // Strong enemy (has a more healthy health)
        Heavy,      // Heavy enemy (can do more damage than normal)
        MiniBoss,   // Mini boss enemy (has a more powerful health and can do little bit more damage)
        Boss,       // Boss enemy (has a more powerful health and can do more damage than normal)
    }
}
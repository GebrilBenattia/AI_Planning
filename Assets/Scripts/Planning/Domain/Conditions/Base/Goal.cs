using UnityEngine;

namespace Planning.Domain.Conditions.Base
{
    public abstract class Goal : ScriptableObject
    {
        public abstract bool IsMet(WorldStateData worldStateData);
    }
}

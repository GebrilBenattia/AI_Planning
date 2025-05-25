using UnityEngine;

namespace Planning.Domain.Conditions.Base
{
    public abstract class PreCondition : ScriptableObject
    {
        public abstract bool IsMet(WorldStateData worldStateData);
    }
}

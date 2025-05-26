using UnityEngine;

namespace Planning.Domain.Conditions.Base
{
    public abstract class PostCondition : ScriptableObject
    {
        public abstract void Apply(ref WorldStateData worldStateData);
        public abstract WorldStateData Apply(WorldStateData worldStateData);
    }
}

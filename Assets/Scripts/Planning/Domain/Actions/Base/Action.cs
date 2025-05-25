using Planning.Domain.Conditions.Base;

namespace Planning.Domain.Actions.Base
{
    [System.Serializable]
    public class Action
    {
        public string Name;
        public float Cost;
        public PreCondition PreConditions;
        public PostCondition PostConditions;

        public bool IsValid(WorldStateData worldStateData)
        {
            return PreConditions.IsMet(worldStateData);
        }

        public virtual void ApplyPostConditions(ref WorldStateData worldStateData)
        {
            PostConditions.Apply(ref worldStateData);
        }
    }
}

using UnityEngine;
using Planning.Domain.Conditions.Base;

namespace Planning.Domain.Conditions.FirstExercise.Pre
{
    [CreateAssetMenu(fileName = "PreIsHurt", menuName = "AI/GOAP/PreConditions/PreIsHurt")]
    public class PreIsHurt : PreCondition
    {
        public override bool IsMet(WorldStateData worldStateData)
        {
            return worldStateData.IsHurt;
        }
    }
}

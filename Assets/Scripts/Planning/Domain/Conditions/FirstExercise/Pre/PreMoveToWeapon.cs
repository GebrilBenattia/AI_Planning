using UnityEngine;
using Planning.Domain.Conditions.Base;

namespace Planning.Domain.Conditions.FirstExercise.Pre
{
    [CreateAssetMenu(fileName = "PreMoveToWeapon", menuName = "AI/GOAP/PreConditions/PreMoveToWeapon")]
    public class PreMoveToWeapon : PreCondition
    {
        public override bool IsMet(WorldStateData worldStateData)
        {
            return !worldStateData.IsNearWeapon;
        }
    }
}

using UnityEngine;
using Planning.Domain.Conditions.Base;

namespace Planning.Domain.Conditions.FirstExercise.Pre
{
    [CreateAssetMenu(fileName = "PreMoveToEnemy", menuName = "AI/GOAP/PreConditions/PreMoveToEnemy")]
    public class PreMoveToEnemy : PreCondition
    {
        public override bool IsMet(WorldStateData worldStateData)
        {
            return !worldStateData.IsNearEnemy && !worldStateData.IsHurt && worldStateData.HasWeapon;
        }
    }
}

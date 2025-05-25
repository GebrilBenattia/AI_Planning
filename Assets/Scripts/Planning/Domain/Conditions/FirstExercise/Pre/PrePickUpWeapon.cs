using UnityEngine;
using Planning.Domain.Conditions.Base;

namespace Planning.Domain.Conditions.FirstExercise.Pre
{
    [CreateAssetMenu(fileName = "PrePickUpWeapon", menuName = "AI/GOAP/PreConditions/PrePickUpWeapon")]
    public class PrePickUpWeapon : PreCondition
    {
        public override bool IsMet(WorldStateData worldStateData)
        {
            return worldStateData.IsNearWeapon;
        }
    }
}

using UnityEngine;
using Planning.Domain.Conditions.Base;

namespace Planning.Domain.Conditions.FirstExercise.Pre
{
    [CreateAssetMenu(fileName = "PreKillEnemy", menuName = "AI/GOAP/PreConditions/PreKillEnemy")]
    public class PreKillEnemy : PreCondition
    {
        public override bool IsMet(WorldStateData worldStateData)
        {
            return worldStateData.HasWeapon && worldStateData.IsNearEnemy && !worldStateData.IsHurt;
        }
    }
}

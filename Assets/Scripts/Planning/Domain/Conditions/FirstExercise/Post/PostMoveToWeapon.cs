using UnityEngine;
using Planning.Domain.Conditions.Base;

namespace Planning.Domain.Conditions.FirstExercise.Post
{
    [CreateAssetMenu(fileName = "PostMoveToWeapon", menuName = "AI/GOAP/PostConditions/PostMoveToWeapon")]
    public class PostMoveToWeapon : PostCondition
    {
        public override void Apply(ref WorldStateData worldStateData)
        {
            worldStateData.IsNearWeapon = true;
        }
    }
}

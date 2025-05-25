using UnityEngine;
using Planning.Domain.Conditions.Base;

namespace Planning.Domain.Conditions.FirstExercise.Post
{
    [CreateAssetMenu(fileName = "PostMoveToEnemy", menuName = "AI/GOAP/PostConditions/PostMoveToEnemy")]
    public class PostMoveToEnemy : PostCondition
    {
        public override void Apply(ref WorldStateData worldStateData)
        {
            worldStateData.IsNearEnemy = true;
        }
    }
}

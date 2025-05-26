using UnityEngine;
using Planning.Domain.Conditions.Base;

namespace Planning.Domain.Conditions.FirstExercise.Post
{
    [CreateAssetMenu(fileName = "PostKillEnemy", menuName = "AI/GOAP/PostConditions/PostKillEnemy")]
    public class PostKillEnemy : PostCondition
    {
        public override void Apply(ref WorldStateData worldStateData)
        {
            worldStateData.IsEnemyDead = true;
        }

        public override WorldStateData Apply(WorldStateData worldStateData)
        {
            worldStateData.IsEnemyDead = true;
            return worldStateData;
        }
    }
}

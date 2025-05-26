using UnityEngine;
using Planning.Domain.Conditions.Base;

namespace Planning.Domain.Conditions.FirstExercise.Post
{
    [CreateAssetMenu(fileName = "PostIsHurt", menuName = "AI/GOAP/PostConditions/PostIsHurt")]
    public class PostHealSelf : PostCondition
    {
        public override void Apply(ref WorldStateData worldStateData)
        {
            worldStateData.IsHurt = false;
        }

        public override WorldStateData Apply(WorldStateData worldStateData)
        {
            worldStateData.IsHurt = false;
            return worldStateData;
        }
    }
}

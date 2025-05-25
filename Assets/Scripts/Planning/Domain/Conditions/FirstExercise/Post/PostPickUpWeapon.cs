using UnityEngine;
using Planning.Domain.Conditions.Base;

namespace Planning.Domain.Conditions.FirstExercise.Post
{
    [CreateAssetMenu(fileName = "PostPickUpWeapon", menuName = "AI/GOAP/PostConditions/PostPickUpWeapon")]
    public class PostPickUpWeapon : PostCondition
    {
        public override void Apply(ref WorldStateData worldStateData)
        {
            worldStateData.HasWeapon = true;
        }
    }
}

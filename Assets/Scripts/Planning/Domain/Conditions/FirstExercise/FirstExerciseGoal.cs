using UnityEngine;

using Planning.Domain.Conditions.Base;

namespace Planning.Domain.Conditions.FirstExercise
{
    [CreateAssetMenu(fileName = "FirstExerciseGoal", menuName = "AI/GOAP/Goals/FirstExerciseGoal")]
    public class FirstExerciseGoal : Goal
    {
        public override bool IsMet(WorldStateData worldStateData)
        {
            return worldStateData.IsEnemyDead;
        }
    }
}

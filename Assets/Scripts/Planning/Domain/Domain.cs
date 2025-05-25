using UnityEngine;
using System.Collections.Generic;
using Planning.Domain.Actions.Base;
using Planning.Domain.Conditions.FirstExercise;

namespace Planning.Domain
{
    [System.Serializable]
    [CreateAssetMenu(fileName = "NewDomain", menuName = "AI/GOAP/Domain")]
    public class Domain : ScriptableObject
    {
        public FirstExerciseGoal Goal;
        public WorldState WorldSate;
        public List<Action> AvailableActions;
    }
}

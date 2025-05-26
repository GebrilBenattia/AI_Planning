using System;
using System.Collections.Generic;
using Planning.Domain;
using Planning.Domain.Conditions.Base;
using Unity.VisualScripting;
using UnityEngine;
using Action = Planning.Domain.Actions.Base.Action;

namespace Planning
{
    [System.Serializable]
    public class Node
    {
        [SerializeField] public Node Parent;
        public NodeData Data;

        public Node(Node parent, Action action, WorldStateData newWorldState)
        {
            Parent = parent;
            Data.Action = action;
            if (action == null)  {
                Data.Cost = 0f;
            }
            else  {
                Data.Cost = (parent != null) ? parent.Data.Cost + action.Cost : action.Cost;
            }
            Data.WorldStateData = newWorldState;
        }
    }

    [System.Serializable]
    public struct NodeData
    {
        public float Cost;
        public Action Action;
        public WorldStateData WorldStateData;
    }

    public class Goap
    {
        public static bool BuildForward(Node parent, List<Node> leaves, List<Action> availableActions, Goal goal)
        {
            if (IsGoalAchieved(parent.Data.WorldStateData, goal))  {
                leaves.Add(parent);
                return true;
            }

            for (int i = 0; i < availableActions.Count; i++)  {
                if (!availableActions[i].PreConditions.IsMet(parent.Data.WorldStateData))
                    continue;

                WorldStateData newWorldSateData = new WorldStateData(availableActions[i].PostConditions.Apply(parent.Data.WorldStateData));
                Node node = new Node(parent, availableActions[i], newWorldSateData);

                List<Action> actionsSubSet = CreateActionSubSet(new List<Action>(availableActions), i);
                if (BuildForward(node, leaves, actionsSubSet, goal)) {
                    return true;
                };
            }

            return false;
        }

        public static Node GetCheapestPlan(List<Node> leaves)
        {
            Node cheapestPlan = null;
            float utility = float.MinValue;

            for (int i = 0; i < leaves.Count; i++)  {
                if (utility > leaves[i].Data.Cost) {
                    utility = leaves[i].Data.Cost;
                    cheapestPlan = leaves[i];
                }
            }

            return cheapestPlan;
        }

        private static List<Action> CreateActionSubSet(List<Action> usableActions, int removeItemIndex)
        {
            usableActions.RemoveAt(removeItemIndex);
            return usableActions;
        }

        private static bool IsGoalAchieved(WorldStateData newWorldStateData, Goal goal)
        {
            return goal.IsMet(newWorldStateData);
        }
    }
}

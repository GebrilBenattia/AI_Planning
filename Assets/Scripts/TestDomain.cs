using System.Collections.Generic;
using Planning;
using UnityEngine;
using Planning.Domain;
using Planning.Domain.Actions.Base;

public class TestDomain : MonoBehaviour
{
    public Domain Domain;
    public List<Node> leaves = new List<Node>();

    public WorldStateData NewWorldStateData;

    void Start()
    {
        Debug.Log("MoveToWeapon PreCondition = " + Domain.AvailableActions[0].PreConditions.IsMet(Domain.WorldState.Data));
        Debug.Log("====================================");
        Debug.Log("MoveToEnemy PreCondition = " + Domain.AvailableActions[1].PreConditions.IsMet(Domain.WorldState.Data));
        Debug.Log("====================================");
        Debug.Log("PickUpWeapon PreCondition = " + Domain.AvailableActions[2].PreConditions.IsMet(Domain.WorldState.Data));
        Debug.Log("====================================");
        Debug.Log("KillEnemy PreCondition = " + Domain.AvailableActions[3].PreConditions.IsMet(Domain.WorldState.Data));
        Debug.Log("====================================");
        Debug.Log("HealSelf PreCondition = " + Domain.AvailableActions[4].PreConditions.IsMet(Domain.WorldState.Data));

        WorldStateData worldStateData = new WorldStateData(Domain.WorldState.Data);
        Node parent = new Node(null, null, worldStateData);

        List<Action> availableActions = new List<Action>(Domain.AvailableActions);

        Goap.BuildForward(parent, leaves, availableActions, Domain.Goal);
        Node cheapestPlan = Goap.GetCheapestPlan(leaves);

        Debug.Log("Graph size : " + leaves.Count);
        //Debug.Log("Cheapest Plan : " + cheapestPlan.Data.Cost);

        PrintPlans(leaves);
    }

    void PrintPlans(List<Node> plans)
    {
        for (int i = 0; i < plans.Count; i++)
        {
            Node current = plans[i];
            Stack<string> plan = new Stack<string>();

            while (current != null && current.Data.Action != null)
            {
                plan.Push(current.Data.Action.Name); // or Action.ToString() if Name isn't available
                current = current.Parent;
            }

            Debug.Log("====================================");

            Debug.Log($"Plan {i + 1}:");
            foreach (var actionName in plan)
            {
                Debug.Log(" - " + actionName);
            }
        }
    }

    void FixedUpdate()
    {

    }
}

using UnityEngine;
using Planning.Domain;

public class TestDomain : MonoBehaviour
{
    public Domain Domain;

    void Start()
    {
        Debug.Log("MoveToWeapon PreCondition = " + Domain.AvailableActions[0].PreConditions.IsMet(Domain.WorldSate.Data));
        Debug.Log("MoveToEnemy PreCondition = " + Domain.AvailableActions[1].PreConditions.IsMet(Domain.WorldSate.Data));
        Debug.Log("PickUpWeapon PreCondition = " + Domain.AvailableActions[2].PreConditions.IsMet(Domain.WorldSate.Data));
        Debug.Log("KillEnemy PreCondition = " + Domain.AvailableActions[3].PreConditions.IsMet(Domain.WorldSate.Data));
        Debug.Log("HealSelf PreCondition = " + Domain.AvailableActions[4].PreConditions.IsMet(Domain.WorldSate.Data));
    }

    void Update()
    {

    }
}

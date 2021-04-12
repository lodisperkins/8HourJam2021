using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalBehaviour : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        DummyMovementBehaviour dummy = other.GetComponent<DummyMovementBehaviour>();

        if (dummy)
            dummy.GoalReached = true;
    }
}

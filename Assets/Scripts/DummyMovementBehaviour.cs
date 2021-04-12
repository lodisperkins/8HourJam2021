using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyMovementBehaviour : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    private bool _goalReached;

    public bool GoalReached
    {
        get
        {
            return _goalReached;
        }
        set
        {
            _goalReached = value;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!_goalReached)
            transform.position += new Vector3(_speed, 0, 0) * Time.deltaTime;
    }
}

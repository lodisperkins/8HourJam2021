using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    BUILD,
    PLAY,
    OVER
}

public class GameManagerBehaviour : MonoBehaviour
{
    public static GameState GameState;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}

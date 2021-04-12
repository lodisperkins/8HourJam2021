using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotateBehaviour : MonoBehaviour
{
    //The current rotation of the camera
    private float rotateDir;
    //The mouse position in the last frame
    private float previousMousePosition;
    //How far the mouse needs to move before the camera rotates
    [SerializeField] 
    private float deadZone = 5;
    [SerializeField]
    private float _rotationSpeed = 2;
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        //Find how far the mouse moved between frames
        float mouseDisplacement = Input.mousePosition.x - previousMousePosition;
        //Set the previous mouse position to be the current mouse position 
        previousMousePosition = Input.mousePosition.x;

        //If the displacement is less than the dead zone set rotation to be 0
        if (Mathf.Abs(mouseDisplacement) < deadZone)
            rotateDir = 0;
        else
            rotateDir = (mouseDisplacement / Mathf.Abs(mouseDisplacement));

        //Rotate the object using the direction scaled up by the speed
        
        //transform.LookAt(target);
        transform.Rotate(new Vector3(0, 1, 0), 5);
        //transform.RotateAround(target.position, new Vector3(0, 1, 0), rotateDir * _rotationSpeed);
    }
}

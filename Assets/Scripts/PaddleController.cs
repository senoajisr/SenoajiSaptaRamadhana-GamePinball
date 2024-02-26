using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public KeyCode input;
    public float springPower;
    public HingeJoint hinge;
    
    private float targetRelease;
    private float targetPressed;

    void Start()
    {
        targetPressed = hinge.limits.max;
        targetRelease = hinge.limits.min;
    }

    void Update()
    {
        JointSpring jointSpring = hinge.spring;

        if (Input.GetKey(input))
        {
            jointSpring.targetPosition = targetPressed;
        }
        else
        {
            jointSpring.targetPosition = targetRelease;
        }

        hinge.spring = jointSpring;
    }
}

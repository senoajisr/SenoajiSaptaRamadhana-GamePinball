using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public KeyCode input;
    public float springPower;
    public HingeJoint hinge;
    
    void Update()
    {
        JointSpring jointSpring = hinge.spring;

        if (Input.GetKey(input))
        {
            jointSpring.spring = springPower;
        }
        else
        {
            jointSpring.spring = 0;
        }

        hinge.spring = jointSpring;
    }
}

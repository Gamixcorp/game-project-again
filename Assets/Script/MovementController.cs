using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    // public new Transform transform;
    public Rigidbody2D rigidbody;
    public int addSpped;
    public int maxSpeed;

    Vector3 vector;
    int XSpeed = 0;
    int YSpeed = 0;

    void Start()
    {
        
    }

    // changedValue is the variable who define what variable is changed (false for XSpeed, true for YSpeed)
    void AddVelocity(bool changedValue, int speed)
    {
        if (!changedValue) { 
            original 
        }
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.velocity.Set(XSpeed, YSpeed);
    }
}

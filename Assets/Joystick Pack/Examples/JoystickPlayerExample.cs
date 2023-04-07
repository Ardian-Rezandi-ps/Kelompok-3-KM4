using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public VariableJoystick variableJoystick;
    public Rigidbody rb;
    public MovementLatihan movplayer;

    public void FixedUpdate()
    {
        Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
       movplayer.gameObject.transform.Translate( variableJoystick.Horizontal*movplayer.movspeed*Time.deltaTime, variableJoystick.Vertical*movplayer.movspeed*Time.deltaTime,0);
       // rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
    }
}
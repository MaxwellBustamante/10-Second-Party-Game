using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

public class Rotator : MonoBehaviour
{
    public Vector3 Axis; 
    public float RotatorSpeed;
    public bool Toggle;

    void Update()
    {
        if (Toggle == false)
        {
            return; //if toggle is false, does nothing. 
        }
        float radiansthisframe = RotatorSpeed * Time.deltaTime; //controls the rotation speed per frame
        transform.rotation = math.mul(math.normalize(transform.rotation), quaternion.AxisAngle(Axis, radiansthisframe));//axis controls direction, and radiansthisframe controls how much it rotates. normalize converts it from an angle into a direction. 

    }
}

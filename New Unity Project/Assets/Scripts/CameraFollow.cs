using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform FollowTarget;
    public float FollowSpeed;
    public Vector3 Offset;

    private void LateUpdate()
    {
        if(FollowTarget == null)
        {
            Debug.LogWarning("No Target Set for Camera to Follow");
            return; 
        }
        Vector3 TargetPosition = FollowTarget.position + Offset;
        transform.position = Vector3.MoveTowards(transform.position, TargetPosition, FollowSpeed * Time.smoothDeltaTime);
    }
}

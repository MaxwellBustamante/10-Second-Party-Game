using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VictoryZone : MonoBehaviour
{
    public bool HasBeenUsed;
    public UnityEvent OnHitPlayer;

    void Start()
    {
        HasBeenUsed = false;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (HasBeenUsed)
        {
            return;
        }

        Player PlayerTrigger = collision.gameObject.GetComponent<Player>();//checking if whatever is hitting the pickup is the player or not
        if (PlayerTrigger != null)
        {
            HasBeenUsed = true;
            OnHitPlayer.Invoke();
        }
    }
}

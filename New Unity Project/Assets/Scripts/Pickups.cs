using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pickups : MonoBehaviour
{
    public int PointValue;
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
        if(PlayerTrigger != null)
        {
            PlayerTrigger.AlterScore(PointValue);
            HasBeenUsed = true;
            OnHitPlayer.Invoke();
        }
    }
}

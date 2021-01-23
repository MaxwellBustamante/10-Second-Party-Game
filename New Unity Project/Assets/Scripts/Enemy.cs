using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    public bool HasBeenUsed;
    public UnityEvent OnHitPlayer;

    void Start()
    {
        HasBeenUsed = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (HasBeenUsed)
        {
            return;
        }

        Player PlayerTrigger = collision.gameObject.GetComponent<Player>();
        if (PlayerTrigger != null)
        {
            PlayerTrigger.DieDieDie();
            HasBeenUsed = true;
            OnHitPlayer.Invoke();
        }
    }
}

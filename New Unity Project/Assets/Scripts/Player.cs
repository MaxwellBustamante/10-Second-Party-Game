using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public KeyCode MoveRight = KeyCode.D;
    public KeyCode MoveLeft = KeyCode.A;
    public float HorizontalSpeed;
    public float FallSpeed;
    public int Score;
    public UnityEvent OnDieDieDie;

    void Start()
    {
        Score = 0;
    }

    void Update()
    {
        if(GameManager.AnnouncementFinish == false)
        {
            return;
        }

        float xmovement = 0f;
        float ymovement = FallSpeed;

        if (Input.GetKey(MoveRight))
        {
            xmovement = HorizontalSpeed;
        }

        else if (Input.GetKey(MoveLeft))
        {
            xmovement = -HorizontalSpeed;
        }

        Vector3 totalmovement = new Vector3(xmovement, ymovement, 0f);
        transform.position += (totalmovement * Time.deltaTime);
    }

    public void AlterScore(int value)
    {
        Score += value;

        if (Score < 0)
        {
            Score = 0;
        }
    }

    public void DieDieDie()
    {
        OnDieDieDie.Invoke();
        StopMovement();
    }

    public void StopMovement()
    {
        FallSpeed = 0;
        HorizontalSpeed = 0;
    }
}

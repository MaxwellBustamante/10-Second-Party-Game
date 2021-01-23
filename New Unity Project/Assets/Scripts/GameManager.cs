using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject WinUI;
    public GameObject LoseUI;
    public UnityEvent OnPlayerLoss;
    public UnityEvent OnPlayerWin;
    public GameObject IntroText;
    public float IntroDelay;
    public static bool AnnouncementFinish;
    public AudioSource SoundtrackAudio;
    public PlayAudioOnce IntroSound;

    IEnumerator Start()
    {
        WinUI.SetActive(false);
        LoseUI.SetActive(false);
        AnnouncementFinish = false;
        IntroText.SetActive(true);
        IntroSound.PlayAudio();
        yield return new WaitForSeconds(IntroDelay);
        AnnouncementFinish = true;
        IntroText.SetActive(false);
        IntroSound.StopAudio();
        SoundtrackAudio.Play();
        yield return null;
    }

    void Update()
    {
        if (WinUI.activeInHierarchy || LoseUI.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(0);
            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
    }

    public void SetPlayerLoss()
    {
        LoseUI.SetActive(true);
        WinUI.SetActive(false);
        OnPlayerLoss.Invoke();
    }

    public void SetPlayerWin()
    {
        WinUI.SetActive(true);
        LoseUI.SetActive(false);
        OnPlayerWin.Invoke();
    }
}

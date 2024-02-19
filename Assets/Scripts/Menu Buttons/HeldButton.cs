using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.SceneManagement;

public class HeldButton : MonoBehaviour
{
    private bool _okayToUse;

    public void StartGame()
    {
        if (_okayToUse)
        {
            SceneManager.LoadScene("PlaySpace1");
        }
    }

    public void MainMenu()
    {
        if (_okayToUse)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void Leaderboard()
    {
        if (_okayToUse)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    public void PickedUpButtonTrigger()
    {
        _okayToUse = true;
    }

    public void DroppedButtonTrigger()
    {
        _okayToUse = false;
    }
}


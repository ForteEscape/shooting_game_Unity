using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingManager : MonoBehaviour {

    public GameObject mainMenuHolder;
    public GameObject optionMenuHolder;

    public void Play()
    {
        SceneManager.LoadScene("inGame");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void OptionsMenu()
    {
        mainMenuHolder.SetActive(false);
        optionMenuHolder.SetActive(true);
    }

    public void MainMenu()
    {
        mainMenuHolder.SetActive(true);
        optionMenuHolder.SetActive(false);
    }

	public void SetScreenResolution(int i)
    {

    }

    public void SetFullScreen(bool isFullscreen)
    {

    }

    public void SetMusicVolume()
    {

    }
}

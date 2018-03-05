using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingManager : MonoBehaviour {

    public GameObject mainMenuHolder;
    public GameObject optionMenuHolder;

    public int[] howManyPlayerLife;
    public Toggle[] playerLife;

    int life;

    void Start()
    {
        life = 
    }

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

	public void SetScreenResolution(bool isWindowScreen)
    {

    }

    public void SetFullScreen(bool isFullscreen)
    {

    }

    public void SetPlayerLife(int i)
    {
        if (playerLife[i].isOn)
        {
            
        }
    }

    public void SetMusicVolume(bool isMusicOn)
    {

    }

    public void SetSystemSoundVolume(bool isSoundOn)
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingManager : MonoBehaviour {

    public GameObject mainMenuHolder;
    public GameObject optionMenuHolder;
    public GameObject musicManagerHolder;

    public int[] howManyPlayerLife;
    public Toggle[] playerLife;
    public Toggle screenResolutionToggle;
    public int screenWidth;
    
    bool isFullScreen;
    bool isMusicOn;
    
    int activeScreenResIndex;

    int life;

    void Start()
    {
        activeScreenResIndex = PlayerPrefs.GetInt("screen res index");
        bool isfullscreen = (PlayerPrefs.GetInt("fullscreen") == 1) ? true : false;
        bool ismusicon = (PlayerPrefs.GetInt("musicon") == 1) ? true : false;
    }

    void Update()
    {
        
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

	public void SetScreenResolution()
    {
        isFullScreen = false;

        float aspectRatio = 16 / 9f;
        Screen.SetResolution(screenWidth, (int)(screenWidth / aspectRatio), false);

        PlayerPrefs.SetInt("screen res index", 1);
        PlayerPrefs.Save();
    }

    public void SetFullScreen()
    {
        isFullScreen = true;

        Resolution[] allResolutions = Screen.resolutions;
        Resolution maxResolution = allResolutions[allResolutions.Length - 1];
        Screen.SetResolution(maxResolution.width, maxResolution.height, true);

        PlayerPrefs.SetInt("fullscreen", ((isFullScreen) ? 1 : 0));
        PlayerPrefs.Save();
    }

    public void SetPlayerLife(int i)
    {
        if (playerLife[i].isOn)
        {
            
        }
    }

    public void SetMusicVolumeOn()
    {
        isMusicOn = true;

        musicManagerHolder.GetComponent<AudioSource>().volume = 1.0f;

        PlayerPrefs.SetInt("musicon", ((isMusicOn) ? 1 : 0));
        PlayerPrefs.Save();
    }

    public void SetMusicVolumeOff()
    {
        isMusicOn = false;

        musicManagerHolder.GetComponent<AudioSource>().volume = 0.0f;

        PlayerPrefs.Save();
    }

    public void SetSystemSoundVolumeOn()
    {

    }
    
    public void SetSystemSoundVolumeOff()
    {

    }
}

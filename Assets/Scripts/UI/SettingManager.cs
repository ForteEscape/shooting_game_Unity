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
    
    //public bool isFullScreen;
    //public bool isWindowScreen;
    
    int activeScreenResIndex;

    int life;

    void Start()
    {

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
        if (screenResolutionToggle.isOn)
        {
            float aspectRatio = 16 / 9f;
            Screen.SetResolution(screenWidth, (int)(screenWidth / aspectRatio), false);
        }
    }

    public void SetFullScreen()
    {
        Resolution[] allResolutions = Screen.resolutions;
        Resolution maxResolution = allResolutions[allResolutions.Length - 1];
        Screen.SetResolution(maxResolution.width, maxResolution.height, true);
    }

    public void SetPlayerLife(int i)
    {
        if (playerLife[i].isOn)
        {
            
        }
    }

    public void SetMusicVolumeOn()
    {
        musicManagerHolder.GetComponent<AudioSource>().volume = 1.0f;
    }

    public void SetMusicVolumeOff()
    {
        musicManagerHolder.GetComponent<AudioSource>().volume = 0.0f;
    }

    public void SetSystemSoundVolumeOn()
    {

    }
    
    public void SetSystemSoundVolumeOff()
    {

    }
}

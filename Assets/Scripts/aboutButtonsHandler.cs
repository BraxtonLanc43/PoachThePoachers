using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class aboutButtonsHandler : MonoBehaviour
{
    public Text txt_SpeechBubble;
    private string txt_WhyThisGame = "Rhinos are constantly in danger of being poached for their horns. We need to help fight rhino poaching before it is too late. Together we can save rhinos from extinction.";
    private string txt_HowCanIHelp = "Visit www.SaveTheRhino.org to learn more about initiatives being taken to prevent rhino poaching and consider becoming a member.";
    private string txt_AboutDeveloper = "Baxter4343 Games is an animal lover in the games industry. Find him on Twitter @Baxter4343.";
    //private string txt_Credits = "Fonts and UI: Rafmanix, " + Environment.NewLine +
    //    "Rhino and Poacher Characters: " + Environment.NewLine +
    //    "Backgrounds: " + Environment.NewLine +
    //    "Sound Effects: ";
    private string txt_Credits = "All art and animation assets were created by amazing creators in the game asset community. The game was developed by Baxter4343 Games.";
    
    private void Start()
    {
        string soundSetting = PlayerPrefs.GetString("Sound");
    }

    public void btn_WhyThisGame()
    {
        GameObject.FindGameObjectWithTag("PopSound").GetComponent<musicPopSoundHandler>().playPopSound();
        txt_SpeechBubble.text = txt_WhyThisGame;
    }

    public void btn_HowCanIHelp()
    {
        GameObject.FindGameObjectWithTag("PopSound").GetComponent<musicPopSoundHandler>().playPopSound();
        txt_SpeechBubble.text = txt_HowCanIHelp;
    }

    public void btn_AboutTheDeveloper()
    {
        GameObject.FindGameObjectWithTag("PopSound").GetComponent<musicPopSoundHandler>().playPopSound();
        txt_SpeechBubble.text = txt_AboutDeveloper;
    }

    public void btn_Credits()
    {
        GameObject.FindGameObjectWithTag("PopSound").GetComponent<musicPopSoundHandler>().playPopSound();
        txt_SpeechBubble.text = txt_Credits;
    }

    public void btn_BackToMainMenu()
    {
        GameObject.FindGameObjectWithTag("PopSound").GetComponent<musicPopSoundHandler>().playPopSound();
        SceneManager.LoadScene("MainMenu");
    }
}

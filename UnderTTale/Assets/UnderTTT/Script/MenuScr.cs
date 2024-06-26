using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class MenuScr : MonoBehaviour
{
    public TMP_Dropdown graphicsDropdown;
    public Slider masterVol, musicVol, sfxVol;
    public AudioMixer mainAudioMixer;

    public void ChangeGraphicsQuality()
    {
        QualitySettings.SetQualityLevel(graphicsDropdown.value);
    }
    public void ChangeMasterVolume()
    {
        mainAudioMixer.SetFloat("Master", masterVol.value);
    } 
    public void ChangeMusicVolume()
    {
        mainAudioMixer.SetFloat("Music", musicVol.value);
    } 
    public void ChangeSfxVolume()
    {
        mainAudioMixer.SetFloat("Sfx", sfxVol.value);
    } 
}

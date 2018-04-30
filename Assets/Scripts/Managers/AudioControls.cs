using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioControls : MonoBehaviour {

    [SerializeField] private AudioMixer dinoMixer;


    public void SetMasterLevel(float masterLvl)
    {
        dinoMixer.SetFloat("masterVol", masterLvl);
    }

    public void SetMusicLevel(float musicLvl)
    {
        dinoMixer.SetFloat("musicVol", musicLvl);
    }

    public void SetSFXLevel(float sfxLvl)
    {
        dinoMixer.SetFloat("sfxVol", sfxLvl);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource bgmAudioSource;
    public GameObject sfxBumperAudioSource;
    public GameObject sfxSwitchOnAudioSource;
    public GameObject sfxSwitchOffAudioSource;
    
    // Start is called before the first frame update
    private void Start()
    {
        PlayBGM();
    }

    private void PlayBGM()
    {
        bgmAudioSource.Play();
    }

    public void PlaySFX_Bumper(Vector3 spawnposition)
    {
        GameObject sfxBumper = GameObject.Instantiate(sfxBumperAudioSource, spawnposition, Quaternion.identity);
        AudioSource bumperAudioSource = sfxBumper.GetComponent<AudioSource>();
        bumperAudioSource.Play();
    }

    public void PlaySFX_SwitchOn(Vector3 spawnposition)
    {
        GameObject sfxSwitchOn = GameObject.Instantiate(sfxSwitchOnAudioSource, spawnposition, Quaternion.identity);
        AudioSource switchOnAudioSource = sfxSwitchOn.GetComponent<AudioSource>();
        switchOnAudioSource.Play();
    }

    public void PlaySFX_SwitchOff(Vector3 spawnposition)
    {
        GameObject sfxSwitchOff = GameObject.Instantiate(sfxSwitchOffAudioSource, spawnposition, Quaternion.identity);
        AudioSource switchOffAudioSource = sfxSwitchOff.GetComponent<AudioSource>();
        switchOffAudioSource.Play();
    }
}

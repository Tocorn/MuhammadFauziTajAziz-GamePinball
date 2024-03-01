using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public GameObject vfxBumperParticleSystem;
    public GameObject vfxSwitchOnParticleSystem;
    public GameObject vfxSwitchOffParticleSystem;
    
    public void PlayVFX_Bumper(Vector3 spawnposition)
    {
        GameObject sfxBumper = GameObject.Instantiate(vfxBumperParticleSystem, spawnposition, Quaternion.identity);
        ParticleSystem bumperParticleSystem = sfxBumper.GetComponent<ParticleSystem>();
        bumperParticleSystem.Play();
    }

    public void PlayVFX_SwitchOn(Vector3 spawnposition)
    {
        GameObject sfxSwitchOn = GameObject.Instantiate(vfxSwitchOnParticleSystem, spawnposition, Quaternion.identity);
        ParticleSystem switchOnParticleSystem = sfxSwitchOn.GetComponent<ParticleSystem>();
        switchOnParticleSystem.Play();
    }

    public void PlayVFX_SwitchOff(Vector3 spawnposition)
    {
        GameObject sfxSwitchOff = GameObject.Instantiate(vfxSwitchOffParticleSystem, spawnposition, Quaternion.identity);
        ParticleSystem switchOffParticleSystem = sfxSwitchOff.GetComponent<ParticleSystem>();
        switchOffParticleSystem.Play();
    }
}
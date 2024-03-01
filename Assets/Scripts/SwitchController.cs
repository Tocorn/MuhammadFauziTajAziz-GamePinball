using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.SocialPlatforms.Impl;

public class SwitchController : MonoBehaviour
{
    
    private enum SwitchState
    {
        Off,
        On,
        Blink
    }
    
    public Collider bola;
    public Material offMaterial;
    public Material onMaterial;
    public float score;
    
    public ScoreManager scoreManager;

    public AudioManager audioManager;
    public VFXManager vfxManager;

    private SwitchState state;
    public Renderer rendererSwitch;
    
    private void Start ()
    {
        rendererSwitch = GetComponent<Renderer>();

        Set(false);

        StartCoroutine(BlinkTimerStart(5));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            Toggle();
        }
    }

    private void Set(bool active)
    {
        if (active == true)
        {
            state = SwitchState.On;
            rendererSwitch.material = onMaterial;
            StopAllCoroutines();
            audioManager.PlaySFX_SwitchOn(transform.position);
            vfxManager.PlayVFX_SwitchOn(transform.position);
        }
        else
        {
            state = SwitchState.Off;
            rendererSwitch.material = offMaterial;
            StartCoroutine(BlinkTimerStart(5));
            audioManager.PlaySFX_SwitchOff(transform.position);
            vfxManager.PlayVFX_SwitchOff(transform.position);
        }
    }

    private void Toggle()
    {
        if (state == SwitchState.On)
        {
            Set(false);
        }
        else
        {
            Set(true);
            scoreManager.AddScore(score);
        }
    }

    private IEnumerator Blink(int times)
    {
        state = SwitchState.Blink;

        for (int i = 0; i < times; i++)
        {
            rendererSwitch.material = onMaterial;
            yield return new WaitForSeconds(0.5f);
            rendererSwitch.material = offMaterial;
            yield return new WaitForSeconds(0.5f);
        }

        state = SwitchState.Off;

        StartCoroutine(BlinkTimerStart(5));
    }

    private IEnumerator BlinkTimerStart(float time)
    {
        yield return new WaitForSeconds(time);
        StartCoroutine(Blink(2));
    } 
}
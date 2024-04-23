using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaderScr : MonoBehaviour
{

    private const string FADER_PATH = "Fader";

    [SerializeField] private Animator animator;

    private static FaderScr _instance;

    public static FaderScr instance {
        get {
            if (_instance == null){
                var prefab = Resources.Load<FaderScr>(FADER_PATH);
                _instance = Instantiate(prefab);
                DontDestroyOnLoad(_instance.gameObject);
            }

            return _instance;
        }
    }

    public bool isFading { get; private set; }

    private Action _fadedInCallBack;
    private Action _fadedOutCallBack;

    public void FadeIn(Action fadedInCallBack){
        if (isFading)
            return;

        isFading = true;
        _fadedInCallBack = fadedInCallBack;
        animator.SetBool("faded", true); 
    }

    public void FadeOut(Action fadedOutCallBack) {
        if (isFading)
            return;

        isFading = true;
        _fadedOutCallBack = fadedOutCallBack;
        animator.SetBool("faded", false);
    }

    private void Handle_FadeInAnimationOver()
    {
        _fadedInCallBack?.Invoke();
        _fadedInCallBack = null;
        isFading = false;
    }

    private void Handle_FadeOutAnimationOver()
    {
        _fadedOutCallBack?.Invoke();
        _fadedOutCallBack = null;
        isFading = false;
    }

}

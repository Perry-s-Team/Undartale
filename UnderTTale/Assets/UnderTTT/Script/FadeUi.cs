using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeUi : MonoBehaviour
{
    [SerializeField] private CanvasGroup _group;

    public void ShowGroup()
    {
        _group.alpha = 1;
    }

    public void HideGroup()
    {
        _group.alpha = 0;
    }
}

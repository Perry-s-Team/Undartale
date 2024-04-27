using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeVoidScene : MonoBehaviour
{
    public GameObject activeObject;


    private void OnTriggerEnter2D(Collider2D other)
    {
        activeObject.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        activeObject.SetActive(false);
    }
}

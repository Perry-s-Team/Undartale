using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class Scene_Void : MonoBehaviour
{
    [SerializeField] private float fade_speed = 1f;


    IEnumerator Start() {


        Image fade_image = GetComponent<Image>();
        Color color = fade_image.color;
        
        while(color.a < 1f)
        {
            color.a += fade_speed * Time.deltaTime;
            fade_image.color = color;
            yield return null;
        }
    }
}


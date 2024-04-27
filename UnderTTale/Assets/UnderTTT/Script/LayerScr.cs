using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerScr : MonoBehaviour
{
    private bool IsStatic = false;
    
    [SerializeField] private float offset = 0;
    private int sortingOrderBase = 0;
    private new Renderer renderer;

    private void Awake()
    {
        renderer = GetComponent<Renderer>();    
    }

    private void LateUpdate()
    {
        renderer.sortingOrder = (int)(sortingOrderBase - transform.position.y);

        if (IsStatic)
            Destroy(this);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneFreze : MonoBehaviour
{
    [SerializeField] private GameObject _object;

    private void OnTriggerEnter2D(Collider2D other)
    {
        _object.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        //transform.position = transform.position + new Vector3(0, 1f, 0);
    }
}

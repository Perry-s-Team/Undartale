using UnityEngine;
using UnityEngine.SceneManagement;

public class InvokeButton : MonoBehaviour
{
    [SerializeField] private float invoke = 1f;
    [SerializeField] private GameObject inactiveObject;
    [SerializeField] private GameObject outactiveObject;
    void Test()
    {
        inactiveObject.SetActive(true);
    }
}

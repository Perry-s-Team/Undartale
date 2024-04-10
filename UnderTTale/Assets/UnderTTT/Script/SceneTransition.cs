using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    [SerializeField] private int scene;

    public void PlayGame()
    {
        SceneManager.LoadScene(scene);
    }

    public void ExitGame()
    {
        print("Игра закрылась");
        Application.Quit();
    }
}

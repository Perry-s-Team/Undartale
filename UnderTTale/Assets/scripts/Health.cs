using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Unity.UI;
using TMPro;


public class Health : MonoBehaviour
{
    public int PlayerHealth = 100;
    public int PlayerDamage = 45;
    public int maxHealth = 100;
    public int EnemyHealth = 100;
    public int EnemyDamage = 15;






    public void Damage()
    {

        EnemyHealth -= PlayerDamage;
        Debug.Log("Зоровье врага: " + EnemyHealth);

        if (EnemyHealth <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Враг побеждён");
        }
    }
    public void NoMouse()
    {
        StartCoroutine(HideAndShowCursor());
    }

    // Coroutine, который скрывает и показывает курсор
    IEnumerator HideAndShowCursor()
    {
        Cursor.visible = false; // Скрываем курсор
        Cursor.lockState = CursorLockMode.Locked; // Блокируем курсор в центре экрана
        yield return new WaitForSeconds(4); // Ждем 4 секунды
        Cursor.lockState = CursorLockMode.None; // Разблокируем курсор
        Cursor.visible = true; // Показываем курсор
    }


}

using System.Collections;
using UnityEngine;

public class CursorScript : MonoBehaviour
{
    // Начальная настройка
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
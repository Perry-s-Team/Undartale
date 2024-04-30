using System.Collections;
using UnityEngine;

public class CursorScript : MonoBehaviour
{
    // ��������� ���������
    public void NoMouse()
    {
        StartCoroutine(HideAndShowCursor());
    }

    // Coroutine, ������� �������� � ���������� ������
    IEnumerator HideAndShowCursor()
    {
        Cursor.visible = false; // �������� ������
        Cursor.lockState = CursorLockMode.Locked; // ��������� ������ � ������ ������
        yield return new WaitForSeconds(4); // ���� 4 �������
        Cursor.lockState = CursorLockMode.None; // ������������ ������
        Cursor.visible = true; // ���������� ������
    }
}
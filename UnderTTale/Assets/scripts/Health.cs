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
        Debug.Log("������� �����: " + EnemyHealth);

        if (EnemyHealth <= 0)
        {
            Destroy(gameObject);
            Debug.Log("���� �������");
        }
    }
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

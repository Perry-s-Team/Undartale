using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Image bar;
    public float fill;
    void Start()
    {
        fill = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        bar.fillAmount = fill;
        if (fill <= 0f)
            Invoke(nameof(Destro), 0.5f);
    }

    public void DamageFill()
    {    
            Invoke(nameof(FillDam), 0.5f);       
    }
    public void Destro()
    {
        Destroy(gameObject);
    }
    public void FillDam()
    {
        fill -= 0.5f;

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
        yield return new WaitForSeconds(2.5f); // ���� 4 �������
        Cursor.lockState = CursorLockMode.None; // ������������ ������
        Cursor.visible = true; // ���������� ������
    }
}

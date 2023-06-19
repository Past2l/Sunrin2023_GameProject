using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasMouth : MonoBehaviour
{
    private bool isColliding = false;

    private void FixedUpdate()
    {
        // �浹 ���� ����
        if (isColliding)
        {
            // �浹 ó�� �ڵ�
            Debug.Log("Collision Detected!");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // �浹�� �߻��ϸ� isColliding�� true�� ����
        isColliding = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        // �浹�� ����Ǹ� isColliding�� false�� ����
        isColliding = false;
    }
}

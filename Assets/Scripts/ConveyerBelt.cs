using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyerBelt : MonoBehaviour
{
    public float speed; // �����̾� ��Ʈ�� �ӵ�

    void Start()
    {
        speed = 3f;
    }

    private void OnCollisionStay(Collision collision)
    {
        Vector3 localPosition = transform.InverseTransformPoint(collision.gameObject.transform.position);
        if (localPosition.y > 0f)
        {
            // �浹�� ������Ʈ�� ���鿡 �ִ� ��쿡�� �۵�
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                Debug.Log("HELLO");
                // �����̾� ��Ʈ�� ���� �������� ���� ���մϴ�.
                rb.velocity = transform.forward * speed;
            }
        }
    }
}
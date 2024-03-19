using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        // Ű���� �Է��� �޾� �̵� ������ �����մϴ�.
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // �̵� ���⿡ ���� ��ġ�� �����մϴ�.
        Vector3 moveDirection = new Vector3(horizontalInput, verticalInput, 0f).normalized;
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}


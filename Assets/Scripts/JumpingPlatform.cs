using UnityEngine;

public class JumpPlatform : MonoBehaviour
{
    public float jumpForce = 500f; // ���� ������

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                // ���������� ������� ������������ ��������
                rb.linearVelocity = new Vector3(rb.linearVelocity.x, 0, rb.linearVelocity.z);

                // ��������� ������� �����
                rb.AddForce(Vector3.up * jumpForce);
            }
        }
    }
}
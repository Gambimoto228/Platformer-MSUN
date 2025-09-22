using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float distance = 5f;      // ���������� ������
    public float speed = 2f;         // �������� ��������

    private Vector3 startPos;        // ��������� �����
    private Vector3 endPos;          // �������� �����
    private bool movingToEnd = true; // ����������� ��������

    void Start()
    {
        // ��������� ��������� �������
        startPos = transform.position;

        // �������� ����� � ������ �� distance
        endPos = startPos + Vector3.right * distance;
    }

    void Update()
    {
        if (movingToEnd)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPos, speed * Time.deltaTime);
            if (Vector3.Distance(transform.position, endPos) < 0.01f)
                movingToEnd = false;
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, startPos, speed * Time.deltaTime);
            if (Vector3.Distance(transform.position, startPos) < 0.01f)
                movingToEnd = true;
        }
    }
}
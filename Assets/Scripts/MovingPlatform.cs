using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float distance = 5f;      // расстояние вправо
    public float speed = 2f;         // скорость движения

    private Vector3 startPos;        // начальная точка
    private Vector3 endPos;          // конечная точка
    private bool movingToEnd = true; // направление движения

    void Start()
    {
        // сохраняем стартовую позицию
        startPos = transform.position;

        // конечная точка — вправо на distance
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
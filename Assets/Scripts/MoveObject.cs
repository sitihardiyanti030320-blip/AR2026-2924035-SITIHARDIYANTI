using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed = 2f;
    public float maxDistance = 3f; // Batas jarak maju-mundur
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // Rumus PingPong otomatis membuat nilai bergerak bolak-balik antara 0 dan maxDistance
        float movement = Mathf.PingPong(Time.time * speed, maxDistance);
        transform.position = startPosition + new Vector3(0f, 0f, movement);
    }
}

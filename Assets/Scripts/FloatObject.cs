using UnityEngine;

public class FloatObject : MonoBehaviour
{
    public float amplitude = 1f;
    public float speed = 2f;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // Pastikan huruf kapital pada Mathf.Sin dan Time.time sudah pas
        float y = Mathf.Sin(Time.time * speed) * amplitude;
        transform.position = startPosition + new Vector3(0f, y, 0f);
    }
}

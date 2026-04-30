using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xAngle = 0f;

    [SerializeField] float yAngle = 1f;

    [SerializeField] float zAngle = 0f;

    [SerializeField] float speed = 1f;
    
    void Update()
    {
        transform.Rotate(xAngle * speed * Time.deltaTime, yAngle * speed * Time.deltaTime, zAngle * speed * Time.deltaTime);
    }
}

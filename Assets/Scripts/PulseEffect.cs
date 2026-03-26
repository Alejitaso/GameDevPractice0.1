using UnityEngine;

public class PulseEffect : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private float scale = 0.1f;
    
    private Vector3 originalScale;

    void Start()
    {
        originalScale = transform.localScale;
    }

    void Update()
    {
        float variation = Mathf.Sin(Time.time * speed) * scale;
        transform.localScale = originalScale + new Vector3(variation, variation, variation);
    }
}
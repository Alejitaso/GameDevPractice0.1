using UnityEngine;

public class UITextPulse : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float extraScale = 0.1f;

    private Vector3 originalScale;
    void Awake() => originalScale = transform.localScale;
    void Update()
    {
        float pulse = 1f + Mathf.Sin(Time.unscaledTime * speed) * extraScale;
        transform.localScale = originalScale * pulse;
    }
}

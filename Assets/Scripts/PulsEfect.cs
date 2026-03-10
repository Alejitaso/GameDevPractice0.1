using UnityEngine;

public class EfectoPulso : MonoBehaviour
{
    [SerializeField] private float velocidad = 2f;
    [SerializeField] private float amplitud = 0.1f; // Qué tanto se estira
    
    private Vector3 escalaOriginal;

    void Start()
    {
        escalaOriginal = transform.localScale;
    }

    void Update()
    {
        float variacion = Mathf.Sin(Time.time * velocidad) * amplitud;
        transform.localScale = escalaOriginal + new Vector3(variacion, variacion, variacion);
    }
}
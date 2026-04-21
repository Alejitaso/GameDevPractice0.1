using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Health healthObject;
    [SerializeField] private Image imageFill;

    private void OnEnable()
    {
        if (healthObject != null)
        {
            healthObject.OnHealthChanged += UpdateBar;
        }
    }

    private void OnDisable()
    {
        if (healthObject != null)
        {
           healthObject.OnHealthChanged -= UpdateBar;
        }    
    }

    private void UpdateBar(float percent)
    {
        imageFill.fillAmount = percent;
    }
}

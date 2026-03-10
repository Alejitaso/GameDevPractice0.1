using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Health healthPlayer;
    [SerializeField] private Image imageFill;

    private void OnEnable()
    {
        if (healthPlayer != null)
        {
            healthPlayer.OnHealthChanged += UpdateBar;
        }
    }

    private void OnDisable()
    {
        if (healthPlayer != null)
        {
            healthPlayer.OnHealthChanged -= UpdateBar;
        }    
    }

    private void UpdateBar(float percent)
    {
        imageFill.fillAmount = percent;
    }
}

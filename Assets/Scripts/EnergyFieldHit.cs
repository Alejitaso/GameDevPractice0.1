using UnityEngine;

public class EnergyFieldHit : MonoBehaviour
{

    [SerializeField] private float damageAmount = 10f;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && other.TryGetComponent<Health>(out Health health))
        {
            health.TakeDamage(damageAmount * Time.fixedDeltaTime);
        }
         
    }
}
using UnityEngine;

public class TrggerProyctil : MonoBehaviour
{
    [SerializeField] GameObject[] proyectiles;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (GameObject proyectile in proyectiles)
            {
                if (proyectile != null)
                {
                    proyectile.SetActive(true);
                }
            }

            Destroy(gameObject);
        }
    }
}

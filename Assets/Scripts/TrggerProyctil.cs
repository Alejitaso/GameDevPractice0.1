using UnityEngine;

public class TrggerProyctil : MonoBehaviour
{
    [SerializeField] GameObject projectile01;
    [SerializeField] GameObject projectile02;
    [SerializeField] GameObject projectile03;
    [SerializeField] GameObject projectile04;
    [SerializeField] GameObject projectile05;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            projectile01.SetActive(true);
            projectile02.SetActive(true);
            projectile03.SetActive(true);
            projectile04.SetActive(true);
            projectile05.SetActive(true);
            Destroy(gameObject);
        }
    }
}

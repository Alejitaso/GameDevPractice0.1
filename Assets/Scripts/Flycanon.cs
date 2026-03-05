using UnityEngine;

public class Flycanon : MonoBehaviour
{
    [SerializeField] float Speed = 1.0f;
    [SerializeField] Transform player;
    Vector3 playerPosition;

    void Awake()
    {
        gameObject.SetActive(false);
    }
    void Start()
    {
        playerPosition = player.transform.position;
    }

    
    void Update()
    {
        MoveToPlayer();
        DestroyWhereReach();        
    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime*Speed);
    }

    void DestroyWhereReach()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);   
        }
        
    }
}

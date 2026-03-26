using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryManager : MonoBehaviour
{
    [SerializeField] private Health healthPlayer;
    [SerializeField] private GameObject victoryObject;
    [SerializeField] private GameObject gameOverObject;
    private bool playerIsDead = false;

    private bool isInVictory = false;

    private void OnEnable()
    {
        if (healthPlayer != null)
        {
            healthPlayer.OnHealthChanged += CheckHealth;
        }
    }

    private void OnDisable()
    {
        if (healthPlayer != null)
        {
            healthPlayer.OnHealthChanged += CheckHealth;
        }    
    }
    void Start()
    {
        if (victoryObject != null)
        {
            victoryObject.SetActive(false);
        }
        if (gameOverObject != null)
        {
            gameOverObject.SetActive(false);
        }
        Time.timeScale = 1f;
    }
    void Update()
    {
        if ((isInVictory || playerIsDead )&& Input.GetKeyDown(KeyCode.Return))
        {
            Restart();
        }  
    }

    private void CheckHealth(float currentHealth)
    {
        if( healthPlayer.currentHealth <= 0 && !playerIsDead)
        {
            ActiveGameOver();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.tag == "Player") && !isInVictory && !playerIsDead)
        {
            ShowVictory();

        }
    }

    void ShowVictory()
    {
        isInVictory = true;
        victoryObject.SetActive(true);

        Time.timeScale = 0f;
    }

    public void ActiveGameOver()
    {
        if (!playerIsDead)
        {
            playerIsDead = true;
            gameOverObject.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

 
}

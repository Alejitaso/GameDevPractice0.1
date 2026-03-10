using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverObject;
    private bool playerDeath = false;

    void Update()
    {
        if (playerDeath && Input.GetKeyDown(KeyCode.Return))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void ActiveGameOver()
    {
        if (!playerDeath)
        {
            playerDeath = true;
            gameOverObject.SetActive(true);
            Time.timeScale = 0f;
        }
    }

}

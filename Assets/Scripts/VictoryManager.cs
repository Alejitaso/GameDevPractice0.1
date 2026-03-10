using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class VictoryManager : MonoBehaviour
{
    [SerializeField] private GameObject victoryObject;

    private bool youWin = false;
    void Start()
    {
        if (victoryObject != null)
        {
            victoryObject.SetActive(false);
        }
    }
    void Update()
    {
        if (youWin && Input.GetKeyDown(KeyCode.Return))
        {
            Restart();
        }   
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.tag == "Player") && !youWin)
        {
            ShowVictory();
            Debug.Log("ENTRE");
        }
    }

    void ShowVictory()
    {
        youWin = true;
        victoryObject.SetActive(true);

        Time.timeScale = 0f;
    }

    void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool isGameOver = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Text gameovertext;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RestartGame()
    {

        SceneManager.LoadScene("SampleScene");
        // Logic to restart the game
        // This could involve reloading the current scene or resetting game state
        //UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }

    public void EndGame()
    {
        isGameOver = true;

        gameovertext.gameObject.SetActive(true);
        // Logic to end the game
        // This could involve showing a game over screen or quitting the application
        Debug.Log("Game Over!");
        Application.Quit();
    }
    
}

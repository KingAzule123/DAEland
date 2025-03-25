using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    private bool isPaused = false;
    public GameObject pauseMenu; // Reference to the pause menu UI

    public void OnStartGameButtonClicked()
    {
        Debug.Log("Game Start");
        SceneManager.LoadScene("GameScene"); // Replace "GameScene" with your actual scene name
    }

    public void TogglePause()
    {
        isPaused = !isPaused;

        // Only stop the time-related actions if paused
        if (isPaused)
        {
            Time.timeScale = 0; // Stops all time-based movement, etc.
            pauseMenu.SetActive(true); // Show the pause menu
            Debug.Log("Paused");
        }
        else
        {
            Time.timeScale = 1; // Resumes time
            pauseMenu.SetActive(false); // Hide the pause menu
            Debug.Log("Unpaused");
        }
    }
}

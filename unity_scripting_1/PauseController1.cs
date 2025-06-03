using UnityEngine;

public class PauseController : MonoBehaviour
{
    [Header("Drag your UI GameObjects here")]
    [Tooltip("This can be a parent panel or empty that holds both Pause & Play buttons (or any pause overlay).")]
    public GameObject pauseMenuUI;

    [Tooltip("This is the single Pause button GameObject.")]
    public GameObject pauseButton;

    [Tooltip("This is the single Play (Resume) button GameObject.")]
    public GameObject resumeButton;

    void Start()
    {
        // At game start, we want the game running (timeScale = 1),
        // and only the Pause button visible. The Pause menu UI (which might contain both buttons)
        // should be hidden.
        Time.timeScale = 1f;

        if (pauseMenuUI != null)
            pauseMenuUI.SetActive(false);

        // If for some reason your Pause menu UI is the same parent as both buttons,
        // just make sure that panel is inactive. Then, later in PauseGame()/ResumeGame()
        // we can choose which button to show or hide as needed.

        if (pauseButton != null)
            pauseButton.SetActive(true);

        if (resumeButton != null)
            resumeButton.SetActive(false);
    }

    /// <summary>
    /// Call this method from your Pause button's OnClick().
    /// </summary>
    public void PauseGame()
    {
        // 1) Freeze all in-game movement/physics/animations:
        Time.timeScale = 0f;

        // 2) Show any UI you want to display when paused:
        if (pauseMenuUI != null)
            pauseMenuUI.SetActive(true);

        // 3) Hide the Pause button (so user can't spam it):
        if (pauseButton != null)
            pauseButton.SetActive(false);

        // 4) Show the Resume (Play) button:
        if (resumeButton != null)
            resumeButton.SetActive(true);
    }

    /// <summary>
    /// Call this method from your Play (Resume) button's OnClick().
    /// </summary>
    public void ResumeGame()
    {
        // 1) Unfreeze everything:
        Time.timeScale = 1f;

        // 2) Hide the pause UI (so buttons go away):
        if (pauseMenuUI != null)
            pauseMenuUI.SetActive(false);

        // 3) Show the Pause button again:
        if (pauseButton != null)
            pauseButton.SetActive(true);

        // 4) Hide the Resume (Play) button:
        if (resumeButton != null)
            resumeButton.SetActive(false);
    }
}

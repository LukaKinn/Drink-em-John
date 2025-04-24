using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    [SerializeField] private GameObject options;

    // Start the game
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    // Enter options
    public void OpenOptions()
    {
        options.SetActive(true);
    }

    // Close Options
    public void CloseOptions()
    {
        options.SetActive(false);
    }

    // Quit to desktop
    public void QuitGame()
    {
        Application.Quit();
    }

}

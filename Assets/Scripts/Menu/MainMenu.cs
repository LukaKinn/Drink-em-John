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

    public void CloseOptions()
    {
        options.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}

using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(0);

    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Exiting game");
    }
}

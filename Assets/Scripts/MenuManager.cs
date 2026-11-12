using UnityEditor.SceneManagement;
using UnityEngine;
public class MenuManager : MonoBehaviour
{
    public void StartGame()
    {
        EditorSceneManager.LoadScene("level1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

using UnityEditor.SceneManagement;
using UnityEngine;
public class MenuManager : MonoBehaviour
{
    public void StartGame() //Ao clicar no botão de iniciar o jogo
    {
        EditorSceneManager.LoadScene("level1"); //O SceneManager acionará a cena "level1"
    }

    public void QuitGame() //Ao clicar no botão de fechar o jogo
    {
        Application.Quit(); //O jogo fechará
    }
}

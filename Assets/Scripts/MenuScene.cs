using UnityEditor.SceneManagement;
using UnityEngine;

public class MenuScene : MonoBehaviour
{
    public GameObject painelPause;
    public GameObject painelGameOver;
    public GameObject painelVitoria;

    bool pausado = false;
    bool jogoacabou = false;
    bool ganhou = false;

    void Start()
    {
        painelPause.SetActive(false);
        painelGameOver.SetActive(false);
        painelVitoria.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausado)
            {
                Continuar();
            }
            else
            {
                Pausar();
            }
        }
    }
    public void Pausar()
    {
        if (jogoacabou == false)
        {
            pausado = true;
            painelPause.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void Continuar()
    {
        pausado = false;
        painelPause.SetActive(false);
        Time.timeScale = 1f;
    }
    public void MostrarGameOver()
    {
        jogoacabou = true;
        painelGameOver.SetActive(true);
        Time.timeScale = 0f;
    }
    public void MostrarVitoria()
    {
        ganhou = true;
        painelVitoria.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Reiniciar()
    {
        Time.timeScale = 1f;
        EditorSceneManager.LoadScene("level1");
    }
    public void PassarFase()
    {
        Time.timeScale = 1f;
        EditorSceneManager.LoadScene(2);
    }
}
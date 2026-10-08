using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using System;

public class SceneManager : MonoBehaviour
{
    public GameObject loadingPanel;
    public Slider loadingBar;

    public void Jogar()
    {
        loadingPanel.SetActive(true);
        StartCoroutine(CarregarLevel());
    }

    IEnumerator CarregarLevel()
    {
        AsyncOperation operacao = LoadSceneAsync("level1");

        while (!operacao.isDone)
        {
            float progresso = Mathf.Clamp01(operacao.progress / 0.9f);

            loadingBar.value = progresso;

            yield return null;
        }
    }

    private static AsyncOperation LoadSceneAsync(string v)
    {
        throw new NotImplementedException();
    }

    internal static void LoadScene(int v)
    {
        throw new NotImplementedException();
    }
}
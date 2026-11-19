using UnityEditor.SceneManagement;
using UnityEngine;

public class MenuScene : MonoBehaviour
{
    public GameObject painelPause; //Atribuirá um GameObject ao painel de pausa
    public GameObject painelGameOver; //Atribuirá um GameObject ao painel de derrota
    public GameObject painelVitoria; //Atribuirá um GameObject ao painel de vitória

    bool pausado = false; //Atribuirá uma variável booliana inicialmente falsa ao iniciar o jogo
    bool jogoacabou = false; //Atribuirá uma variável booliana ao painel desativando ao inciar a cena
    bool ganhou = false; //Atribuirá uma variável booliana ao painel desativando ao inciar a cena

    void Start()
    {
        painelPause.SetActive(false); //Atribuirá ao painel de pausa desativando ao inciar a cena (Quando verdadeira deixará o painel aparecendo até outro atributo desativá-la ou mudar a cena)
        painelGameOver.SetActive(false); //Atribuirá ao painel de derrota desativando ao inciar a cena (Quando verdadeira deixará o painel aparecendo até outro atributo desativá-la ou mudar a cena)
        painelVitoria.SetActive(false); //Atribuirá ao painel de vitória desativando ao inciar a cena (Quando verdadeira deixará o painel aparecendo até outro atributo desativá-la ou mudar a cena)
    }

    // Update is called once per frame
    void Update() //Acionará toda vez que um quadro for atualizado
    {
        if (Input.GetKeyDown(KeyCode.Escape)) //Se a tecla "Espaço" for teclada
        {
            if (pausado) //Se a variável "pausado" for verdadeira
            {
                Continuar(); //O jogo contiuará a rodar
            }
            else //Se não
            {
                Pausar(); //O jogo continuará pausado
            }
        }
    }
    public void Pausar() //Ao pausar
    {
        if (jogoacabou == false) //Se "jogoacabou" for falso
        {
            pausado = true; //"pausado" será verdadeiro
            painelPause.SetActive(true); //A tela de pausa será ativada
            Time.timeScale = 0f; //O tempo será parado
        }
    }
    public void Continuar() //Ao continuar
    {
        pausado = false; //"pausado" será falso
        painelPause.SetActive(false); //Desativará a tela de pausa
        Time.timeScale = 1f; //O tempo voltará ao normal
    }
    public void MostrarGameOver() //Ao mostrar a tela de derrota
    {
        jogoacabou = true; //A variável "jogoacabou" será verdadeira
        painelGameOver.SetActive(true); //Acionará a tela de derrota
        Time.timeScale = 0f; //o tempo será parado
    }
    public void MostrarVitoria() //Ao mostrar a tela de vitória
    {
        ganhou = true; //Avariável "ganhou" será verdadeira
        painelVitoria.SetActive(true); //O painel de vitória aparecerá
        Time.timeScale = 0f; //O tempo será parado
    }
    public void ReiniciarFase1() //Ao clicar para reinciar a fase 1
    {
        Time.timeScale = 1f; //O tempo voltará ao normal
        EditorSceneManager.LoadScene("level1"); //Será recarregada a primaira fase
    }
    public void ReiniciarFase2() //Ao clicar para reiniciar a fase 2
    {
        Time.timeScale = 1f; //O tempo voltará ao normal
        EditorSceneManager.LoadScene("level2"); //Será recarregada a segunda fase
    }
    public void ReiniciarFase3() //Ao clicar para reinicar a fase 3
    {
        Time.timeScale = 1f; //O tempo voltará ao normal
        EditorSceneManager.LoadScene("level3"); //Será recarregada a terceira fase
    }
    public void PassarFase1() //Ao clicar para passar a fase
    {
        Time.timeScale = 1f; //O tempo voltará ao normal
        EditorSceneManager.LoadScene(2); //Será carregada a fase 2
    }
    public void PassarFase2() //Ao clicar para passar a fase 2
    {
        Time.timeScale = 1f; //O tempo voltará ao normal
        EditorSceneManager.LoadScene(3); //Será carregada a fase 3
    }
    public void VoltarMenu() //Ao clicar para voltar ao menu
    {
        Time.timeScale = 1f; //O tempo voltará ao normal
        EditorSceneManager.LoadScene("Menu"); //Será carregado o menu
    }
}
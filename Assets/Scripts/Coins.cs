using Unity.VisualScripting;
using UnityEngine;

public class Coins : MonoBehaviour
{
    private int moedas; //Guarda a quantidade de moedas que o jogador coletou
    private void OnTriggerEnter2D(Collider2D collision) //Quando houver colisão na moeda ativar o void
    {
        if (collision.gameObject.CompareTag("Player")) //Se o(s) objeto(s) que foi(ram) atribuido(s) a tag "Player" encostar(em) na moeda
        {
            Debug.Log("Entrou"); //O código dará uma entrada
            Destroy(this.gameObject); //O objeto da moeda será destruído
            Debug.Log("Você coletou uma moeda"); //Mandará ao Debug Log a mensagem indicando a coleta de uma moeda
            moedas++; //Somará as moedas na contagem
            Debug.Log(moedas);
        }   
    }
}

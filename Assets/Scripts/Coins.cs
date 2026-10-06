using Unity.VisualScripting;
using UnityEngine;

public class Coins : MonoBehaviour
{
    private int moedas;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Entrou");
            Destroy(this.gameObject);
            Debug.Log("Você coletou uma moeda");
            moedas++; 
        }
    }
}

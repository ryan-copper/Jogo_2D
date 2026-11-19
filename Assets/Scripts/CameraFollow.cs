using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform alvo; //Cria um "alvo" que é atribuido ao player ou a qualquer outro objeto que a câmera tenha que seguir
    public Vector3 distancia = new Vector3(0f, 0f, -10f); //Distância que a câmera fica do player
    public bool movimentosuave = true; //Ativa / desativa o movimento suave da câmera
    public float velocidade = 5f; //Velocidade da câmera

    void LateUpdate() //Adiciona um atraso ao update por frame
    {
        Vector3 PosicaoDesejada = alvo.position + distancia; //A posição desejada será igual à posição do player + a distância

        if(movimentosuave == true) //Se movimentosave for verdadeira
        {
            transform.position = Vector3.Lerp(transform.position, PosicaoDesejada, velocidade + Time.deltaTime); //Lerp atribui a posição desejada a velocidade + variação do tempo
        }
        else //Se não
        {
            transform.position = PosicaoDesejada; //A posição da câmera será a mesma da posição desejada da câmera
        }
    }

}

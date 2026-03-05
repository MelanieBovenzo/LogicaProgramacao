using UnityEngine;

public class IntroVariaveis : MonoBehaviour
{
    public string nomeJogador;
    public int idadeJogador;
    public float alturaJogador;
    public bool jogadorEstuda;

    void Start() {
        Debug.Log(nomeJogador);
        Debug.Log(idadeJogador);
        Debug.Log(alturaJogador);
        Debug.Log(jogadorEstuda);
    }
}

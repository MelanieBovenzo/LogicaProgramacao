using UnityEngine;

public class Exercicio03 : MonoBehaviour
{
    private int pontos = 10;
    private int multiplicador = 3;
    void Start()
    {
        int pontuacaoFinal = pontos * multiplicador;
        print(pontuacaoFinal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

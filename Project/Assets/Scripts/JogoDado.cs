using UnityEngine;

public class JogoDado : MonoBehaviour
{
    private int jogador1;
    private int jogador2;
    private int dado1;
    private int dado2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            dado1 = Random.Range(1, 7);
            dado2 = Random.Range(1, 7);

            if (dado1 > dado2)
            {
                print("JOGADOR 1 PONTUOU!!!!!! DADO 1: " + dado1 + " DADO 2: " + dado2);
                ++jogador1;
                // jogador1 = jogador1 + 1;
            }
            if (dado1 < dado2)
            {
                print("JOGADOR 2 PONTUOU!!!!!! DADO 1: " + dado1 + " DADO 2: " + dado2);
                ++jogador2;
            }

            if (jogador1 >= 3)
            {
                print("JOGADOR 1 VENCEU!!!!!!");
            }
            if (jogador2 >= 3)
            {
                print("JOGADOR 2 VENCEU!!!!!!");
            }
        }
    }
}

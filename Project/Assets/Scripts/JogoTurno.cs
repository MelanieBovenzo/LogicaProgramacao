using UnityEngine;
using UnityEngine.Windows;

public class JogoTurno : MonoBehaviour
{
    [Header("Selecione um total de 10 pontos")]
    [SerializeField] private int vidaJogador;
    [SerializeField] private int ataqueJogador;
    [SerializeField] private int defesaJogador;

    int vidaCPU = 1;
    int ataqueCPU = 1;
    int defesaCPU = 1;

    bool vezJogador;

    void Start()
    {
        if (vidaJogador == 0 || ataqueJogador == 0 || defesaJogador == 0)
        {
            print("Os valores não podem ser 0");
        }
        if (vidaJogador + defesaJogador + ataqueJogador > 10)
        {
            print("Atribua apenas 10 pontos");
        }

        int index = 1;
        
        while (index <= 7)
        {
            int aleatorio = Random.Range(67, 70);
            if (aleatorio == 67)
            {
                vidaCPU++;
            }
            else if (aleatorio == 68)
            {
                defesaCPU++;
            }
            else
            {
                ataqueCPU++;
            }
            index++;
        }

        print("STATUS DA CPU Defesa: " + defesaCPU + " Ataque: " + ataqueCPU + " Vida: " +  vidaCPU);

        int moeda = Random.Range(1, 3);

        if (moeda == 1)
        {
            vezJogador = true;
        }
        else
        {
            vezJogador = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        int defesaTemp = 0;
        int defesaTempCPU = 0;
        if (UnityEngine.Input.anyKeyDown)
        {
            if (vezJogador)
            {
                int dadoPar = Random.Range(1, 7);

                if (dadoPar % 2 == 0)
                {
                    // Ataque
                    int ataque = Random.Range(1, 7) + ataqueJogador;
                    if (ataque - defesaCPU - defesaTempCPU > 0)
                    {
                        vidaCPU -= ataque - defesaCPU - defesaTempCPU;
                    }
                    print("Turno de ataque, seu dano será " + ataque);
                    print("Vida da CPU: " + vidaCPU);
                    defesaTemp = 0;
                    defesaTempCPU = 0;

                }
                else
                {
                    // Defesa
                    defesaTemp = Random.Range(1, 7) + defesaJogador;
                    print("Defesa do jogador aumentada para " +  (defesaTemp + defesaJogador));
                }
                vezJogador = false;
            }
            else
            {
                int dadoPar = Random.Range(1, 7);

                if (dadoPar % 2 == 0)
                {
                    // Ataque
                    int ataque = Random.Range(1, 7) + ataqueCPU;
                    if (ataque - defesaJogador - defesaTemp > 0)
                    {
                        vidaJogador -= ataque - defesaJogador - defesaTemp;
                    }
                    print("Turno de ataque, dano da CPU será " + ataque);
                    print("Vida do jogador: " + vidaJogador);
                    defesaTemp = 0;
                    defesaTempCPU = 0;
                }
                else
                {
                    // Defesa
                    defesaTempCPU = Random.Range(1, 7);
                    print("Defesa da CPU aumentada para " + (defesaTempCPU + defesaCPU));

                }
                vezJogador = true;
            }
            if (vidaJogador <= 0)
            {
                print("Você PERDEU!!!!!");
            }
            if (vidaCPU <= 0) 
            {
                print("Você GANHOU!!!111!!!11!");
            }
        }
    }
}

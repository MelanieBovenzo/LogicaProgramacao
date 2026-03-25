using UnityEngine;

public class JogoNumero : MonoBehaviour
{
    [SerializeField] private int numeroDeTentativas;
    [SerializeField] private int numeroSelecionado;
    [SerializeField] private int dificuldade;
    [SerializeField] private bool dicks;
    private bool jogando = true;
    private int numeroSecreto;
    private int tentativas;

    private void Start()
    {
        switch (dificuldade)
        {
            case 1:
                numeroSecreto = Random.Range(1, 51);
                break;
            case 2:
                numeroSecreto = Random.Range(1, 101);
                break;
            case 3:
                numeroSecreto = Random.Range(1, 501);
                break;
            default:
                print("ESCOLHE DIFICULDADE CARAMBA");
                numeroSecreto = 67;
                break;
        }
        dick();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown && jogando)
        {
            tentativas++;
            if (tentativas > numeroDeTentativas)
            {
                print("Acabaram suas tentativas!");
            }
            else
            {
                if (numeroSelecionado > numeroSecreto)
                {
                    print("muito alto");
                }
                else if (numeroSelecionado < numeroSecreto)
                {
                    print("muito baixo");
                }
                else
                {
                    print("ACERTOU! Numero secreto era " + numeroSecreto + " e você acertou em " + tentativas + " tentativas");
                    jogando = false;
                }
            }
        }
    }

    private void dick()
    {
        if (dicks)
        {
            print("o número está entre " + Random.Range(numeroSecreto - dificuldade*30, numeroSecreto) + " e " + Random.Range(numeroSecreto + 1, numeroSecreto + dificuldade * 30));
        }
    }
}

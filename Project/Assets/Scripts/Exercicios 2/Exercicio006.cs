using UnityEngine;

public class Exercicio006 : MonoBehaviour
{
    [SerializeField] int distancia;
    [SerializeField] int tempo;
    void Start()
    {
        float velocidadeMedia = distancia / tempo;

        print(velocidadeMedia);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

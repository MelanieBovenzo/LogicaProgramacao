using UnityEngine;

public class Exercicio11 : MonoBehaviour
{
    [SerializeField] float velocidadeInicial;
    [SerializeField] float aceleracao;
    [SerializeField] float tempo;
    void Start()
    {
        float velocidadeFinal = velocidadeInicial + aceleracao * tempo;
        print(velocidadeFinal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using UnityEditor;
using UnityEngine;

public class Exemplo2 : MonoBehaviour
{
    [SerializeField] private string nome;
    [SerializeField] private float hora;
    [SerializeField] private float valorHora;

    void Start()
    {
        float valorCalculado = hora * valorHora;

        print(nome + " ganhou " + valorCalculado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

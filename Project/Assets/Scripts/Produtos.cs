using UnityEngine;

public class Produtos : MonoBehaviour
{
    [SerializeField] private string nome;
    [SerializeField] private float valor;
    [SerializeField] private float desconto;

    void Start()
    {
        print(nome + " seu valor é: " + valor);

        float valorComDesconto = valor * desconto;

        valor = valor - valorComDesconto;
        
        print(nome + " valor com desconto: " + valor);
    }
}

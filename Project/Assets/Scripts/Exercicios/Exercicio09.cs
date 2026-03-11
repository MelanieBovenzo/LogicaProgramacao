using UnityEngine;

public class Exercicio09 : MonoBehaviour
{
    [SerializeField] int numero;
    void Start()
    {
        print("dobro: " + (numero * 2));
        print("metade: " + (numero / 2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

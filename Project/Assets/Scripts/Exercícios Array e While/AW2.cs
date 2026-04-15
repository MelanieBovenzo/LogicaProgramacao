using UnityEngine;

public class AW2 : MonoBehaviour
{
    [SerializeField] int[] numeros = new int[5];
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 0;
        int soma = 0;
        while (i < numeros.Length)
        {
            soma += numeros[i];
            i++;
        }
        print(soma);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

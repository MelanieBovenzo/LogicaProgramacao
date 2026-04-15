using UnityEngine;

public class AW3 : MonoBehaviour
{
    [SerializeField] int[] numeros = new int[5];
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 0;
        int maior_valor = 0;
        while (i < numeros.Length)
        {
            if (numeros[i] > maior_valor)
            {
                maior_valor = numeros[i];
            }
            i++;
        }
        print(maior_valor);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

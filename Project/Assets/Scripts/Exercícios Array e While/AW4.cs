using UnityEngine;

public class AW4 : MonoBehaviour
{
    [SerializeField] int[] numeros = new int[5];
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 0;
        int pares = 0;
        while (i < numeros.Length)
        {
            if (numeros[i] % 2 == 0)
            {
                pares++;
            }
            i++;
        }
        print(pares);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

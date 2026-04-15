using UnityEngine;

public class AW5 : MonoBehaviour
{
    [SerializeField] int[] numeros = new int[5];
    int[] numeros_invertidos = new int[5];
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = numeros.Length - 1;
        int y = 0;
        while (i >= 0)
        {
            numeros_invertidos[y] = numeros[i];
            y++;
        }
        i = 0;
        while (i < numeros_invertidos.Length)
        {
            print(numeros_invertidos[i]);
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

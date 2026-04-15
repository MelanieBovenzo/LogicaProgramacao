using UnityEngine;

public class AW6 : MonoBehaviour
{
    [SerializeField] int numero_checado;
    [SerializeField] int[] numeros = new int[5];
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 0;
        bool existe = false;
        while (i < numeros.Length)
        {
            if (numeros[i] == numero_checado)
            {
                existe = true;
            }
            i++;
        }
        print(existe);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

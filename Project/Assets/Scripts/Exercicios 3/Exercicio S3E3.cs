using UnityEngine;

public class ExercicioS3E3 : MonoBehaviour
{
    [SerializeField] int numero;
    void Start()
    {
        if (numero % 2 == 0)
        {
            print("é par");
        }
        else
        {
            print("é ímpar");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

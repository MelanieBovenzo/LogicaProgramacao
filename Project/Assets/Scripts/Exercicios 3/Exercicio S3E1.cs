using UnityEngine;

public class ExercicioS3E1 : MonoBehaviour
{
    [SerializeField] int valor1;
    [SerializeField] int valor2;
    void Start()
    {
        if (valor1 > valor2)
        {
            print("maior valor: " + valor1);
        }
        else if (valor2 > valor1){
            print("maior valor: " + valor2);
        }
        else
        {
            print("valores iguais");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

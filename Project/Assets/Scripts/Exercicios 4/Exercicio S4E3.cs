using UnityEngine;

public class ExercicioS4E3 : MonoBehaviour
{
    public int pontos = 101;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pontos > 100)
        {
            print("Você Venceu!");
        }
    }
}

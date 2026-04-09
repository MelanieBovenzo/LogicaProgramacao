using UnityEngine;

public class ExercicioS3E2 : MonoBehaviour
{
    [SerializeField] int idade;
    void Start()
    {
        if (idade >= 18)
        {
            print("pessoa é +18 (pode jogar lol)");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

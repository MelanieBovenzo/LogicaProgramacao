using UnityEngine;

public class ExercicioS4E8 : MonoBehaviour
{
    [SerializeField] int nivelJogador = 8;
    [SerializeField] int nivelInimigo = 8;
    void Start()
    {
        if (nivelJogador >= nivelInimigo)
        {
            print("pode lutar");
        } 
        else
        {
            print("muito perigoso");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

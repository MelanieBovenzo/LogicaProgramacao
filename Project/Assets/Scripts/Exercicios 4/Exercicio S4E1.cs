using UnityEngine;

public class ExercicioS4E1 : MonoBehaviour
{
    public int vida = 100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (vida <= 0)
        {
            print("GAME OVER SOBRA NADA ITS SO OVER MEU CASA SEM CHAPÉU");
        }
    }
}

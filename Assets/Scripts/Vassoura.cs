using UnityEngine;

public class Vassoura : MonoBehaviour
{
    public Transform transformRespawn;
    public Mouse mouse;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if(mouse.objetoAgarrado == false)
        {
            transform.position = transformRespawn.position;
        }
        
        
    }
}

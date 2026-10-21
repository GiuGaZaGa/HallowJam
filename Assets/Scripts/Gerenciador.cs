using UnityEngine;
using UnityEngine.SceneManagement;

public class Gerenciador : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void CarregarCenas(string nomeCena)
    {
        SceneManager.LoadScene(nomeCena);
    }
    public void Sair()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

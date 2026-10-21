using UnityEngine;

public class Mouse : MonoBehaviour
{
    private Camera mainCamera;
    private GameObject objetoArrastado;
    private Vector2 offset;
    public bool objetoAgarrado = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    void Awake()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Guarda a posição do mouse em pixels na tela (ex: X: 1920, Y: 1080)
            Vector3 posicaoMouseTela = Input.mousePosition;

            // Exibe a posição no Console da Unity
            Debug.Log("Clique detectado no ponto da tela: " + posicaoMouseTela);
        }
        // 1. Pega a posição do mouse e converte para o mundo 2D
        Vector3 posicaoMouseMundo = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        posicaoMouseMundo.z = 0f;

        // 2. Quando CLICA: verifica se clicou em um objeto com Collider2D
        if (Input.GetMouseButtonDown(0))
        {
            Collider2D hit = Physics2D.OverlapPoint(posicaoMouseMundo);

            if (hit != null)
            {
                objetoAgarrado = true;
                objetoArrastado = hit.gameObject;
                offset = (Vector2)objetoArrastado.transform.position - (Vector2)posicaoMouseMundo;
                Debug.Log("Peguei: " + objetoArrastado.name);
            }
        }

        // 3. Enquanto SEGURA: move o objeto junto com o mouse
        if (objetoArrastado != null && Input.GetMouseButton(0))
        {
            objetoArrastado.transform.position = new Vector3(posicaoMouseMundo.x + offset.x, posicaoMouseMundo.y + offset.y, 0f);
        }

        // 4. Quando SOLTA: descarta a referência do objeto
        if (Input.GetMouseButtonUp(0) && objetoArrastado != null)
        {
            objetoAgarrado = false;
            Debug.Log("Soltei: " + objetoArrastado.name);
            objetoArrastado = null;
        }

    }
}
   
    
       

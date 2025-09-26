using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float rotateSpeed;          // Velocidad de rotación, editable en Inspector

    public GameObject onCollectEffect;


    // Start se ejecuta al iniciar el juego
    void Start()
    {
        // Puedes inicializar valores si es necesario
    }

    // Update se ejecuta una vez por frame
    void Update()
    {
        // Hace girar el objeto sobre el eje Y continuamente
        transform.Rotate(0, rotateSpeed, 0);
    }

    // Detecta colisiones con triggers
    private void OnTriggerEnter(Collider other)
    {
        // Solo reacciona si el objeto que colisiona tiene la etiqueta "Player"
        if (other.CompareTag("Player"))
        {
            // Destruye el objeto coleccionable
            Destroy(gameObject);

            // Instancia el efecto de partículas en la posición y rotación del coleccionable
            Instantiate(onCollectEffect, transform.position, transform.rotation);
        }
    }
}

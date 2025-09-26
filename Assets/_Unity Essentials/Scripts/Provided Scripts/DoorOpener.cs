using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    private Animator doorAnimator;

    void Start()
    {
        // Referencia al Animator de la puerta
        doorAnimator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Verifica que sea el jugador
        if (other.CompareTag("Player"))
        {
            if (doorAnimator != null)
            {
                doorAnimator.SetTrigger("Door_Open");
            }
        }
    }
}

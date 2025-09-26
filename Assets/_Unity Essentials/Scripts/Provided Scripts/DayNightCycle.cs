using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Duración de un día completo en segundos de tiempo real.")]
    public float dayDurationInSeconds = 120f; // valor por defecto = 2 minutos

    void Update()
    {
        // Calcula cuánto debe rotar la luz por segundo
        float rotationPerSecond = 360f / dayDurationInSeconds;

        // Rota el objeto (la luz direccional) alrededor del eje X
        transform.Rotate(Vector3.right * rotationPerSecond * Time.deltaTime);
    }
}

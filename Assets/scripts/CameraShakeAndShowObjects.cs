using UnityEngine;
using System.Collections;

public class CameraShakeAndShowObjects : MonoBehaviour
{
    public GameObject[] objectsToAppear;  // Array de objetos que aparecerán
    public float shakeDuration = 1.0f;  // Duración de la vibración de la cámara
    public float shakeAmount = 0.2f;    // Intensidad de la vibración

    private Vector3 initialLocalPosition;
    private Transform cameraTransform;

    void Start()
    {
        // Encuentra la cámara en el hijo del jugador
        cameraTransform = Camera.main.transform;
        // Almacena la posición inicial local de la cámara
        initialLocalPosition = cameraTransform.localPosition;

        // Asegúrate de que los objetos estén desactivados al inicio
        foreach (GameObject obj in objectsToAppear)
        {
            obj.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  // Asegúrate de que el objeto que colisiona tenga el tag "Player"
        {
            StartCoroutine(ShakeCamera());
        }
    }

    IEnumerator ShakeCamera()
    {
        float elapsedTime = 0.0f;

        while (elapsedTime < shakeDuration)
        {
            Vector3 randomPoint = initialLocalPosition + Random.insideUnitSphere * shakeAmount;
            cameraTransform.localPosition = new Vector3(randomPoint.x, randomPoint.y, initialLocalPosition.z);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        cameraTransform.localPosition = initialLocalPosition;

        // Aparecen los objetos
        foreach (GameObject obj in objectsToAppear)
        {
            obj.SetActive(true);
        }
    }
}

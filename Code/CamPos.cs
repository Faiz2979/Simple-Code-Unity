using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Objek yang akan diikuti
    public float height = 9500f; // Tinggi kamera di atas objek
    public float smoothSpeed = 0.125f; // Kecepatan pergerakan kamera

    void LateUpdate()
    {
        if (target != null)
        {
            // Set posisi kamera berdasarkan posisi objek ditambah tinggi yang diinginkan
            Vector3 desiredPosition = target.position + new Vector3(0, height, 0);

            // Interpolasi linear untuk pergerakan yang halus
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

            // Set posisi kamera
            transform.position = smoothedPosition;

            // Kamera selalu menghadap ke objek
            transform.LookAt(target);
        }
    }
}

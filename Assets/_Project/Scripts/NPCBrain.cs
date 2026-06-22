using UnityEngine;

public class NPCBrain : MonoBehaviour
{
    public Transform player;

    public float detectionRange = 3f;

    private bool detected = false;


    void Update()
    {
        float distance = Vector3.Distance(
            transform.position,
            player.position
        );

        if(distance < detectionRange && !detected)
        {
            detected = true;

            Debug.Log("Sharma Ji: Beta, yeh tumhara ghar nahi hai! 😂");
        }

        if(distance >= detectionRange)
        {
            detected = false;
        }
    }
}
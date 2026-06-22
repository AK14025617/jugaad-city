using UnityEngine;

public class NPCBrain : MonoBehaviour
{
    public Transform player;
    public float detectionRange = 5f;
    public float chaseSpeed = 2f;

    public DialogueManager dialogueManager;

    private bool isChasing = false;

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        if(distance <= detectionRange)
        {
            if(!isChasing)
            {
                Debug.Log("Dialogue Triggered");
                dialogueManager.ShowDialogue(
                    "Sharma Ji: Ruk beta! Papa ko bolta hu !"
                );

                isChasing = true;
            }

            ChasePlayer();
        }
        else
        {
            isChasing = false;
        }
    }

    void ChasePlayer()
    {
        Vector3 direction = player.position - transform.position;
        direction.y = 0;

        transform.position += direction.normalized * chaseSpeed * Time.deltaTime;

        transform.LookAt(player);
    }
}
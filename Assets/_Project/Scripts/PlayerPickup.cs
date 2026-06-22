using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    public bool hasBall = false;
    public DialogueManager dialogueManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            hasBall = true;
            Destroy(other.gameObject);

            dialogueManager.ShowDialogue("Ball mil gayi! Ab Sharma Ji ke ghar jao.");
        }
    }
}
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TMP_Text dialogueText;

    public void ShowDialogue(string message)
    {
        dialogueText.text = message;

        CancelInvoke();
        Invoke("ClearDialogue", 3f);
    }

    void ClearDialogue()
    {
        dialogueText.text = "";
    }
}
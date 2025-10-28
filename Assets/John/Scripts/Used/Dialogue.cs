using UnityEngine;
using System.Collections.Generic;
using System;
[Serializable]
public struct DialoguePiece
{
    public string name;
    [TextArea] public string dialogue;
}

public class Dialogue : MonoBehaviour
{
   public List<DialoguePiece> dialogue;

    public TMPro.TMP_Text dialogueText;
    public TMPro.TMP_Text dialoguNname;
    public void StartDialogue()
    {
        Debug.Log("hello,World");
    }
}

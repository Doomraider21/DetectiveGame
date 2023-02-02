using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueController : MonoBehaviour
{
    public TextMeshProUGUI DialogueText;
    public TextMeshProUGUI DialogueName;
    public Animator DialogueAnimator;
    public string[] Sentences;
    public int SentenceStart;
    public int SentenceEnd;
    public string Name;
    public float DialogueSpeed;
    private int Index = 0;
    private bool StartDialogue = true;
    private bool NextText = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (StartDialogue)
            {
                Index = SentenceStart;
                DialogueAnimator.SetTrigger("Entry");
                StartDialogue= false;
                BeginDialogue();
                NextText = true;
            }
            if (NextText)
            {
                NextText = false;
                NextSentence();
            }
        }

    }

    void BeginDialogue()
    {
        DialogueName.text = Name;
    }

    void NextSentence()
    {
        if(Index <= SentenceEnd)
        {
            DialogueText.text = "";
            StartCoroutine(WriteSentence());
            
        }
        else
        {
            DialogueText.text = "";
            DialogueAnimator.SetTrigger("Exit");
            StartDialogue= true;
        }
    }

    IEnumerator WriteSentence()
    {
        foreach(char Character in Sentences[Index].ToCharArray())
        {
            DialogueText.text += Character;
            yield return new WaitForSeconds(DialogueSpeed);
        }
        NextText = true;
        Index++;
    } 
}
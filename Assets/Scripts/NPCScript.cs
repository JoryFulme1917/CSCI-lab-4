using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPCDialogue : MonoBehaviour
{
    public float interactionDistance = 3f;
    public string[] dialogueLines;
    public GameObject dialoguePanel;
    public TextMeshProUGUI dialogueText;
    
    private Transform player;
    private int currentLine = 0;
    private bool isInRange = false;
    private bool isDialogueActive = false;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        
        if (dialoguePanel != null)
            dialoguePanel.SetActive(false);
    }
    
    void Update()
    {
        CheckDistance();
        
        if (isInRange && Input.GetKeyDown(KeyCode.E))
        {
            if (!isDialogueActive)
            {
                StartDialogue();
            }
            else
            {
                DisplayNextLine();
            }
        }
    }
    
    void CheckDistance()
    {
        float distance = Vector3.Distance(transform.position, player.position);
        
        if (distance <= interactionDistance)
        {
            isInRange = true;
        }
        else
        {
            isInRange = false;
            
            if (isDialogueActive)
            {
                EndDialogue();
            }
        }
    }
    
    void StartDialogue()
    {
        isDialogueActive = true;
        currentLine = 0;
        
        if (dialoguePanel != null)
            dialoguePanel.SetActive(true);
            
        DisplayDialogue();
    }
    
    void DisplayDialogue()
    {
        if (dialogueLines.Length > 0 && currentLine < dialogueLines.Length)
        {
            if (dialogueText != null)
                dialogueText.text = dialogueLines[currentLine];
        }
    }
    
    void DisplayNextLine()
    {
        currentLine++;
        
        if (currentLine >= dialogueLines.Length)
        {
            EndDialogue();
        }
        else
        {
            DisplayDialogue();
        }
    }
    
    void EndDialogue()
    {
        isDialogueActive = false;
        
        if (dialoguePanel != null)
            dialoguePanel.SetActive(false);
    }
    
}
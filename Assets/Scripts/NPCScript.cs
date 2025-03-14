using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPCDialogue : MonoBehaviour
{
    public float interactionDistance = 3f;
    public string[] initialDialogueLines;
    public string[] completionDialogueLines;
    public GameObject dialoguePanel;
    public TextMeshProUGUI dialogueText;
    
    // Reference to the script that tracks the condition
    public TargetTracker targetTracker;
    
    private Transform player;
    private int currentLine = 0;
    private bool isInRange = false;
    private bool isDialogueActive = false;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        
        if (dialoguePanel != null)
            dialoguePanel.SetActive(false);
            
        if (targetTracker == null)
            Debug.LogWarning("Target Manager not assigned to NPC Dialogue!");
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
        string[] currentDialogueSet = GetCurrentDialogueSet();
        
        if (currentDialogueSet.Length > 0 && currentLine < currentDialogueSet.Length)
        {
            if (dialogueText != null)
                dialogueText.text = currentDialogueSet[currentLine];
        }
    }
    
    string[] GetCurrentDialogueSet()
    {
        if (targetTracker != null && targetTracker.AllTargetsHit)
        {
            return completionDialogueLines;
        }
        else
        {
            return initialDialogueLines;
        }
    }
    
    void DisplayNextLine()
    {
        currentLine++;
        
        string[] currentDialogueSet = GetCurrentDialogueSet();
        
        if (currentLine >= currentDialogueSet.Length)
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
        {
            dialoguePanel.SetActive(false);
        }
        if (targetTracker.AllTargetsHit)
        {
            //Scene Transition    
        }

    }
    
}
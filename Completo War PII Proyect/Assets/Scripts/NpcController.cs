using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(DialogueTrigger))]
public class NpcController : MonoBehaviour
{
    
    private BoxCollider2D col;
    private DialogueTrigger trigger;

    public KeyCode actionA = KeyCode.Z;

    private bool isNearPlayer;

    void Start()
    {
        col = gameObject.GetComponent<BoxCollider2D>();
        trigger = gameObject.GetComponent<DialogueTrigger>();
    }

    void Update()
    {
        if(Input.GetKeyDown(actionA) && isNearPlayer){
            trigger.TriggerDialogue();
        } 
    }

    private void OnTriggerEnter2D(Collider2D other) {
        isNearPlayer = true;
    }

    private void OnTriggerExit2D(Collider2D other) {
        isNearPlayer = false;
    }
}

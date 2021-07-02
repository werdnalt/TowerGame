using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  Allows this class to have its `OnTriggerEnter2D` and `OnTriggerExit2D` to be called by events originating from its children
/// </summary>
interface ChildTriggerable
{
    void OnTriggerEnter2D(Collider2D collision);
    void OnTriggerExit2D(Collider2D collision);
}

public class ChildTriggerDelegate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ChildTriggerable[] triggerables = GetComponentsInParent<ChildTriggerable>();
        for(int i = 0; i < triggerables.Length; i++)
        {
            triggerables[i].OnTriggerEnter2D(collision);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        ChildTriggerable[] triggerables = GetComponentsInParent<ChildTriggerable>();
        for (int i = 0; i < triggerables.Length; i++)
        {
            triggerables[i].OnTriggerExit2D(collision);
        }
    }
}

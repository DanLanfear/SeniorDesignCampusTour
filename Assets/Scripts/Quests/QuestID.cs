using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestID : MonoBehaviour
{
    public QuestCompletionEvent completion;
    public int id = -1;


    public void TriggerEvent()
    {
        if (id != -1)
            completion.Invoke(id);
        else
            Debug.Log("No ID set for this object");
    }
}
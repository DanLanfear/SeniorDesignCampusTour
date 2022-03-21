using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{
    public QuestList objectives;


    public void Progress(int id)
    {
        if (objectives.GetObjective(id).state == State.Assigned)
        {
            Debug.Log("progress");
            objectives.Progress(id);
        }
    }
}
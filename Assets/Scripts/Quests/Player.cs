using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public ObjectiveList objectives;


    public void Progress(int id)
    {
        if(objectives.GetObjective(id).state == State.Assigned)
        {
            Debug.Log("progress");
            objectives.Progress(id);
        }
    }
}

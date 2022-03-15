using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Objective objective;


    public void Progress()
    {
        Debug.Log("progress");
        if(objective.state == State.Assigned)
        {
            Debug.Log("Assigned Objective");

            objective.goal.Progress();
            if(objective.goal.IsReached())
            {
                objective.Complete();
            }
        }
    }
}

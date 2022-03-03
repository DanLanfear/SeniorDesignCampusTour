using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Objective objective;


    public void Progress()
    {
        if(objective.state == State.Assigned)
        {
            objective.goal.Progress();
            if(objective.goal.IsReached())
            {
                objective.Complete();
            }
        }
    }
}

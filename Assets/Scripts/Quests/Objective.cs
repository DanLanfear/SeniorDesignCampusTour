using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[System.Serializable]
public class Objective
{
    public string description;
    public State state = State.Unassigned;
    public ObjGoal goal;
    public TMP_Text text;



    public void Complete()
    {
        if (state == State.Assigned)
        {
            if (goal.IsReached())
            {
                state = State.Complete;
                Debug.Log("Objective complete");
                text.text = text.text + state.ToString();

            }
        }
    }
}

public enum State
{
    Unassigned,
    Assigned,
    Complete
}

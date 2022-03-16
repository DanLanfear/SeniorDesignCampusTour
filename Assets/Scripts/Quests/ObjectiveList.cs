using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ObjectiveList : MonoBehaviour
{
    public List<Objective> objectives;

    private void Start()
    {
        for(int i = 0; i < objectives.Count; i++)
        {
            objectives[i].id = i;
        }
    }

    public Objective GetObjective(int id)
    {
        return objectives[id];
    }

    public void Assign(int id)
    {
        objectives[id].state = State.Assigned;
    }

    public void Progress(int id)
    {
        objectives[id].goal.Progress();
        if(objectives[id].goal.IsReached())
        {
            objectives[id].Complete();
        }
    }

}

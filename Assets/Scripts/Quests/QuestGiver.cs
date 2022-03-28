using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class QuestGiver : MonoBehaviour
{
    public QuestList objectives;
    public Player player;
    public GameObject window;
    public List<TMP_Text> TextList;

    public void Start()
    {
        window.SetActive(true);
        GiveObjective(0);
    }

    public void GiveObjective(int QuestId)
    {
        objectives.Assign(QuestId);
        //ugly for now might work later
        objectives.objectives[QuestId].completedObjective.AddListener(DisplayCompletedObjective);
        DisplayObjective(QuestId);

    }

    public void DisplayObjective(int id)
    {
        //Debug.Log(objectives.GetObjective(id).description);

        TextList[id].text = (objectives.GetObjective(id).description);
    }

    public void DisplayCompletedObjective(int id)
    {
        TextList[id].text = string.Format("<s>{0}</s>", TextList[id].text);
    }
}

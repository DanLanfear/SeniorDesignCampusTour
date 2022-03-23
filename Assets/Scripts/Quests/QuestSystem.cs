using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class QuestSystem : MonoBehaviour
{
    public QuestList objectives;
    public Player player;
    public GameObject window;
    public TMP_Text descText;

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
        //player.objective = obj;
        DisplayObjective(QuestId);

    }

    public void DisplayObjective(int id)
    {
        Debug.Log(objectives.GetObjective(id).description);
        descText.text += (objectives.GetObjective(id).description + "\n");
    }

    public void DisplayCompletedObjective(int id)
    {
        descText.text = string.Format("<s>{0}</s>", descText.text);
    }
}
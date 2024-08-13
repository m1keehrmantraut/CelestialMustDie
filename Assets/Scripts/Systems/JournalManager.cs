using UnityEngine;

[System.Serializable] 
public struct Pages
{
    public string header;
    public string text;
    public Sprite image;
    public bool status;
}

public class JournalManager : MonoBehaviour
{
    
    [SerializeField] private GameObject journalPanel;
    [SerializeField] private JournalPage page;

    public Pages[] pageList;
    
    [HideInInspector] 
    public int tempIndex = 0;
    
    public void JournalActivation(bool mode)
    {
        journalPanel.SetActive(mode);
    }

    public void SetPage(int index)
    {
        tempIndex = index;
        var tempPage = pageList[index];
        page.SetHeader(tempPage.header);
        page.SetText(tempPage.text);
        page.SetImage(tempPage.image);
        page.SetIndex((index + 1).ToString());
    }

    public void PageChanger(int id)
    {
        if (tempIndex + id < pageList.Length && tempIndex + id >= 0)
        {
            if (pageList[tempIndex + id].status)
            {
                tempIndex += id;
                SetPage(tempIndex);
            }
        }
    }

    public void PageUnlocker(int index)
    {
        pageList[index].status = true;
    }
}

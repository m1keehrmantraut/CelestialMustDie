using UnityEngine;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class JournalPage : MonoBehaviour
{   
    [SerializeField] private TMPro.TextMeshProUGUI headerField;

    [SerializeField] private TMPro.TextMeshProUGUI textField;

    [SerializeField] private TMPro.TextMeshProUGUI indexField;

    [SerializeField] private Image imageBox;

    private bool activeStatus;


    public void SetHeader(string header)
    {
        headerField.text = header;
    }

    public void SetText(string text)
    {
        textField.text = text;
    }

    public void SetIndex(string index)
    {
        indexField.text = index;
    }

    public void SetImage(Sprite image)
    {
        imageBox.sprite = image;
        imageBox.SetNativeSize();
    }

    public bool GetStatus()
    {
        return activeStatus;
    }

    public void SetStatus(bool status)
    {
        activeStatus = status;
    }
    
}

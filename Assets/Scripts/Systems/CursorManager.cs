using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class CursorManager : MonoBehaviour
{
    [FormerlySerializedAs("CursorImage")] [SerializeField] [Tooltip("The cursor sprite")]
    private Texture2D cursorImage;

    private Vector2 cursorHotSpot;

    private void Start()
    {
        cursorHotSpot = new Vector2(cursorImage.width / 2, cursorImage.height / 2);
        Cursor.SetCursor(cursorImage, cursorHotSpot, CursorMode.Auto);
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CursorChangeIsland : MonoBehaviour
{
    // buttons
	public Button one;
	public Button two;
	public Button three;
	public Button four;
	public Button five;

    // mouse textures
    public Texture2D key;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    
    void Start()
    {
        
    }

    void Update()
    {
        // buttons
        if(Input.GetMouseButtonDown(1))
        {
            one.onClick.AddListener(TaskOnClick);
            two.onClick.AddListener(TaskOnClick);
            three.onClick.AddListener(TaskOnClick);
            four.onClick.AddListener(TaskOnClick);
            five.onClick.AddListener(TaskOnClick);
        }
    }
    
    public void TaskOnClick()
    {
        // player presses button 1
        if(EventSystem.current.currentSelectedGameObject.name == one.name)
        {
            Debug.Log("one");
            // swap the cursor
            Cursor.SetCursor(key, hotSpot, cursorMode);
        }
        if(EventSystem.current.currentSelectedGameObject.name == two.name)
        {
            Debug.Log("two");
        }
        if(EventSystem.current.currentSelectedGameObject.name == three.name)
        {
            Debug.Log("three");
        }
        if(EventSystem.current.currentSelectedGameObject.name == four.name)
        {
            Debug.Log("four");
        }
        if(EventSystem.current.currentSelectedGameObject.name == five.name)
        {
            Debug.Log("five");
        }
     }
}

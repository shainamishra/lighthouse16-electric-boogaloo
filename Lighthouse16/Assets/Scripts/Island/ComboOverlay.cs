using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ComboOverlay : MonoBehaviour
{
    // gameobjects
    GameObject combo;
    GameObject statueLocked;
    public GameObject statueUnlocked;
    
    public GameObject arrows;
    public GameObject hotbar;
    public static bool unlocked = false;

    // number stuff
    public Text leftText;
    public Text midText;
    public Text rightText;
    public static int num1 = 0;
    public static int num2 = 0;
    public static int num3 = 0;

    // Start is called before the first frame update
    void Start()
    {
        combo = GameObject.Find("Combo");
        statueLocked = GameObject.Find("statueLocked");

        // find text fields
        leftText = GameObject.Find("leftText").GetComponent<Text> ();
        midText = GameObject.Find("midText").GetComponent<Text> ();
        rightText = GameObject.Find("rightText").GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        if(combo.activeSelf == true)
        {
            arrows.gameObject.SetActive(false);
            hotbar.gameObject.SetActive(false);
        } else {
            arrows.gameObject.SetActive(true);
            hotbar.gameObject.SetActive(true);
        }

        if(num1 == 1 && num2 == 1 && num3 == 1)
        {
            unlocked = true;
            closeOverlay();
        }
    }

    public void OnClicked(Button button)
    {
        if(button.name == "X")
        {
            closeOverlay();
        }

        if(button.name == "leftUp")
        {
            // add to total
            num1 = NumAdd(num1);
            // send to text box
            leftText.text = num1.ToString();
        }
        else if(button.name == "leftDown")
        {
            num1 = NumSub(num1);
            leftText.text = num1.ToString();
        }
        if(button.name == "midUp")
        {
            num2 = NumAdd(num2);
            midText.text = num2.ToString();
        }
        else if(button.name == "midDown")
        {
            num2 = NumSub(num2);
            midText.text = num2.ToString();
        }
        if(button.name == "rightUp")
        {
            num3 = NumAdd(num3);
            rightText.text = num3.ToString();
        }
        else if(button.name == "rightDown")
        {
            num3 = NumSub(num3);
            rightText.text = num3.ToString();
        }
    }
    
    public int NumAdd(int num)
    {
        if(num < 9)
        {
            num = (num + 1);
        }
        return num;
    }

    public int NumSub(int num)
    {
        if(num > 0)
        {
            num = (num - 1);
        }
        return num;
    }

    public void closeOverlay()
    {
        if(unlocked == false)
        {
            combo.gameObject.SetActive(false);
            arrows.gameObject.SetActive(true);
            hotbar.gameObject.SetActive(true);
            statueLocked.GetComponent<BoxCollider2D>().enabled = true;
        } else if(unlocked == true)
        {
            combo.gameObject.SetActive(false);
            arrows.gameObject.SetActive(true);
            hotbar.gameObject.SetActive(true);

            statueLocked.gameObject.SetActive(false);
            statueUnlocked.gameObject.SetActive(true);
        }

        // reset numbers to 0
        num1 = 0;
        leftText.text = "0";
        num2 = 0;
        midText.text = "0";
        num3 = 0;
        rightText.text = "0";
    }
}

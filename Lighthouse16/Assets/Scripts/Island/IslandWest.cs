using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandWest : MonoBehaviour
{
    public bool prereq;
    public ChangeImage changeImg;
    public GameObject startImage;
    public GameObject clickedImage;
    public GameObject combo;
    
    public static bool boltcutters;

    // Start is called before the first frame update
    void Start()
    {
        prereq = true;
        changeImg = FindObjectOfType<ChangeImage>();
        startImage.gameObject.SetActive(true);
        clickedImage.gameObject.SetActive(false);
        combo.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update ()
    {
        
    }

    void OnMouseDown ()
    {
        // helmet
        if (gameObject.name == "bucket" && prereq == true)
        {
            clickedImage.name = "bucketUsed";
            change(gameObject, clickedImage);
        }

        // fishing rod
        if (gameObject.name == "rodEmpty" && prereq == true)
        {
            clickedImage.name = "reelUsed";
            change(gameObject, clickedImage);
        }
        
        // statue
        if (gameObject.name == "statueLocked")
        {
            // open combo overlay
            combo.gameObject.SetActive(true);
            // hide hotbar (maybe here, maybe in combo, ill add the x to combo so probably combo)
            // hide arrows too

            if(ComboOverlay.unlocked == true)
            {
                clickedImage.name = "statueUnlocked";
                change(gameObject, clickedImage);
            }
        }
        if (gameObject.name == "statueUnlocked")
        {
            clickedImage.name = "statueUnlockednoItem";
            change(gameObject, clickedImage);
        }
        if (gameObject.name == "statueUnlockednoItem")
        {
            // nothing, print text
        }
    }

// add prereq as a third input so that u can check if the right key is true
    public void change(GameObject gm, GameObject ci)
    {
        if (prereq == true)
        {
            ci.gameObject.SetActive(true);
            gm.gameObject.SetActive(false);
        }
    }
}

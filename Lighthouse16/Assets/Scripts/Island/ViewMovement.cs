using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class WASDMovement : MonoBehaviour
{
    public GameObject North;
    public GameObject East;
    public GameObject South;
    public GameObject West;
    public GameObject Floor;
    public GameObject Ceiling;

    private int dir = 0;
    private int storedView = 0;

    // Start is called before the first frame update
    void Start()
    {
        North.gameObject.SetActive(true);
        East.gameObject.SetActive(false);
        South.gameObject.SetActive(false);
        West.gameObject.SetActive(false);
        Floor.gameObject.SetActive(false);
        Ceiling.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // player presses right arrow
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            // set the direction variabl to 1
            dir = 1;
            // send 1 to view function
            view(dir);
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            dir = 2;
            view(dir);
        }

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            dir = 3;
            view(dir);
        }

        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            dir = 4;
            view(dir);
        }
    }

    void view(int direction)
    {
        // if players click right arrow
        if(direction == 1)
        {
            // view is already on north
            if(North.activeSelf == true)
            {
                // set everything except the next view to false
                North.gameObject.SetActive(false);
                East.gameObject.SetActive(true);
                South.gameObject.SetActive(false);
                West.gameObject.SetActive(false);
                Floor.gameObject.SetActive(false);
                Ceiling.gameObject.SetActive(false);
            }
            // view is already on east
            else if (East.activeSelf == true)
            {
                // set everything except the next view to false
                North.gameObject.SetActive(false);
                East.gameObject.SetActive(false);
                South.gameObject.SetActive(true);
                West.gameObject.SetActive(false);
                Floor.gameObject.SetActive(false);
                Ceiling.gameObject.SetActive(false);
            }
            // view is already on south
            else if (South.activeSelf == true)
            {
                // set everything except the next view to false
                North.gameObject.SetActive(false);
                East.gameObject.SetActive(false);
                South.gameObject.SetActive(false);
                West.gameObject.SetActive(true);
                Floor.gameObject.SetActive(false);
                Ceiling.gameObject.SetActive(false);
            }
            // view is already on west
            else if (West.activeSelf == true)
            {
                // set everything except the next view to false
                North.gameObject.SetActive(true);
                East.gameObject.SetActive(false);
                South.gameObject.SetActive(false);
                West.gameObject.SetActive(false);
                Floor.gameObject.SetActive(false);
                Ceiling.gameObject.SetActive(false);
            }
        }

        // if players click left arrow
        //if(Input.GetKeyDown(KeyCode.LeftArrow))
        if(direction == 2)
        {
            // view is already on north
            if(North.activeSelf == true)
            {
                // set everything except the next view to false
                North.gameObject.SetActive(false);
                East.gameObject.SetActive(false);
                South.gameObject.SetActive(false);
                West.gameObject.SetActive(true);
                Floor.gameObject.SetActive(false);
                Ceiling.gameObject.SetActive(false);
            }
            // view is already on east
            else if (East.activeSelf == true)
            {
                // set everything except the next view to false
                North.gameObject.SetActive(true);
                East.gameObject.SetActive(false);
                South.gameObject.SetActive(false);
                West.gameObject.SetActive(false);
                Floor.gameObject.SetActive(false);
                Ceiling.gameObject.SetActive(false);
            }
            // view is already on south
            else if (South.activeSelf == true)
            {
                // set everything except the next view to false
                North.gameObject.SetActive(false);
                East.gameObject.SetActive(true);
                South.gameObject.SetActive(false);
                West.gameObject.SetActive(false);
                Floor.gameObject.SetActive(false);
                Ceiling.gameObject.SetActive(false);
            }
            // view is already on west
            else if (West.activeSelf == true)
            {
                // set everything except the next view to false
                North.gameObject.SetActive(false);
                East.gameObject.SetActive(false);
                South.gameObject.SetActive(true);
                West.gameObject.SetActive(false);
                Floor.gameObject.SetActive(false);
                Ceiling.gameObject.SetActive(false);
            }
        }

        // if players click up arrow
        if(direction == 3)
        {
            // store the current view
            if(North.activeSelf == true)
            {
                storedView = 1;
            }
            else if (East.activeSelf == true)
            {
                storedView = 2;
            }
            else if (South.activeSelf == true)
            {
                storedView = 3;
            }
            else if (West.activeSelf == true)
            {
                storedView = 4;
            }

            // if the current view is not the floor
            if (Floor.activeSelf != true)
            {
                North.gameObject.SetActive(false);
                East.gameObject.SetActive(false);
                South.gameObject.SetActive(false);
                West.gameObject.SetActive(false);
                Floor.gameObject.SetActive(false);
                Ceiling.gameObject.SetActive(true);
            }
            // if the current view is the floor then set the view to the storedView
            else 
            {
                Floor.gameObject.SetActive(false);

                if(storedView == 1)
                {
                    North.gameObject.SetActive(true);
                }
                else if (storedView == 2)
                {
                    East.gameObject.SetActive(true);
                }
                else if (storedView == 3)
                {
                    South.gameObject.SetActive(true);
                }
                else if (storedView == 4)
                {
                    West.gameObject.SetActive(true);
                }
            }
        }

        // if players click down arrow
        if(direction == 4)
        {
            // store the current view
            if(North.activeSelf == true)
            {
                storedView = 1;
            }
            else if (East.activeSelf == true)
            {
                storedView = 2;
            }
            else if (South.activeSelf == true)
            {
                storedView = 3;
            }
            else if (West.activeSelf == true)
            {
                storedView = 4;
            }

            // if the current view is not the ceiling
            if (Ceiling.activeSelf != true)
            {
                North.gameObject.SetActive(false);
                East.gameObject.SetActive(false);
                South.gameObject.SetActive(false);
                West.gameObject.SetActive(false);
                Floor.gameObject.SetActive(true);
                Ceiling.gameObject.SetActive(false);
            }
            // if the current view is ceiling floor then set the view to the storedView
            else 
            {
                Ceiling.gameObject.SetActive(false);

                if(storedView == 1)
                {
                    North.gameObject.SetActive(true);
                }
                else if (storedView == 2)
                {
                    East.gameObject.SetActive(true);
                }
                else if (storedView == 3)
                {
                    South.gameObject.SetActive(true);
                }
                else if (storedView == 4)
                {
                    West.gameObject.SetActive(true);
                }
            }
        }
    }
}

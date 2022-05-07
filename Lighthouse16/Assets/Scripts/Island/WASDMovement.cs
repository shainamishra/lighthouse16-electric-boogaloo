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

    // Start is called before the first frame update
    void Start()
    {
        North.gameObject.SetActive(true);
        East.gameObject.SetActive(false);
        South.gameObject.SetActive(false);
        West.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            if(North.activeSelf == true)
            {
                North.gameObject.SetActive(false);
                East.gameObject.SetActive(true);
                South.gameObject.SetActive(false);
                West.gameObject.SetActive(false);
            }
            else if (East.activeSelf == true)
            {
                North.gameObject.SetActive(false);
                East.gameObject.SetActive(false);
                South.gameObject.SetActive(true);
                West.gameObject.SetActive(false);
            }
            else if (South.activeSelf == true)
            {
                North.gameObject.SetActive(false);
                East.gameObject.SetActive(false);
                South.gameObject.SetActive(false);
                West.gameObject.SetActive(true);
            }
            else if (West.activeSelf == true)
            {
                North.gameObject.SetActive(true);
                East.gameObject.SetActive(false);
                South.gameObject.SetActive(false);
                West.gameObject.SetActive(false);
            }
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            if(North.activeSelf == true)
            {
                North.gameObject.SetActive(false);
                East.gameObject.SetActive(false);
                South.gameObject.SetActive(false);
                West.gameObject.SetActive(true);
            }
            else if (East.activeSelf == true)
            {
                North.gameObject.SetActive(true);
                East.gameObject.SetActive(false);
                South.gameObject.SetActive(false);
                West.gameObject.SetActive(false);
            }
            else if (South.activeSelf == true)
            {
                North.gameObject.SetActive(false);
                East.gameObject.SetActive(true);
                South.gameObject.SetActive(false);
                West.gameObject.SetActive(false);
            }
            else if (West.activeSelf == true)
            {
                North.gameObject.SetActive(false);
                East.gameObject.SetActive(false);
                South.gameObject.SetActive(true);
                West.gameObject.SetActive(false);
            }
        }

    }
}

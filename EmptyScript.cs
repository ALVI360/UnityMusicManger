using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyScript : MonoBehaviour
{
    MusicManger mm = new MusicManger();
    void Awake()
    {
        mm = gameObject.GetComponent<MusicManger>();
    }
    void Start()
    {
        mm.PlayMusic("Menu");
    }

    void Update()
    {
        // for testing

        if (Input.GetKeyDown("space"))
        {
            mm.MuteMusic("Menu");
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            mm.UnMuteMusic("Menu");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            mm.UnMuteLayer("Menu", 0);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {

            mm.UnMuteLayer("Menu", 1);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {

            mm.MuteLayer("Menu", 3);
        }



    }


}

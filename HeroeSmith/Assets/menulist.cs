using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menulist : MonoBehaviour
{
    public List<GameObject> menus = new List<GameObject>();
    public int currentmenu = 0;

    // Start is called before the first frame update
    public void backbutton()
    {
        currentmenu = 0; 
        for (int i = 0; i < menus.Count; i++)
        {
            if (menus[i].activeSelf)
            {
                currentmenu = i;
            }
            
        }

        menus[currentmenu].SetActive(false);
        currentmenu--;
        menus[currentmenu].SetActive(true);
        Debug.Log("current menu is " + currentmenu);
    }
}

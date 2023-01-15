using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class spawner : MonoBehaviour
{

    public Canvas selector;
    public GameObject obj;
    public mouselook mover;
        

    // Start is called before the first frame update
    void Start()
    {
        //psuedo = new NewBehaviourScript();
       
    }

    // Update is called once per frame
    void Update()
    {

        

        if (Input.GetMouseButtonUp(0))
        {
            function();
        }
    }

    public void function()
    {
        Instantiate(obj, new Vector3(this.transform.position.x, this.transform.position.y , this.transform.position.z- 4), Quaternion.identity);
    }

    public void OnTriggerStay(Collider other)
    {
        if (Input.GetMouseButtonUp(1))
            {
                selector.gameObject.SetActive(true);
            
            }
    }

    public void OnTriggerExit(Collider other)
    {
                selector.gameObject.SetActive(false);

    }
}

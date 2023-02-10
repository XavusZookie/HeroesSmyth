using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class spawner : MonoBehaviour
{

    public Canvas selector;
    public Canvas mold;

    public GameObject obj;
    public mouselook mover;
    public bool inspace = false;
    public GameObject temp;
        

    // Start is called before the first frame update
    void Start()
    {
        //psuedo = new NewBehaviourScript();
       
    }

    // Update is called once per frame
    void Update()
    {

        

        if (Input.GetMouseButtonUp(0) && inspace)
        {
            //function();
        }
    }

    public void function( int moldchoice)
    {
        //temp = Instantiate(obj, new Vector3(this.transform.position.x, this.transform.position.y , this.transform.position.z- 4), Quaternion.identity);
        temp.GetComponent<sword>().chosenmold = moldchoice;
        //temp.GetComponent<sword>().choosesword();

    }

    public void createmold()
    {
        
        temp.GetComponent<sword>().choosesword();

    }

    public void startsword()
    {
        temp = Instantiate(obj, new Vector3(this.transform.position.x, this.transform.position.y+1, this.transform.position.z), Quaternion.identity);
        temp.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
        selector.gameObject.SetActive(false);
        mold.gameObject.SetActive(true);
    }



    public void OnTriggerEnter(Collider other)
    {
        selector.gameObject.SetActive(true);
        mover.mouseunlocker();
        mover.enabled = false;
        inspace = true;

    }

    public void OnTriggerStay(Collider other)
    {
       
        
            
        
            

            
            
    }

    public void OnTriggerExit(Collider other)
    {
        selector.gameObject.SetActive(false);
        mold.gameObject.SetActive(false);

        mover.enabled = true;
        
        mover.mouselocker();
        inspace = false;
        if(temp != null)
        temp.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;


    }
}

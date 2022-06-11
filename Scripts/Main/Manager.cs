using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public InputField input1;
    public InputField input2;
    public InputField input3;
    public InputField input4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            input1.enabled = false;
            input2.enabled = false;
            input3.enabled = false;
            input4.enabled = false;
        }


    }

    public void edits1()
    {

    }
    public void edits2()
    {

    }
    public void edits3()
    {

    }
    public void edits4()
    {

    }
}

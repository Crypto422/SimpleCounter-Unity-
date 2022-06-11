using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Load3 : MonoBehaviour
{
    public InputField name3;

    // Start is called before the first frame update
    void Start()
    {
        name3.text = GameManager.SlotName_3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadS3()
    {
        if (name3.enabled != true)
        {
            GameDataManager.SaveName = name3.text;
            GameManager.SlotName_3 = name3.text;
            SceneManager.LoadScene("Slot3");
        }
    }
}

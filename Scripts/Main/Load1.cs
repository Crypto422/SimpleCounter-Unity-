using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Load1 : MonoBehaviour
{
    public InputField name1;
    

    // Start is called before the first frame update
    void Start()
    {
        name1.text = GameManager.SlotName_1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadS1()
    {
        if (name1.enabled != true)
        {
            GameDataManager.SaveName = name1.text;
            GameManager.SlotName_1 = name1.text;
            SceneManager.LoadScene("Slot1");
        }
    }
}

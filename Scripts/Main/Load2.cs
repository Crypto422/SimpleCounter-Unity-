using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Load2 : MonoBehaviour
{
    public InputField name2;

    // Start is called before the first frame update
    void Start()
    {
        name2.text = GameManager.SlotName_2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadS2()
    {
        if (name2.enabled != true)
        {
            GameDataManager.SaveName = name2.text;
            GameManager.SlotName_2 = name2.text;
            SceneManager.LoadScene("Slot2");
        }
    }
}

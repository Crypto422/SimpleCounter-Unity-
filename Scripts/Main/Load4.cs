using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Load4 : MonoBehaviour
{
    public InputField name4;

    // Start is called before the first frame update
    void Start()
    {
        name4.text = GameManager.SlotName_4;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadS4()
    {
        if (name4.enabled != true)
        {
            GameDataManager.SaveName = name4.text;
            GameManager.SlotName_4 = name4.text;
            SceneManager.LoadScene("Slot4");
        }
    }
}

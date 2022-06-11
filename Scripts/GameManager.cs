using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public counter counter;
    public static string SlotName_1 = "Slot 1";
    public static string SlotName_2 = "Slot 2";
    public static string SlotName_3 = "Slot 3";
    public static string SlotName_4 = "Slot 4";

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Insert))
        {
            counter.inc();
        }
        if (Input.GetKeyUp(KeyCode.Delete))
        {
            counter.dec();
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Startup");
        }
    }
}

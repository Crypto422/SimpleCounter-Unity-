using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class counter : MonoBehaviour
{
    public Text countD;
    public Image flasher;
    public int count;
    [SerializeField]
    string extension;
    
    // Start is called before the first frame update
    void Start()
    {
        Load();
    }

   
    public void inc()
    {
        count += 1;
        countD.text = (count.ToString());
        Save();
        StartCoroutine(flashG());

    }
    public void dec()
    {
        count -= 1;
        countD.text = (count.ToString());
        Save();
        StartCoroutine(flashR());
    }
    public void res()
    {
        count = 0;
        Save();
        countD.text = (count.ToString());
    }

    void Load()
    {
        GameDataManager.Instance.ReadData(extension);
        count = GameDataManager.Instance.Count;
        countD.text = count.ToString();
    }

    void Save()
    {
        GameDataManager.Instance.Count = count;
        GameDataManager.Instance.WriteData(extension);
    }

    private IEnumerator flashG()
    {
        flasher.GetComponent<Image>().color = new Color32(25, 150, 0, 180);
        yield return new WaitForSeconds(0.3f);
        flasher.GetComponent<Image>().color = new Color32(150, 150, 150, 255);
    }

    private IEnumerator flashR()
    {
        flasher.GetComponent<Image>().color = new Color32(150, 25, 0, 180);
        yield return new WaitForSeconds(0.3f);
        flasher.GetComponent<Image>().color = new Color32(150, 150, 150, 255);
    }
}

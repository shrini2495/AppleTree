using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    public static ApplePicker instanceap;
    public GameObject basketPrefab;
    public int numBaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;
    public List<GameObject> basketList;
    

    public void Awake() => instanceap = this;

    // Start is called before the first frame update
    void Start()
    {
        basketList = new List<GameObject>();
        for(int i =0; i<numBaskets; i++)
        {
            GameObject tBasketGO = Instantiate(basketPrefab) as GameObject;
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketGO.transform.position = pos;
            basketList.Add(tBasketGO);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void AppleDestroyed()
    {
       // GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
       // foreach(GameObject tGO in tAppleArray)
       // {
         // Destroy(tGO);           
       // }
        int basketindex = basketList.Count - 1;
        GameObject tBasketGO = basketList[basketindex];
        basketList.RemoveAt(basketindex);
        Destroy(tBasketGO);
        if(basketList.Count == 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}

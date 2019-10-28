using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateItem : MonoBehaviour
{
    private string[] ItemPath = {
        "Prefab/test1",
        "Prefab/test2",
        "Prefab/test3"
    };
    private List<GameObject> ItemList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vec =new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.E))
        {
            ItemSpawn(vec, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            ItemDelete(ItemList[0]);
        }
    }

    bool ItemSpawn(Vector3 pos, int itemNo)
    {
        GameObject prefab = (GameObject)Resources.Load(ItemPath[itemNo]);

        ItemList.Add(Instantiate(prefab, pos, Quaternion.identity));

        return true;
    }

    bool ItemDelete(GameObject obj)
    {
        for(int i = 0;i < ItemList.Count;++i)
        {
            if(i.Equals(obj))
            {
                ItemList.Remove(obj);
            }
        }
        return true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabHolder : MonoBehaviour
{
    public List<GameObject> prefabs = new List<GameObject>();
    public Dictionary<string, GameObject> prefabDict = new Dictionary<string, GameObject>();

    public static PrefabHolder Instance;

    // Start is called before the first frame update
    void Start()
    {
        if (Instance == null) Instance = this;

        // Set up dictionary
        foreach(GameObject obj in prefabs)
        {
            if (obj.GetComponent<Tower>())
            {
                Tower tower = obj.GetComponent<Tower>();
                string type = tower.id;
                if (type != null) prefabDict.Add(type, obj);
            }
        }
    }

    public GameObject Retrieve(string id)
    {
        if (prefabDict.ContainsKey(id))
        {
            return prefabDict[id];
        } else {
            return null;
        }
    }
}

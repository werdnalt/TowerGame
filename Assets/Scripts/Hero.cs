using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public int numResources;
    public int level;
    public int maxDeployedTowers;

    public Tower selectedTower;
    public List<GameObject> deployedTowers;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TowerDeployed(GameObject tower)
    {
        deployedTowers.Add(tower);
    }
}

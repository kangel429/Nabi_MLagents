using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviorManager : MonoBehaviour
{
    public GameObject mPlayer;
    public List<GameObject> mUserList = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i< 0; i++)
        {
            GameObject player = Instantiate(mPlayer) as GameObject;
            player.transform.parent = this.transform;
            mUserList.Add(player);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

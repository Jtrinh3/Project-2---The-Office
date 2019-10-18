using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaleBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void shrink()
    {
        GameObject player = GameObject.Find("TrackedAlias");
        player.transform.localScale = new Vector3(.2f,.2f,.2f);
        GameObject positions = GameObject.Find("PlayAreaAlias");
        positions.transform.position += new Vector3(0f, 0f, 0f);

    }
    public void grow()
    {
        GameObject player = GameObject.Find("TrackedAlias");
        player.transform.localScale = new Vector3(20f, 20f, 20f);
        GameObject positions = GameObject.Find("PlayAreaAlias");

        positions.transform.position += new Vector3(0f,0f,0f);

    }
    public void smallToNormal()
    {
        GameObject player = GameObject.Find("TrackedAlias");
        player.transform.localScale = new Vector3(1f, 1f, 1f);
        GameObject positions = GameObject.Find("PlayAreaAlias");

        positions.transform.position += new Vector3(-13f, 0f, 5f);

    }
    public void bigToNormal()
    {
        GameObject player = GameObject.Find("TrackedAlias");
        player.transform.localScale = new Vector3(1f, 1f, 1f);
        GameObject positions = GameObject.Find("PlayAreaAlias");

        positions.transform.position += new Vector3(0f, 0f, 0f);

    }
}

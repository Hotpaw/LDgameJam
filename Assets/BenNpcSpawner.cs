using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BenNpcSpawner : MonoBehaviour
{
    
    public enum direction { RightFacing, LeftFacing };
    public direction Direction;
    // Start is called before the first frame update
    void Awake()
    {
        GameObject[] npcRightFacing;
         GameObject[] npcLeftFacing;
        npcRightFacing = FindAnyObjectByType<NpcList>().npcRightFacing;
        npcLeftFacing = FindAnyObjectByType<NpcList>().npcLeftFacing;

        if(Direction == direction.RightFacing)
        {
            int random = Random.Range(0, npcLeftFacing.Length);
           GameObject npc = Instantiate(npcRightFacing[random], gameObject.transform.position, npcRightFacing[random].transform.localRotation);
            npc.transform.SetParent(transform);
            npc.transform.position += new Vector3(+0.5f, 0);

        }
        else if(Direction == direction.LeftFacing)
        {
            int random = Random.Range(0, npcLeftFacing.Length);
          GameObject npc = Instantiate(npcLeftFacing[random], gameObject.transform.position, npcLeftFacing[random].transform.localRotation);
            npc.transform.SetParent(transform);
            npc.transform.position += new Vector3(-0.5f, 0);
        }
      
    }

  
}

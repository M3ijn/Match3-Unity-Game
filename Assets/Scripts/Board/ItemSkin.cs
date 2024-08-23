using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSkin : MonoBehaviour
{
    public SkinSO skin;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = skin.skinSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

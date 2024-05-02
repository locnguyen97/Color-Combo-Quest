using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TarGet : MonoBehaviour
{
    public string name;

    private void Start()
    {
        name = GetComponent<SpriteRenderer>().sprite.name;
        name = name.Replace('b', 'p');
    }
}

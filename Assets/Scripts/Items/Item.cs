﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public ItemSO itemPicked;


    public void Picked()
    {
        gameObject.SetActive(false);
    }
}

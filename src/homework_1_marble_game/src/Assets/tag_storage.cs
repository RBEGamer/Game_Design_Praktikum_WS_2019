﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tag_storage : MonoBehaviour
{

    public  enum TAGS
    {
        PARK_POS,
        SPAWN_POS,
        GOAL_COLLIDER,
        OUT_OF_MAP_COLLIDER,
        bonus
    }

    public static  string get_tag_name(TAGS _t) {
        return _t.ToString();
    }
}

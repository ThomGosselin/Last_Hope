using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameItem : ScriptableObject
{
    public string id;
    public string displayName;
    public Sprite icon;
    public Sprite visualObject;
    public bool pickable;
}

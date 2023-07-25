using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class MumbleChannel
{
    public string description { get; set; }
    public int id { get; set; }
    public List<object> links { get; set; }
    public string name { get; set; }
    public int parent { get; set; }
    public int position { get; set; }
    public bool temporary { get; set; }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Stage Data")]
public class StageData : ScriptableObject{
    public TextAsset mapFile;
    public TextAsset envObjects;
}

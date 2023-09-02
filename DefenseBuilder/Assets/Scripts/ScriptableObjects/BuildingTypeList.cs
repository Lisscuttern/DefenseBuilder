using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "ScriptableObject/BuildingTypeLists")]
public class BuildingTypeList : ScriptableObject
{
    public List<BuildingType> BuildingTypes;
}

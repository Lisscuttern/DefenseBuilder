using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "ScriptableObject/ResourceTypeList")]
public class ResourceTypeList : ScriptableObject
{
    public List<ResourceType> ResourceTypes;
}

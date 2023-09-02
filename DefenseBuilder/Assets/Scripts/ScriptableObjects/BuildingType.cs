using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/BuildingType")]
public class BuildingType : ScriptableObject
{
    public string Name;
    public Transform Prefab;
}

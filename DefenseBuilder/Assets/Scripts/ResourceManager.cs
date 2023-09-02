using UnityEngine;
using System.Collections.Generic;

public class ResourceManager : MonoBehaviour
{
    #region Private Fields

    private Dictionary<ResourceType, int> resourceAmountDictionary = new ();
    private ResourceTypeList resourceTypeList;

    #endregion

    /// <summary>
    /// This function called when on awake.
    /// </summary>
    private void Awake()
    { 
        resourceTypeList = Resources.Load<ResourceTypeList>(nameof(ResourceTypeList));

        foreach (ResourceType resourceType in resourceTypeList.ResourceTypes)
        {
            resourceAmountDictionary[resourceType] = 0;
        }
    }

    /// <summary>
    /// This function called when per frame.
    /// </summary>
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            resourceTypeList = Resources.Load<ResourceTypeList>(nameof(ResourceTypeList));
            AddResource(resourceTypeList.ResourceTypes[0], 2);
            Test();
        }
    }

    /// <summary>
    /// This function helps for test.
    /// </summary>
    private void Test()
    {
        foreach (ResourceType resourceType in resourceAmountDictionary.Keys)
        {
            Debug.Log(resourceType.Name + ":" + resourceAmountDictionary[resourceType]);
        }
    }

    /// <summary>
    /// This function helps for add resource.
    /// </summary>
    public void AddResource(ResourceType resourceType, int amount)
    {
        resourceAmountDictionary[resourceType] += amount;
    }
}

using System;
using UnityEngine;

public class ResourceGenerator : MonoBehaviour
{
    #region SerializeFields

    [SerializeField] private BuildingTypeHolder m_buildingTypeHolder;

    #endregion
    #region Private Fields

    private float timer;
    private float timerMax;

    #endregion

    /// <summary>
    /// This function called when on awake.
    /// </summary>
    private void Awake()
    {
        timerMax = m_buildingTypeHolder.BuildingType.ResourceGeneratorData.TimerMax;
    }

    /// <summary>
    /// This function called when per update.
    /// </summary>
    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer += timerMax;
            ResourceManager.Instance.AddResource(m_buildingTypeHolder.BuildingType.ResourceGeneratorData.ResourceType, 1);
        }
    }
}

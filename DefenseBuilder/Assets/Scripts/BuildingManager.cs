using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    #region SerializeFields

    [SerializeField] private Camera m_camera;
    [SerializeField] private BuildingTypeList m_buildingTypeList;
    [SerializeField] private BuildingType m_buildingType;

    #endregion
    #region Private Fields

    #endregion
    
    /// <summary>
    /// This function called when on awake.
    /// </summary>
    private void Awake()
    {
        m_buildingTypeList = Resources.Load<BuildingTypeList>(nameof(BuildingTypeList));
        m_buildingType = m_buildingTypeList.BuildingTypes[0];
    }

    /// <summary>
    /// This function called when per frame.
    /// </summary>
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(m_buildingType.Prefab, GetMousePosition(), Quaternion.identity);
        }
    }

    /// <summary>
    /// This function returns related mouse position.
    /// </summary>
    /// <returns></returns>
    private Vector3 GetMousePosition()
    {
        Vector3 mousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        return mousePos;
    }
}
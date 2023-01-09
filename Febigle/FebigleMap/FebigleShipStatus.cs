using UnityEngine;

namespace Febigle.FebigleMap;

public sealed class FebigleStatus : MonoBehaviour
{
    public static FebigleStatus Instance;
    public ShipStatus ShipStatus;
    public Transform FebigleMapData;

    public FebigleStatus() { }

    public void Awake()
    {
        FebigleStatus.Instance = null;
        this.ShipStatus = this.GetComponent<ShipStatus>();

        // FebigleのマップのGameObjectらを格納するもの
        this.FebigleMapData = new GameObject("FebigleMapData").transform;
        this.FebigleMapData.parent = this.transform;
        this.FebigleMapData.gameObject.SetActive(false);

        this.ShipStatus.InitialSpawnCenter = new(0f, 0f);
        this.ShipStatus.MeetingSpawnCenter = new(0f, 0f);
        this.ShipStatus.MeetingSpawnCenter2 = new(0f, 0f);
    }
}
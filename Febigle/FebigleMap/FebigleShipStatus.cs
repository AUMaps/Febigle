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
        this.FebigleMapData = new GameObject("FebigleMapData").transform;
        this.FebigleMapData.parent = this.transform;
        this.FebigleMapData.gameObject.SetActive(false);
    }
}
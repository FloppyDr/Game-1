using UnityEngine;

class GridObject : MonoBehaviour
{
    [SerializeField] private GridLayer _layer;
    [SerializeField] private int _chance;

    public GridLayer Layer => _layer;
    public int Chance => _chance;

    private void OnValidate()
    {
        _chance = Mathf.Clamp(_chance, 1, 100);
    }

    private void Update()
    {
        Vector3 destroyPoint = Camera.main.WorldToViewportPoint(gameObject.transform.position);

        if (destroyPoint.z < 0)
        {
            Destroy(gameObject);
        }
    }
}

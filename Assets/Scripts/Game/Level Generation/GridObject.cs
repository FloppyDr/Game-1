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
       Vector3 destroyPoint = Camera.main.ViewportToWorldPoint(new Vector2(0, 0.5f));

        if (transform.position.z < destroyPoint.z)
        {
            Destroy(gameObject);
        }
    }
}

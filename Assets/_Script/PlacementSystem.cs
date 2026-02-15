using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementSystem : MonoBehaviour
{
    [SerializeField] GameObject mouseIndicator, cellindicator;

    [SerializeField] private InputManger inputManger;
    [SerializeField] private Grid grid;
    private void Update()
    {
        Vector3 mousePosition = inputManger.GetSelectedMapPosition();
        Vector3Int gridPosition = grid.WorldToCell(mousePosition);
        mouseIndicator.transform.position = mousePosition;
        cellindicator.transform.position = grid.CellToWorld(gridPosition);
    }

}

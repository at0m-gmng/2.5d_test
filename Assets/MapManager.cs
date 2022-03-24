using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapManager : MonoBehaviour
{
    [SerializeField] private MapData[] mapData;
    [SerializeField] private Tilemap tileMap;

    private void Awake()
    {
        foreach(MapData mapData in mapData)
        {
            //Debug.Log(mapData);
        }
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //GridLayout gridLayout = tileMap.transform.GetComponentInParent<GridLayout>();

            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int gridPosition = tileMap.WorldToCell(mousePosition);
            Vector3 gridPosition1 = tileMap.GetCellCenterWorld(gridPosition);



            //Vector3Int cellPosition = gridLayout.WorldToCell(transform.position);
            Quaternion asd = tileMap.transform.rotation;
            //pref.setLocation(cellPosition);
            //Debug.Log(gridPosition);
            //gridPosition2 = gridMap. ;
            //var asdf = asd * mousePosition;
            Vector3Int asdfd = new Vector3Int(gridPosition.x - 36, gridPosition.y + 36, 0);


            //TileBase[] gridPosition1 = tileMap.GetTilesBlock(mousePosition) ;

            TileBase clickTale = tileMap.GetTile(asdfd);


            //print("mousePosition " + mousePosition);
            //print("gridPosition " + gridPosition);
            //print("asd " + asd);
            //print("asd " + asdfd);
            //print("gridPosition1 " + gridPosition1);

            //print("clickTale " + clickTale);
        }
    }
}

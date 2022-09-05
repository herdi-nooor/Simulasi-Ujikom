using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MatchPicture.Gamplay.tiles
{
    public class TileGrub : MonoBehaviour
    {
        [SerializeField] private int _width = 5;
        [SerializeField] private int _height = 6;
        [SerializeField] private List<GameObject> _tilesList;
        public GameObject selectedobject;
        public List<GameObject>[][] _listTileOnGame;


        void Start()
        {
            GenerateGridTile();
        }

        public void GenerateGridTile()
        {
            for (int x = 0; x < _width; x++)
            {
                for (int y = 0; y < _height; y++)
                {
                    int index = UnityEngine.Random.Range(0, _tilesList.Count);
                    if (_listTileOnGame[x][y].Count == 0)
                    {
                        var obj = Instantiate(_tilesList[index], new Vector2(x, y), Quaternion.identity);
                        obj.SetActive(true);
                        _listTileOnGame[x][y].Add(obj.gameObject);
                        obj.GetComponent<TileObject>().x = x;
                        obj.GetComponent<TileObject>().y = y;
                    }
                    for (int i = 0; i < _listTileOnGame[x][y].Count; i++)
                    {
                        if (_tilesList[index] == _listTileOnGame[x][y])
                        {
                            var obj = Instantiate(_tilesList[index], new Vector2(x, y), Quaternion.identity);
                            obj.SetActive(true);
                            _listTileOnGame[x][y].Add(obj.gameObject);
                            obj.GetComponent<TileObject>().x = x;
                            obj.GetComponent<TileObject>().y = y;
                        }
                    }
                }
            }
        }

        public void TryMatchClickedTiles(int x, int y)
        {
            if (selectedobject == null)
            {
                selectedobject;
            }
            else
            {
                if (obj == selectedobject)
                {
                    //mastch
                }
            }
        }

        void Update()
        {
        }

    }

}
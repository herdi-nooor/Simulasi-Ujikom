using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MatchPicture.Gamplay.tiles;
using System;

namespace MatchPicture.Gamplay.tiles
{
    public class TileObject : MonoBehaviour, IRaycastable
    {
        [SerializeField] private GameObject _image;
        private string _nameTile;
        [SerializeField] private TileGrub tileGrub;

        public int x { get; set; }
        public int y { get; set; }

        public bool Selected { get; set; }

        public void SetNameTile(string name)
        {
            _nameTile = name;
        }

        public string GetNameTiles()
        {
            return _nameTile;
        }

        public void ShowTile()
        {
            gameObject.SetActive(true);
        }

        public void HideTile()
        {
            gameObject.SetActive(false);
        }

        public void OnRaycasted()
        {
            Selected = true;
            Debug.Log(this.gameObject);
            tileGrub.TryMatchClickedTiles(x, y);
        }


    }

}

﻿using UnityEngine;
using UnityEngine.UI;

public class BuildingRequiredItemsHolder :MonoBehaviour {

    private Text _nameText;
    private Image _image;
    private Text _countText;
    void Awake() {
        _nameText = transform.Find("Name").GetComponent<Text>();
        _image = transform.Find("Image").GetComponent<Image>();
        _countText = transform.Find("Count").GetComponent<Text>();
    }

    public void SetItemInfo(string name, Sprite sprite, int needCount, int haveCount) {
        _nameText.text = name;
        _image.sprite = sprite;
        if (needCount > haveCount)
            _countText.text = needCount + " (<color='red'>" + haveCount + "</color>)";
        else

            _countText.text = needCount + " (<color='green'>" + haveCount + "</color>)";
    }
}

﻿using System;
using UnityEngine;

public class SpriteManager :Manager {

    private Sprite[] _sprites;
    void Awake() {
        _sprites = Resources.LoadAll<Sprite>("Sprites/");
    }

    public Sprite GetSprite(string head, string name) {
        var r = Array.Find(_sprites, x => x.name.Equals(head + "_" + name));
        if (r == null) {
            return Array.Find(_sprites, x => x.name.Equals("null"));
        }
        return r;
    }
}
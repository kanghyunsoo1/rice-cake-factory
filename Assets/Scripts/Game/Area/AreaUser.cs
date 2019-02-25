﻿using System;
using UnityEngine;

public class AreaUser :MonoBehaviour {
    private AreaManager _areaManager;

    private void Awake() {
        _areaManager = FindObjectOfType<AreaManager>();
    }
    void Start() {
        _areaManager.LockArea(gameObject);
    }

    private void OnDestroy() {
        try {
            _areaManager.UnlockArea(gameObject);
        } catch (Exception) { };
    }
}
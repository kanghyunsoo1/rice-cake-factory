﻿using System;

public class BuildingManager :Manager {
    public BuildingInfo[] buildingInfos;

    private void Awake() {
        buildingInfos = new BuildingInfo[] {
            Init("inserter","iron:10")
            ,Init("fan","iron:10")
            ,Init("miner","iron:30")
            ,Init("millstone","iron:30, copper:20")
            ,Init("furance","iron:10")
            ,Init("purifier","iron:10,copper:10")
            ,Init("generator","iron:10,copper:10")
        };
    }

    private BuildingInfo Init(string name, string needs) {
        return new BuildingInfo(name, needs);
    }

    public BuildingInfo GetBuildingInfo(string name) {
        return Array.Find(buildingInfos, x => x.name.Equals(name));
    }
}
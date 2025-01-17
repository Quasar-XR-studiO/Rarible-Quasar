﻿using easyar;
using System;
using System.Collections.Generic;

namespace ZBoom.Common.SpatialMap
{
    [Serializable]
    public class MapMeta
    {
        public SparseSpatialMapController.MapManagerSourceData Map = new SparseSpatialMapController.MapManagerSourceData();
        public List<PropInfo> Props = new List<PropInfo>();

        public MapMeta(SparseSpatialMapController.SparseSpatialMapInfo map, List<PropInfo> props)
        {
            Map = new SparseSpatialMapController.MapManagerSourceData() { Name = map.Name, ID = map.ID };
            Props = props;
        }

        [Serializable]
        public class PropInfo
        {
            public string Id = string.Empty;
            public string Name = string.Empty;
            public float[] Position = new float[3];
            public float[] Rotation = new float[4];
            public float[] Scale = new float[3];
        }
    }
}

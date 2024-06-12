using System.Collections.Generic;
namespace BlazorDemo.Data {
    public class SpaceObject {
        public int ObjectId { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public string WikiPage { get; set; }
        public string ImageData { get; set; }
        public string ImageHint { get; set; }
        public double MeanRadiusInKM { get; set; }
        public double MeanRadiusByEarth { get; set; }
        public double Volume10pow9KM3 { get; set; }
        public double VolumeRByEarth { get; set; }
        public double Mass10pow21kg { get; set; }
        public double MassByEarth { get; set; }
        public double Density { get; set; }
        public double SurfaceGravity { get; set; }
        public double SurfaceGravityByEarth { get; set; }
        public string TypeOfObject { get; set; }
        public List<SpaceObject> Satellites { get; set; }

        public SpaceObject(
            int objectId,
            int parentId,
            string name,
            string wikiPage,
            string imageData,
            string imageHint,
            double meanRadiusInKM,
            double meanRadiusByEarth,
            double volume10pow9KM3,
            double volumeRByEarth,
            double mass10pow21kg,
            double massByEarth,
            double density,
            double surfaceGravity,
            double surfaceGravityByEarth,
            string typeOfObject,
            List<SpaceObject> satellites = null
        ) {
            ObjectId = objectId;
            ParentId = parentId;
            Name = name;
            WikiPage = wikiPage;
            ImageData = imageData;
            ImageHint = imageHint;
            MeanRadiusInKM = meanRadiusInKM;
            MeanRadiusByEarth = meanRadiusByEarth;
            Volume10pow9KM3 = volume10pow9KM3;
            VolumeRByEarth = volumeRByEarth;
            Mass10pow21kg = mass10pow21kg;
            MassByEarth = massByEarth;
            Density = density;
            SurfaceGravity = surfaceGravity;
            SurfaceGravityByEarth = surfaceGravityByEarth;
            TypeOfObject = typeOfObject;
            Satellites = satellites ?? new List<SpaceObject>();
        }
    }
}

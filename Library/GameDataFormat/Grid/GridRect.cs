using System;

namespace BiangLibrary.GameDataFormat.Grid
{
    [Serializable]
    public struct GridRect
    {
        public GridPos position;
        public GridPos size;

        public GridPos center => new GridPos(position.x + size.x / 2, position.z + size.z / 2);

        public int x_min => position.x;
        public int x_max => position.x + size.x - 1;
        public int z_min => position.z;
        public int z_max => position.z + size.z - 1;

        public GridRect(int x, int z, int width, int height)
        {
            position.x = x;
            position.z = z;
            size.x = width;
            size.z = height;
        }

        public bool Contains(GridPos gp)
        {
            if (gp.x > x_max || gp.x < x_min || gp.z > z_max || gp.z < z_min) return false;
            return true;
        }

        public bool Contains(GridPos3D gp)
        {
            if (gp.x > x_max || gp.x < x_min || gp.z > z_max || gp.z < z_min) return false;
            return true;
        }

        public bool Contains(GridPosR gp)
        {
            if (gp.x > x_max || gp.x < x_min || gp.z > z_max || gp.z < z_min) return false;
            return true;
        }
    }
}
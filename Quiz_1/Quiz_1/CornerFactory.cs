using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Quiz_1
{
    public class CornerFactory
    {
        public Corner GetCorner(int option)
        {
            Corner corner = null;

            corner = option switch
            {
                1 => GetOrnamentsCorner(),
                2 => GetClothingCorner(),
                3 => GetElectronicsCorner(),
                _ => null
            };

            return corner;
        }

        public OrnamentsCorner GetOrnamentsCorner()
        {
            return new OrnamentsCorner();
        }

        public ClothingCorner GetClothingCorner()
        {
            return new ClothingCorner();
        }

        public ElectronicsCorner GetElectronicsCorner()
        {
            return new ElectronicsCorner();
        }
    }
}

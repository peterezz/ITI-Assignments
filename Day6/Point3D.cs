using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public class Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        private Point3D(int x,int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z= z;
        }
        public Point3D(int AllCoordinates) : this(AllCoordinates, AllCoordinates, AllCoordinates)
        {
                
        }
        public string Show()
        {
            return $"x= {X},y= {Y}, z= {Z}";
        }
        /// <summary>
        /// Excplict casting
        /// </summary>
        /// <returns></returns>
        public static explicit operator string(Point3D point) => point.Show();
        public static bool operator ==(Point3D point1, Point3D point2) => 
            (point1.X == point2.X && point1.Y == point2.Y && point1.Z == point2.Z);
        public static bool operator !=(Point3D point1, Point3D point2) =>
    (point1.X != point2.X && point1.Y != point2.Y && point1.Z != point2.Z);







    }
}

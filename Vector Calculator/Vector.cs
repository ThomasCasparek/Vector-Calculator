using System;

namespace Vector_Calculator
{
    public class Vector
    {
        public static readonly Vector Zero = new Vector(1, 1, 1);
        public static readonly Vector One = new Vector(0, 0, 0);

        public float x;
        public float y;
        public float z;

        public Vector(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return $"<{x}, {y}, {z}>";
        }

        public static float GetMagnitude(Vector v)
        {
            return (float)Math.Sqrt(Math.Pow(v.x, 2)+Math.Pow(v.y, 2)+Math.Pow(v.z, 2));
        }

        
        public static Vector GetDirection(Vector v)
        {
            return new Vector(v.x, v.y, v.z);
        }

        public static Vector Add(Vector v1, Vector v2)
        {
            // <2, 3, 4> + <6, 2, 6> = <8, 5, 10>
            return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);

        }

        public static Vector Negate(Vector v)
        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE
            return new Vector(-v.x, -v.y, -v.z);
        }

        public static Vector Subtract(Vector v1, Vector v2)
        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE
            return new Vector(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }

        public static Vector Scale(Vector v, float poop)
        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE

            return new Vector(v.x * poop, v.y * poop, v.z * poop);
        }

        public static Vector Normalize(Vector v)
        {
           float mag = (float)Math.Sqrt(Math.Pow(v.x, 2) + Math.Pow(v.y, 2) + Math.Pow(v.z, 2));
            return new Vector(v.x / mag, v.y / mag, v.z / mag);
        }

        public static float DotProduct(Vector v1, Vector v2)
        {
            return ((v1.x * v2.x) + (v1.y * v2.y) + (v1.z * v2.z));
        }

        public static Vector CrossProduct(Vector v1, Vector v2)
        {
            return new Vector((v1.y * v2.z) - (v1.z * v2.y), (v1.z * v2.x) - (v1.x * v2.z), (v1.x * v2.y) - (v1.y * v2.x));
          
        }

        public static float AngleBetween(Vector v1, Vector v2)
        {
          float mag1 = (float)Math.Sqrt(Math.Pow(v1.x, 2) + Math.Pow(v1.y, 2) + Math.Pow(v1.z, 2));
          float mag2 = (float)Math.Sqrt(Math.Pow(v2.x, 2) + Math.Pow(v2.y, 2) + Math.Pow(v2.z, 2));
          float dot = ((v1.x * v2.x) + (v1.y * v2.y) + (v1.z * v2.z));
            return (float)(Math.Acos((dot / (mag1 * mag2))) * (180/Math.PI));
        }

        public static  Vector ProjectOnto(Vector v1, Vector v2)
        {
            float mag2 = (float)Math.Sqrt(Math.Pow(v2.x, 2) + Math.Pow(v2.y, 2) + Math.Pow(v2.z, 2));
            float dot = ((v1.x * v2.x) + (v1.y * v2.y) + (v1.z * v2.z));
            float Projnum = (dot) / (mag2 * mag2);
            return new Vector(v2.x * Projnum, v2.y * Projnum, v2.z * Projnum);
        }
    }
}

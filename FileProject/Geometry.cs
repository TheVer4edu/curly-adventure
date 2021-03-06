namespace FileProject {
    public class Geometry {

        public static bool existsTriangle(int a, int b, int c) {
            int count = 0;
            if (a + b > c)
                count++;
            if (a + c > b)
                count++;
            if (b + c > a)
                count++;
            return count == 3;
        }
        
    }
}
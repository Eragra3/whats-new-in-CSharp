namespace _72RefEnhancements
{
    class RefStruct
    {
        //Point3dOn_Stack point3DOn_Stack;
        //Point3dOn_ReadOnlyStack point3DOn_ReadOnlyStack;

        public static void Run()
        {
            Point3dOn_Stack point3DOn_Stack;
            Point3dOn_ReadOnlyStack point3DOn_ReadOnlyStack;

            //var a = new Point3dOn_ReadOnlyStack[10];
        }
    }

    ref struct Point3dOn_Stack
    {
        public readonly double X;
        public readonly double Y;
        public readonly double Z;

        public Point3dOn_Stack(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }

    readonly ref struct Point3dOn_ReadOnlyStack
    {
        public readonly double X;
        public readonly double Y;
        public readonly double Z;

        public Point3dOn_ReadOnlyStack(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}

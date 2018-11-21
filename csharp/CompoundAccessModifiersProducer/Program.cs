namespace CompoundAccessModifiersProducer
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var baseClass = new ProtectedInternal.BaseClass();
                var derivedClass = new ProtectedInternal.DerivedClass();

                baseClass.ProtectedInternal();
                derivedClass.ProtectedInternal();
            }
            
            {
                var baseClass = new PrivateProtected.BaseClass();
                var derivedClass = new PrivateProtected.DerivedClass();

                //baseClass.ProtectedInternal();
                //derivedClass.ProtectedInternal();
            }
        }

    }
}

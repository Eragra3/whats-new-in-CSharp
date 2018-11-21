using System;

namespace CompoundAccessModifiersConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var baseClass = new CompoundAccessModifiersProducer.ProtectedInternal.BaseClass();
                var derivedClass = new CompoundAccessModifiersProducer.ProtectedInternal.DerivedClass();
                
                //baseClass.ProtectedInternal();
                //derivedClass.ProtectedInternal();
            }

            {
                var baseClass = new CompoundAccessModifiersProducer.PrivateProtected.BaseClass();
                var derivedClass = new CompoundAccessModifiersProducer.PrivateProtected.DerivedClass();

                //baseClass.ProtectedInternal();
                //derivedClass.ProtectedInternal();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CompoundAccessModifiersProducer.ProtectedInternal
{
    public class DerivedClass : BaseClass
    {
        public void Run()
        {
            base.ProtectedInternal();
        }
    }
}

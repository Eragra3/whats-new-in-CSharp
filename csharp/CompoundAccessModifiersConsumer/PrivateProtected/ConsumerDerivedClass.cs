using System;
using System.Collections.Generic;
using System.Text;

namespace CompoundAccessModifiersConsumer.PrivateProtected
{
    class ConsumerDerivedClass: CompoundAccessModifiersProducer.PrivateProtected.BaseClass
    {
        public void Run()
        {
            //base.ProtectedInternal();
        }
    }
}

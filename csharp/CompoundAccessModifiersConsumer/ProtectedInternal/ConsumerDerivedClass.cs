using System;
using System.Collections.Generic;
using System.Text;

namespace CompoundAccessModifiersConsumer.ProtectedInternal
{
    class ConsumerDerivedClass: CompoundAccessModifiersProducer.ProtectedInternal.BaseClass
    {
        public void Run()
        {
            base.ProtectedInternal();
        }
    }
}

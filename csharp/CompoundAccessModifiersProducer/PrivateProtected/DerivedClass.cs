namespace CompoundAccessModifiersProducer.PrivateProtected
{
    public class DerivedClass : BaseClass
    {
        public void Run()
        {
            base.ProtectedInternal();
        }
    }
}

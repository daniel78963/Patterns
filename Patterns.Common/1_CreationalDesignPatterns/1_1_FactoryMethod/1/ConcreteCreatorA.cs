namespace Patterns.Common._1_CreationalDesignPatterns._1_1_FactoryMethod._1
{
    /// <summary> 
    /// A 'ConcreteCreator' class 
    /// </summary> 
    class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }
}

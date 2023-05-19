namespace app;

public static class FruitFactory
{
    public static Fruit CreateFruit(FruitTypes fruitType)
    {
        switch (fruitType)
        {
            case FruitTypes.Apple: return new Apple();
            case FruitTypes.Banana: return new Banana();
            case FruitTypes.Orange: return new Orange();
            default: throw new NotImplementedException("Invalid fruit type");
        }
    }
}

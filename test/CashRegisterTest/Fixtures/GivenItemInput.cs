namespace CashRegisterTest.Fixtures
{
    public class GivenItemInput
    {
        public static string SingularItemInput => "ITEM00001";

        public static string PluralItemInput => "ITEM00003-2";

        public static string[] InputList => new[]
        {
            "ITEM00001",
            "ITEM00001",
            "ITEM00001",
            "ITEM00001",
            "ITEM00001",
            "ITEM00003-2",
            "ITEM00005",
            "ITEM00005",
            "ITEM00005"
        };
    }
}
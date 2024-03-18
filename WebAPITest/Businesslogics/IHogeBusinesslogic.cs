namespace WebAPITest.Base
{
    public interface IHogeBusinesslogic<A, R>
    {
        R GetHoge(A input);
    }
}
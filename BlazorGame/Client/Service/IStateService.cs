namespace BlazorGame.Client.Service
{
    public interface IStateService
    {
       int TotalCoin { get; set; }

      event Action OnChange; 

      void  UseCoin();

      void  RefoundCoin();
    }
}

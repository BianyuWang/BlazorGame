namespace BlazorGame.Client.Service
{
    public interface IStateService
    {
       int TotalCoin { get; set; }

      event Action OnChange; 

      void  UseCoin(int cost);

      void  RefoundCoin(int refound);
    }
}

namespace BlazorGame.Client.Service
{
    public interface IStateService
    {
        public int TotalCoin { get; set; }

        public event OnChange { get; set; }
    }
}

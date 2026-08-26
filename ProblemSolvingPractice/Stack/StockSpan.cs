namespace ProblemSolvingPractice.Stack
{
    public class StockSpan
    {
        public Stack<int> GetStockSpan(List<int> stocks)
        {
            Stack<int> stockSpan = new Stack<int>();
            Stack<(int Stock, int Span)> trackStocks = new Stack<(int Stock, int Span)>();

            foreach (var stock in stocks)
            {
                int count = 1;

                while (trackStocks.Count > 0)
                {
                    if (stock > trackStocks.Peek().Stock)
                    {
                        var previous = trackStocks.Pop();
                        count += previous.Span;
                        
                    }
                    else
                        break;
                }
                trackStocks.Push((stock, count));
                stockSpan.Push(count);
            }
            return stockSpan;
        }
    }
}

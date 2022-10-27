
    public class Transaction
    {
        //we need a private backing field to represent the dependency
        private readonly ICurrency _currency;

        //This is where the DI happens
        public Transaction(ICurrency currency)
        {
            _currency=currency;

            //we want to know when the transaction happened
            DateOfTransaction = DateTimeOffset.Now;
        }

        public DateTimeOffset DateOfTransaction { get; set; } 


        public decimal GetTransactionAmount()
        {
            return _currency.Value;
        }

        public string GetTransactionType()=> _currency.Name;

        // public string GetTransactionType()
        // {
        //     return _currency.Name;
        // }
    }

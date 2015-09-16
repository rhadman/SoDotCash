using System.Collections.Generic;

namespace OFX.Types
{
    public interface ITransactionsProvider
    {
        List<Transaction> GetTransactionsForAccount(UserAccount account);

    }
}
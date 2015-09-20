using System.Collections.Generic;
using OFX.Types;

namespace OFX.Interface
{
    public interface ITransactionsProvider
    {
        List<Transaction> GetTransactionsForAccount(UserAccount account);

    }
}
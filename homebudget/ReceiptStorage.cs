using System;
using System.Threading.Tasks;

namespace homebudget
{
    public interface IReceiptStorage {
        Task UpsertReceipt(ReceiptModel r);
    }

    public class ReceiptStorage : IReceiptStorage
    {
        public Task UpsertReceipt(ReceiptModel r){
            return Task.CompletedTask;
        }
    }
}

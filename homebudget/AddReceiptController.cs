using System;
namespace homebudget
{
    public interface IAddReceiptController {

    }

    public class AddReceiptController : IAddReceiptController
    {
        readonly IReceiptStorage receiptStorage;
        public AddReceiptController(IReceiptStorage receiptStorage)
        {
            this.receiptStorage = receiptStorage;
        }
    }
}

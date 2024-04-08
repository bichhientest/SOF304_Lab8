using Moq;
using SOF304_Lab8._1;

namespace SOF304_Lab8._1Tests
{
    public class Tests
    {
        

        [Test]
        public void Test1()
        {
                var mockHsmModule = new Mock<BankAccount.IHSMModule>();
                mockHsmModule.Setup(x => x.ValidatePin(It.IsAny<string>(), It.IsAny<int>())).Returns(true);
                var atmCashWithdrawal = new BankAccount.ATMCashWithdrawal(mockHsmModule.Object, Mock.Of<BankAccount.IHostBank>());
                var result = atmCashWithdrawal.WithdrawAmount("200", 300, 12);
                Assert.False(result);
            
        }
        
    }
}
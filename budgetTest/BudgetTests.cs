using Budget;

namespace budgetTest;
[TestClass]
    public class BudgetTests
    {
        [TestMethod]
        public void SubtractFromAccount()
        {
        CurrentAccount instance = CurrentAccount.Instance;
        instance.amount = 1000;
        instance.SubtractAmount(100);

        int balance = instance.amount;
        Assert.AreEqual(900, balance);
        }

        [TestMethod]
        public void AddToAccount()
        {
            CurrentAccount instance = CurrentAccount.Instance;
            instance.amount = 1000;
            instance.AddAmount(100);

            int balance = instance.amount;
            Assert.AreEqual(1100, balance);
        }
}
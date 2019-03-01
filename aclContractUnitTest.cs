using Meadow.Contract;
using Meadow.Core.EthTypes;
using Meadow.JsonRpc.Types;
using Meadow.UnitTestTemplate;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace solidity_vscode_unit_test
{

    [TestClass]
    public class testContractTests : ContractTest
    {
        patientContract _contract;

        [AssemblyCleanup]
        public static async Task Cleanup()
        {
            await Global.GenerateCoverageReport();
        }

        protected override async Task BeforeEach()
        {
            _contract = await patientContract.New(RpcClient);
        }

        [TestMethod]
        public async Task AddUserTransaction()
        {
            var userAccount = Accounts[0];

            var addUser_txHash = await _contract.addUser(userAccount).SendTransaction();
            var userCount_call = await _contract.getUserCount().Call();
            var getUserByIndex_call = await _contract.getUserByIndex(0).Call();
            var result = await _contract.isUser(userAccount,"Check for user method").Call();

            var createPatient_txHash = await _contract.createPatient(21,"Foo Bar",98,980510).SendTransaction();
            var getPatientById_call = await _contract.getPatientById(21).Call();   

            Assert.AreEqual(true, result);
        }

  
    }   
}
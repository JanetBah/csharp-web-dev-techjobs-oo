using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Security.Cryptography.X509Certificates;
using TechJobsOO;

namespace JobTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();

            Assert.AreNotEqual(job1.Id, job2.Id);
            Assert.IsTrue(job2.Id == job1.Id + 1);
        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreEqual(job1.EmployerName.Value, "ACME");
            Assert.AreEqual(job1.EmployerLocation.Value, "Desert");
            Assert.AreEqual(job1.JobType.Value, "Quality control");
            Assert.AreEqual(job1.JobCoreCompetency.value, "Persistence");
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new Job();
            Job job2 = new Job();

            Assert.AreNotEqual(job1.Id, job2.Id);
        }


    }

}
   
    
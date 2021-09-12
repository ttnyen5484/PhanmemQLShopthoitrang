using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThuVien;

namespace ShopThoiTrang_UnitTest
{
    [TestClass]
    public class Test_Email
    {
        [TestMethod]
        public void TestEmail1()
        {
            NhapEmail email = new NhapEmail();
            bool Result_Actual = email.kiemTraEmail("nguyensythanh12123@gmail.com");
            bool Result_Except = true;
            Assert.AreEqual(Result_Except, Result_Actual);
        }
        [TestMethod]
        public void TestEmail2()
        {
            NhapEmail email = new NhapEmail();
            bool Result_Actual = email.kiemTraEmail("tnyen_5484@gmail.com");
            bool Result_Except = true;
            Assert.AreEqual(Result_Except, Result_Actual);
        }
        [TestMethod]
        public void TestEmail3()
        {
            NhapEmail email = new NhapEmail();
            bool Result_Actual = email.kiemTraEmail("sythanhnguyen@gmail.com");
            bool Result_Except = true;
            Assert.AreEqual(Result_Except, Result_Actual);
        }
        [TestMethod]
        public void TestEmail4()
        {
            NhapEmail email = new NhapEmail();
            bool Result_Actual = email.kiemTraEmail("tnyen_5484@gmailcom");
            bool Result_Except = false;
            Assert.AreEqual(Result_Except, Result_Actual);
        }
        [TestMethod]
        public void TestEmail5()
        {
            NhapEmail email = new NhapEmail();
            bool Result_Actual = email.kiemTraEmail("tnyen@gmail.com");
            bool Result_Except = false;
            Assert.AreEqual(Result_Except, Result_Actual);
        }
        [TestMethod]
        public void TestEmail6()
        {
            NhapEmail email = new NhapEmail();
            bool Result_Actual = email.kiemTraEmail("tnyen240220@gmail.");
            bool Result_Except = false;
            Assert.AreEqual(Result_Except, Result_Actual);
        }
        [TestMethod]
        public void TestEmail7()
        {
            NhapEmail email = new NhapEmail();
            bool Result_Actual = email.kiemTraEmail("tnyen240220@.com");
            bool Result_Except = false;
            Assert.AreEqual(Result_Except, Result_Actual);
        }
        [TestMethod]
        public void TestEmail8()
        {
            NhapEmail email = new NhapEmail();
            bool Result_Actual = email.kiemTraEmail("tnyen240220gmail.com");
            bool Result_Except = false;
            Assert.AreEqual(Result_Except, Result_Actual);
        }
    }
}

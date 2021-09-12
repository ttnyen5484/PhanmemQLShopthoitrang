using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThuVien;

namespace ShopThoiTrang_UnitTest
{
    [TestClass]
    public class Test_SDT
    {
        [TestMethod]
        public void TestSDT1()
        {
            NhapSoDienThoai sdt = new NhapSoDienThoai();
            bool Result_Actual = sdt.kiemTraSDT("0976097830");
            bool Result_Except = true;
            Assert.AreEqual(Result_Except, Result_Actual);
        }

        [TestMethod]
        public void TestSDT2()
        {
            NhapSoDienThoai sdt = new NhapSoDienThoai();
            bool Result_Actual = sdt.kiemTraSDT("0906395484");
            bool Result_Except = true;
            Assert.AreEqual(Result_Except, Result_Actual);
        }
        [TestMethod]
        public void TestSDT3()
        {
            NhapSoDienThoai sdt = new NhapSoDienThoai();
            bool Result_Actual = sdt.kiemTraSDT("0334602603");
            bool Result_Except = true;
            Assert.AreEqual(Result_Except, Result_Actual);
        }
        [TestMethod]
        public void TestSDT4()
        {
            NhapSoDienThoai sdt = new NhapSoDienThoai();
            bool Result_Actual = sdt.kiemTraSDT("0968735104");
            bool Result_Except = true;
            Assert.AreEqual(Result_Except, Result_Actual);
        }
        [TestMethod]
        public void TestSDT5()
        {
            NhapSoDienThoai sdt = new NhapSoDienThoai();
            bool Result_Actual = sdt.kiemTraSDT("01634602603");
            bool Result_Except = false;
            Assert.AreEqual(Result_Except, Result_Actual);
        }
    }
}

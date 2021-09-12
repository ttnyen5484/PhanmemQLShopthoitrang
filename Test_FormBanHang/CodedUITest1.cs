using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace Test_FormBanHang
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
        }

        [TestMethod]
        public void TC_MuaThanhCong()
        {
            string masp = "SPNA05";
            int sl = 2;
            int tiendua = 1000000;
            string tb = "Thêm thành công.";

            this.UIMap.RecordedMethod_BanHangParams.UIItemEditText = masp;
            this.UIMap.RecordedMethod_BanHangParams.UIItemEditText1 = sl.ToString();
            this.UIMap.RecordedMethod_BanHangParams.UIItemEditText2 = tiendua.ToString();
            this.UIMap.AssertMethod_ThanhCongExpectedValues.UIThêmthànhcôngTextName = tb;
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.RecordedMethod_BanHang();
            this.UIMap.AssertMethod_ThanhCong();
        }
        [TestMethod]
        public void TC_NullMaSP()
        {
            string masp = "";
            string sl = "";
            string tb = "Mời bạn nhập dữ liệu.";

            this.UIMap.RecordedMethod_NullTTParams.UIItemEditText = masp;
            this.UIMap.RecordedMethod_NullTTParams.UIItemEditText1 = sl.ToString();
            this.UIMap.AssertMethod_NullTTExpectedValues.UIMờibạnnhậpdữliệuTextName = tb;
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.RecordedMethod_NullTT();
            this.UIMap.AssertMethod_NullTT();

        }

        [TestMethod]
        public void TC_NullSL()
        {
            string masp = "SPNA05";
            string sl = "";
            string tb = "Mời bạn nhập dữ liệu.";

            this.UIMap.RecordedMethod_NullTTParams.UIItemEditText = masp;
            this.UIMap.RecordedMethod_NullTTParams.UIItemEditText1 = sl;
            this.UIMap.AssertMethod_NullTTExpectedValues.UIMờibạnnhậpdữliệuTextName = tb;
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.RecordedMethod_NullTT();
            this.UIMap.AssertMethod_NullTT();
        }

        [TestMethod]
        public void TC_NullTienDua()
        {
            string masp = "SPNA05";

            string sl = "2";
            string tiendua = "";
            string tb = "Bạn chưa nhập số tiền khách hàng đưa.";

            this.UIMap.RecordedMethod_BanHangParams.UIItemEditText = masp;
            this.UIMap.RecordedMethod_BanHangParams.UIItemEditText1 = sl;
            this.UIMap.RecordedMethod_BanHangParams.UIItemEditText2 = tiendua;
            this.UIMap.AssertMethod_NullTienDuaExpectedValues.UIBạnchưanhậpsốtiềnkháTextName = tb;
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.RecordedMethod_BanHang();
            this.UIMap.AssertMethod_NullTienDua();
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if (this.map == null)
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}

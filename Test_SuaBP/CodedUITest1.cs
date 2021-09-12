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


namespace Test_SuaBP
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
        public void CodedUITestMethod1()
        {
            string tenbp = "Nhân Viên Giao Hàng";
            string tb = "Sửa thành công.";

            this.UIMap.RecordedMethod_SuaBPParams.UITxtTenBPEditText = tenbp;
            this.UIMap.AssertMethod1_SuaTCExpectedValues.UISửathànhcôngTextName = tb;

            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.RecordedMethod_SuaBP();
            this.UIMap.AssertMethod1_SuaTC();
        }

        [TestMethod]
        public void TC_NullTenBP()
        {
            string tenbp = "";
            string tb = "Hãy điền dữ liệu đầy đủ";

            this.UIMap.RecordedMethod_SuaBPParams.UITxtTenBPEditText = tenbp;
            this.UIMap.AssertMethod_NullTenBPExpectedValues.UIHãyđiềndữliệuđầyđủTextName = tb;

            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.RecordedMethod_SuaBP();
            this.UIMap.AssertMethod_NullTenBP();
        }

        [TestMethod]
        public void TC_TenBPTonTai()
        {
            string tenbp = "Nhân Viên Quản Lý";
            string tb = "Tên bộ phận đã tồn tại.";

            this.UIMap.RecordedMethod_SuaBPParams.UITxtTenBPEditText = tenbp;
            this.UIMap.AssertMethod_TenBPDaTonTaiExpectedValues.UITênbộphậnđãtồntạiTextName = tb;

            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            this.UIMap.RecordedMethod_SuaBP();
            this.UIMap.AssertMethod_TenBPDaTonTai();
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

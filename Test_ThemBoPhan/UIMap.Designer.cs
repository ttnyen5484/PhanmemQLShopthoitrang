﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 15.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace Test_ThemBoPhan
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// Test_FormBoPhan - Use 'Test_FormBoPhanParams' to pass parameters into this method.
        /// </summary>
        public void Test_FormBoPhan()
        {
            #region Variable Declarations
            WinButton uIADDButton = this.UIHomeWindow.UIADDWindow.UIADDButton;
            WinEdit uITxtMaBPEdit = this.UIHomeWindow.UITxtMaBPWindow.UITxtMaBPEdit;
            WinEdit uITxtTenBPEdit = this.UIHomeWindow.UITxtTenBPWindow.UITxtTenBPEdit;
            WinButton uISAVEButton = this.UIHomeWindow.UISAVEWindow.UISAVEButton;
            #endregion

            // Click 'ADD' button
            Mouse.Click(uIADDButton, new Point(69, 53));

            // Type 'BP04' in 'txtMaBP' text box
            uITxtMaBPEdit.Text = this.Test_FormBoPhanParams.UITxtMaBPEditText;

            // Type '{Tab}' in 'txtMaBP' text box
            Keyboard.SendKeys(uITxtMaBPEdit, this.Test_FormBoPhanParams.UITxtMaBPEditSendKeys, ModifierKeys.None);

            // Type 'Nhân Viên Giao Hàng' in 'txtTenBP' text box
            uITxtTenBPEdit.Text = this.Test_FormBoPhanParams.UITxtTenBPEditText;

            // Click 'SAVE' button
            Mouse.Click(uISAVEButton, new Point(125, 78));
        }
        
        /// <summary>
        /// Assert_ThemThanhCong - Use 'Assert_ThemThanhCongExpectedValues' to pass parameters into this method.
        /// </summary>
        public void Assert_ThemThanhCong()
        {
            #region Variable Declarations
            WinText uIThêmthànhcôngText = this.UIMessageBoxThanhCongWindow.UIThêmthànhcôngWindow.UIThêmthànhcôngText;
            #endregion

            // Verify that the 'Name' property of 'Thêm thành công.' label equals 'Thêm thành công.'
            Assert.AreEqual(this.Assert_ThemThanhCongExpectedValues.UIThêmthànhcôngTextName, uIThêmthànhcôngText.Name);
        }
        
        /// <summary>
        /// Assert_NullTT - Use 'Assert_NullTTExpectedValues' to pass parameters into this method.
        /// </summary>
        public void Assert_NullTT()
        {
            #region Variable Declarations
            WinText uIHãyđiềndữliệuđầyđủText = this.UIMessageBoxCustomWindow.UIHãyđiềndữliệuđầyđủWindow.UIHãyđiềndữliệuđầyđủText;
            #endregion

            // Verify that the 'Name' property of 'Hãy điền dữ liệu đầy đủ' label equals 'Hãy điền dữ liệu đầy đủ'
            Assert.AreEqual(this.Assert_NullTTExpectedValues.UIHãyđiềndữliệuđầyđủTextName, uIHãyđiềndữliệuđầyđủText.Name);
        }
        
        /// <summary>
        /// Assert_MaBPDaCo - Use 'Assert_MaBPDaCoExpectedValues' to pass parameters into this method.
        /// </summary>
        public void Assert_MaBPDaCo()
        {
            #region Variable Declarations
            WinText uIMãbộphậnđãtồntạiText = this.UIMessageBoxCustomWindow.UIHãyđiềndữliệuđầyđủWindow.UIMãbộphậnđãtồntạiText;
            #endregion

            // Verify that the 'Name' property of 'Mã bộ phận đã tồn tại.' label equals 'Mã bộ phận đã tồn tại.'
            Assert.AreEqual(this.Assert_MaBPDaCoExpectedValues.UIMãbộphậnđãtồntạiTextName, uIMãbộphậnđãtồntạiText.Name);
        }
        
        /// <summary>
        /// Assert_TenBPDaCo - Use 'Assert_TenBPDaCoExpectedValues' to pass parameters into this method.
        /// </summary>
        public void Assert_TenBPDaCo()
        {
            #region Variable Declarations
            WinText uITênbộphậnđãtồntạiText = this.UIMessageBoxCustomWindow.UIHãyđiềndữliệuđầyđủWindow.UITênbộphậnđãtồntạiText;
            #endregion

            // Verify that the 'Name' property of 'Tên bộ phận đã tồn tại.' label equals 'Tên bộ phận đã tồn tại.'
            Assert.AreEqual(this.Assert_TenBPDaCoExpectedValues.UITênbộphậnđãtồntạiTextName, uITênbộphậnđãtồntạiText.Name);
        }
        
        #region Properties
        public virtual Test_FormBoPhanParams Test_FormBoPhanParams
        {
            get
            {
                if ((this.mTest_FormBoPhanParams == null))
                {
                    this.mTest_FormBoPhanParams = new Test_FormBoPhanParams();
                }
                return this.mTest_FormBoPhanParams;
            }
        }
        
        public virtual Assert_ThemThanhCongExpectedValues Assert_ThemThanhCongExpectedValues
        {
            get
            {
                if ((this.mAssert_ThemThanhCongExpectedValues == null))
                {
                    this.mAssert_ThemThanhCongExpectedValues = new Assert_ThemThanhCongExpectedValues();
                }
                return this.mAssert_ThemThanhCongExpectedValues;
            }
        }
        
        public virtual Assert_NullTTExpectedValues Assert_NullTTExpectedValues
        {
            get
            {
                if ((this.mAssert_NullTTExpectedValues == null))
                {
                    this.mAssert_NullTTExpectedValues = new Assert_NullTTExpectedValues();
                }
                return this.mAssert_NullTTExpectedValues;
            }
        }
        
        public virtual Assert_MaBPDaCoExpectedValues Assert_MaBPDaCoExpectedValues
        {
            get
            {
                if ((this.mAssert_MaBPDaCoExpectedValues == null))
                {
                    this.mAssert_MaBPDaCoExpectedValues = new Assert_MaBPDaCoExpectedValues();
                }
                return this.mAssert_MaBPDaCoExpectedValues;
            }
        }
        
        public virtual Assert_TenBPDaCoExpectedValues Assert_TenBPDaCoExpectedValues
        {
            get
            {
                if ((this.mAssert_TenBPDaCoExpectedValues == null))
                {
                    this.mAssert_TenBPDaCoExpectedValues = new Assert_TenBPDaCoExpectedValues();
                }
                return this.mAssert_TenBPDaCoExpectedValues;
            }
        }
        
        public UIHomeWindow UIHomeWindow
        {
            get
            {
                if ((this.mUIHomeWindow == null))
                {
                    this.mUIHomeWindow = new UIHomeWindow();
                }
                return this.mUIHomeWindow;
            }
        }
        
        public UIMessageBoxThanhCongWindow UIMessageBoxThanhCongWindow
        {
            get
            {
                if ((this.mUIMessageBoxThanhCongWindow == null))
                {
                    this.mUIMessageBoxThanhCongWindow = new UIMessageBoxThanhCongWindow();
                }
                return this.mUIMessageBoxThanhCongWindow;
            }
        }
        
        public UIMessageBoxCustomWindow UIMessageBoxCustomWindow
        {
            get
            {
                if ((this.mUIMessageBoxCustomWindow == null))
                {
                    this.mUIMessageBoxCustomWindow = new UIMessageBoxCustomWindow();
                }
                return this.mUIMessageBoxCustomWindow;
            }
        }
        #endregion
        
        #region Fields
        private Test_FormBoPhanParams mTest_FormBoPhanParams;
        
        private Assert_ThemThanhCongExpectedValues mAssert_ThemThanhCongExpectedValues;
        
        private Assert_NullTTExpectedValues mAssert_NullTTExpectedValues;
        
        private Assert_MaBPDaCoExpectedValues mAssert_MaBPDaCoExpectedValues;
        
        private Assert_TenBPDaCoExpectedValues mAssert_TenBPDaCoExpectedValues;
        
        private UIHomeWindow mUIHomeWindow;
        
        private UIMessageBoxThanhCongWindow mUIMessageBoxThanhCongWindow;
        
        private UIMessageBoxCustomWindow mUIMessageBoxCustomWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'Test_FormBoPhan'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class Test_FormBoPhanParams
    {
        
        #region Fields
        /// <summary>
        /// Type 'BP04' in 'txtMaBP' text box
        /// </summary>
        public string UITxtMaBPEditText = "BP04";
        
        /// <summary>
        /// Type '{Tab}' in 'txtMaBP' text box
        /// </summary>
        public string UITxtMaBPEditSendKeys = "{Tab}";
        
        /// <summary>
        /// Type 'Nhân Viên Giao Hàng' in 'txtTenBP' text box
        /// </summary>
        public string UITxtTenBPEditText = "Nhân Viên Giao Hàng";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'Assert_ThemThanhCong'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class Assert_ThemThanhCongExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'Name' property of 'Thêm thành công.' label equals 'Thêm thành công.'
        /// </summary>
        public string UIThêmthànhcôngTextName = "Thêm thành công.";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'Assert_NullTT'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class Assert_NullTTExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'Name' property of 'Hãy điền dữ liệu đầy đủ' label equals 'Hãy điền dữ liệu đầy đủ'
        /// </summary>
        public string UIHãyđiềndữliệuđầyđủTextName = "Hãy điền dữ liệu đầy đủ";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'Assert_MaBPDaCo'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class Assert_MaBPDaCoExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'Name' property of 'Mã bộ phận đã tồn tại.' label equals 'Mã bộ phận đã tồn tại.'
        /// </summary>
        public string UIMãbộphậnđãtồntạiTextName = "Mã bộ phận đã tồn tại.";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'Assert_TenBPDaCo'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class Assert_TenBPDaCoExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'Name' property of 'Tên bộ phận đã tồn tại.' label equals 'Tên bộ phận đã tồn tại.'
        /// </summary>
        public string UITênbộphậnđãtồntạiTextName = "Tên bộ phận đã tồn tại.";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIHomeWindow : WinWindow
    {
        
        public UIHomeWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Home";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Home");
            #endregion
        }
        
        #region Properties
        public UIADDWindow UIADDWindow
        {
            get
            {
                if ((this.mUIADDWindow == null))
                {
                    this.mUIADDWindow = new UIADDWindow(this);
                }
                return this.mUIADDWindow;
            }
        }
        
        public UITxtMaBPWindow UITxtMaBPWindow
        {
            get
            {
                if ((this.mUITxtMaBPWindow == null))
                {
                    this.mUITxtMaBPWindow = new UITxtMaBPWindow(this);
                }
                return this.mUITxtMaBPWindow;
            }
        }
        
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this);
                }
                return this.mUIItemWindow;
            }
        }
        
        public UIItemWindow1 UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow1(this);
                }
                return this.mUIItemWindow1;
            }
        }
        
        public UISAVEWindow UISAVEWindow
        {
            get
            {
                if ((this.mUISAVEWindow == null))
                {
                    this.mUISAVEWindow = new UISAVEWindow(this);
                }
                return this.mUISAVEWindow;
            }
        }
        
        public UITxtTenBPWindow UITxtTenBPWindow
        {
            get
            {
                if ((this.mUITxtTenBPWindow == null))
                {
                    this.mUITxtTenBPWindow = new UITxtTenBPWindow(this);
                }
                return this.mUITxtTenBPWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIADDWindow mUIADDWindow;
        
        private UITxtMaBPWindow mUITxtMaBPWindow;
        
        private UIItemWindow mUIItemWindow;
        
        private UIItemWindow1 mUIItemWindow1;
        
        private UISAVEWindow mUISAVEWindow;
        
        private UITxtTenBPWindow mUITxtTenBPWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIADDWindow : WinWindow
    {
        
        public UIADDWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "mnuthem";
            this.WindowTitles.Add("Home");
            #endregion
        }
        
        #region Properties
        public WinButton UIADDButton
        {
            get
            {
                if ((this.mUIADDButton == null))
                {
                    this.mUIADDButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIADDButton.SearchProperties[WinButton.PropertyNames.Name] = "ADD";
                    this.mUIADDButton.WindowTitles.Add("Home");
                    #endregion
                }
                return this.mUIADDButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIADDButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UITxtMaBPWindow : WinWindow
    {
        
        public UITxtMaBPWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "txtMaBP";
            this.WindowTitles.Add("Home");
            #endregion
        }
        
        #region Properties
        public UITênBộPhậnClient UITênBộPhậnClient
        {
            get
            {
                if ((this.mUITênBộPhậnClient == null))
                {
                    this.mUITênBộPhậnClient = new UITênBộPhậnClient(this);
                }
                return this.mUITênBộPhậnClient;
            }
        }
        
        public WinEdit UITxtMaBPEdit
        {
            get
            {
                if ((this.mUITxtMaBPEdit == null))
                {
                    this.mUITxtMaBPEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUITxtMaBPEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Tên Bộ Phận";
                    this.mUITxtMaBPEdit.WindowTitles.Add("Home");
                    #endregion
                }
                return this.mUITxtMaBPEdit;
            }
        }
        #endregion
        
        #region Fields
        private UITênBộPhậnClient mUITênBộPhậnClient;
        
        private WinEdit mUITxtMaBPEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UITênBộPhậnClient : WinClient
    {
        
        public UITênBộPhậnClient(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinControl.PropertyNames.Name] = "Tên Bộ Phận";
            this.WindowTitles.Add("Home");
            #endregion
        }
        
        #region Properties
        public WinWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new WinWindow(this);
                    #region Search Criteria
                    this.mUIItemWindow.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.EDIT", PropertyExpressionOperator.Contains));
                    this.mUIItemWindow.WindowTitles.Add("Home");
                    #endregion
                }
                return this.mUIItemWindow;
            }
        }
        #endregion
        
        #region Fields
        private WinWindow mUIItemWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.EDIT", PropertyExpressionOperator.Contains));
            this.SearchProperties[WinWindow.PropertyNames.Instance] = "2";
            this.WindowTitles.Add("Home");
            #endregion
        }
        
        #region Properties
        public WinEdit UIItemEdit
        {
            get
            {
                if ((this.mUIItemEdit == null))
                {
                    this.mUIItemEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUIItemEdit.WindowTitles.Add("Home");
                    #endregion
                }
                return this.mUIItemEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIItemEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIItemWindow1 : WinWindow
    {
        
        public UIItemWindow1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.EDIT", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Home");
            #endregion
        }
        
        #region Properties
        public WinEdit UIItemEdit
        {
            get
            {
                if ((this.mUIItemEdit == null))
                {
                    this.mUIItemEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUIItemEdit.WindowTitles.Add("Home");
                    #endregion
                }
                return this.mUIItemEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIItemEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UISAVEWindow : WinWindow
    {
        
        public UISAVEWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "mnuluu";
            this.WindowTitles.Add("Home");
            #endregion
        }
        
        #region Properties
        public WinButton UISAVEButton
        {
            get
            {
                if ((this.mUISAVEButton == null))
                {
                    this.mUISAVEButton = new WinButton(this);
                    #region Search Criteria
                    this.mUISAVEButton.SearchProperties[WinButton.PropertyNames.Name] = "SAVE";
                    this.mUISAVEButton.WindowTitles.Add("Home");
                    #endregion
                }
                return this.mUISAVEButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUISAVEButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UITxtTenBPWindow : WinWindow
    {
        
        public UITxtTenBPWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "txtTenBP";
            this.WindowTitles.Add("Home");
            #endregion
        }
        
        #region Properties
        public WinEdit UITxtTenBPEdit
        {
            get
            {
                if ((this.mUITxtTenBPEdit == null))
                {
                    this.mUITxtTenBPEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUITxtTenBPEdit.WindowTitles.Add("Home");
                    #endregion
                }
                return this.mUITxtTenBPEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUITxtTenBPEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIMessageBoxThanhCongWindow : WinWindow
    {
        
        public UIMessageBoxThanhCongWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "MessageBoxThanhCong";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("MessageBoxThanhCong");
            #endregion
        }
        
        #region Properties
        public UIThêmthànhcôngWindow UIThêmthànhcôngWindow
        {
            get
            {
                if ((this.mUIThêmthànhcôngWindow == null))
                {
                    this.mUIThêmthànhcôngWindow = new UIThêmthànhcôngWindow(this);
                }
                return this.mUIThêmthànhcôngWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIThêmthànhcôngWindow mUIThêmthànhcôngWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIThêmthànhcôngWindow : WinWindow
    {
        
        public UIThêmthànhcôngWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "Test";
            this.WindowTitles.Add("MessageBoxThanhCong");
            #endregion
        }
        
        #region Properties
        public WinText UIThêmthànhcôngText
        {
            get
            {
                if ((this.mUIThêmthànhcôngText == null))
                {
                    this.mUIThêmthànhcôngText = new WinText(this);
                    #region Search Criteria
                    this.mUIThêmthànhcôngText.SearchProperties[WinText.PropertyNames.Name] = "Thêm thành công.";
                    this.mUIThêmthànhcôngText.WindowTitles.Add("MessageBoxThanhCong");
                    #endregion
                }
                return this.mUIThêmthànhcôngText;
            }
        }
        #endregion
        
        #region Fields
        private WinText mUIThêmthànhcôngText;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIMessageBoxCustomWindow : WinWindow
    {
        
        public UIMessageBoxCustomWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "MessageBoxCustom";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("MessageBoxCustom");
            #endregion
        }
        
        #region Properties
        public UIHãyđiềndữliệuđầyđủWindow UIHãyđiềndữliệuđầyđủWindow
        {
            get
            {
                if ((this.mUIHãyđiềndữliệuđầyđủWindow == null))
                {
                    this.mUIHãyđiềndữliệuđầyđủWindow = new UIHãyđiềndữliệuđầyđủWindow(this);
                }
                return this.mUIHãyđiềndữliệuđầyđủWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIHãyđiềndữliệuđầyđủWindow mUIHãyđiềndữliệuđầyđủWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIHãyđiềndữliệuđầyđủWindow : WinWindow
    {
        
        public UIHãyđiềndữliệuđầyđủWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "Test";
            this.WindowTitles.Add("MessageBoxCustom");
            #endregion
        }
        
        #region Properties
        public WinText UIHãyđiềndữliệuđầyđủText
        {
            get
            {
                if ((this.mUIHãyđiềndữliệuđầyđủText == null))
                {
                    this.mUIHãyđiềndữliệuđầyđủText = new WinText(this);
                    #region Search Criteria
                    this.mUIHãyđiềndữliệuđầyđủText.SearchProperties[WinText.PropertyNames.Name] = "Hãy điền dữ liệu đầy đủ";
                    this.mUIHãyđiềndữliệuđầyđủText.WindowTitles.Add("MessageBoxCustom");
                    #endregion
                }
                return this.mUIHãyđiềndữliệuđầyđủText;
            }
        }
        
        public WinText UIMãbộphậnđãtồntạiText
        {
            get
            {
                if ((this.mUIMãbộphậnđãtồntạiText == null))
                {
                    this.mUIMãbộphậnđãtồntạiText = new WinText(this);
                    #region Search Criteria
                    this.mUIMãbộphậnđãtồntạiText.SearchProperties[WinText.PropertyNames.Name] = "Mã bộ phận đã tồn tại.";
                    this.mUIMãbộphậnđãtồntạiText.WindowTitles.Add("MessageBoxCustom");
                    #endregion
                }
                return this.mUIMãbộphậnđãtồntạiText;
            }
        }
        
        public WinText UITênbộphậnđãtồntạiText
        {
            get
            {
                if ((this.mUITênbộphậnđãtồntạiText == null))
                {
                    this.mUITênbộphậnđãtồntạiText = new WinText(this);
                    #region Search Criteria
                    this.mUITênbộphậnđãtồntạiText.SearchProperties[WinText.PropertyNames.Name] = "Tên bộ phận đã tồn tại.";
                    this.mUITênbộphậnđãtồntạiText.WindowTitles.Add("MessageBoxCustom");
                    #endregion
                }
                return this.mUITênbộphậnđãtồntạiText;
            }
        }
        #endregion
        
        #region Fields
        private WinText mUIHãyđiềndữliệuđầyđủText;
        
        private WinText mUIMãbộphậnđãtồntạiText;
        
        private WinText mUITênbộphậnđãtồntạiText;
        #endregion
    }
}

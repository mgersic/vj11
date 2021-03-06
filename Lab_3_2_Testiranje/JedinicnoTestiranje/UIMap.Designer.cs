﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace JedinicnoTestiranje
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
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public partial class UIMap
    {
        
        /// <summary>
        /// Testira funkcionalnost izračuna geometrijskih svojstava pravokutnika.
        /// </summary>
        public void PravokutnikIzracun()
        {
            #region Variable Declarations
            WinButton uIPravokutnikButton = this.UIPočetnaformaWindow.UIPravokutnikWindow.UIPravokutnikButton;
            WinEdit uITxtStranicaAEdit = this.UIIzračungeometrijskihWindow.UIItem000Window.UITxtStranicaAEdit;
            WinEdit uITxtStranicaBEdit = this.UIIzračungeometrijskihWindow.UIItem000Window1.UITxtStranicaBEdit;
            WinButton uIIzračunajButton = this.UIIzračungeometrijskihWindow.UIIzračunajWindow.UIIzračunajButton;
            #endregion

            // Click 'Pravokutnik' button
            Mouse.Click(uIPravokutnikButton, new Point(267, 12));

            // Type '3' in 'txtStranicaA' text box
            uITxtStranicaAEdit.Text = this.PravokutnikIzracunParams.UITxtStranicaAEditText;

            // Type '{Tab}' in 'txtStranicaA' text box
            Keyboard.SendKeys(uITxtStranicaAEdit, this.PravokutnikIzracunParams.UITxtStranicaAEditSendKeys, ModifierKeys.None);

            // Type '4' in 'txtStranicaB' text box
            uITxtStranicaBEdit.Text = this.PravokutnikIzracunParams.UITxtStranicaBEditText;

            // Type '{Tab}' in 'txtStranicaB' text box
            Keyboard.SendKeys(uITxtStranicaBEdit, this.PravokutnikIzracunParams.UITxtStranicaBEditSendKeys, ModifierKeys.None);

            // Click 'Izračunaj' button
            Mouse.Click(uIIzračunajButton, new Point(37, 14));
        }
        
        /// <summary>
        /// Uspoređuje vrijednosti izračuna
        /// </summary>
        public void PravokutnikIzracunAssert()
        {
            #region Variable Declarations
            WinEdit uITxtDijagonalaEdit = this.UIIzračungeometrijskihWindow.UIItem000Window2.UITxtDijagonalaEdit;
            WinEdit uITxtPovrsinaEdit = this.UIIzračungeometrijskihWindow.UIItem000Window3.UITxtPovrsinaEdit;
            WinEdit uITxtOpsegEdit = this.UIIzračungeometrijskihWindow.UIItem000Window4.UITxtOpsegEdit;
            #endregion

            // Verify that the 'Text' property of 'txtDijagonala' text box equals '5'
            Assert.AreEqual(this.PravokutnikIzracunAssertExpectedValues.UITxtDijagonalaEditText, uITxtDijagonalaEdit.Text);

            // Verify that the 'Text' property of 'txtPovrsina' text box equals '12'
            Assert.AreEqual(this.PravokutnikIzracunAssertExpectedValues.UITxtPovrsinaEditText, uITxtPovrsinaEdit.Text, "Greska!");

            // Verify that the 'Text' property of 'txtOpseg' text box equals '14'
            Assert.AreEqual(this.PravokutnikIzracunAssertExpectedValues.UITxtOpsegEditText, uITxtOpsegEdit.Text);
        }
        
        /// <summary>
        /// Testira funkcionalnost izračuna geometrijskih svojstava kvadrata.
        /// </summary>
        public void KvadratIzračun()
        {
            #region Variable Declarations
            WinButton uIKvadratButton = this.UIPočetnaformaWindow.UIKvadratWindow.UIKvadratButton;
            WinEdit uITxtStranicaAEdit = this.UIFrmKvadratWindow.UIItem000Window.UITxtStranicaAEdit;
            WinButton uIIzračunajButton = this.UIFrmKvadratWindow.UIIzračunajWindow.UIIzračunajButton;
            #endregion

            // Click 'Kvadrat' button
            Mouse.Click(uIKvadratButton, new Point(245, 17));

            // Type '0' in 'txtStranicaA' text box
            uITxtStranicaAEdit.Text = this.KvadratIzračunParams.UITxtStranicaAEditText;

            // Click 'Izračunaj' button
            Mouse.Click(uIIzračunajButton, new Point(18, 10));
        }
        
        /// <summary>
        /// Uspoređuje rezultate izračuna
        /// </summary>
        public void KvadratIzračunAssert()
        {
            #region Variable Declarations
            WinEdit uITxtDijagonalaEdit = this.UIFrmKvadratWindow.UIItem000Window1.UITxtDijagonalaEdit;
            WinEdit uITxtPovrsinaEdit = this.UIFrmKvadratWindow.UIItem000Window2.UITxtPovrsinaEdit;
            WinEdit uITxtOpsegEdit = this.UIFrmKvadratWindow.UIItem000Window3.UITxtOpsegEdit;
            #endregion

            // Verify that the 'Text' property of 'txtDijagonala' text box equals '0'
            Assert.AreEqual(this.KvadratIzračunAssertExpectedValues.UITxtDijagonalaEditText, uITxtDijagonalaEdit.Text);

            // Verify that the 'Text' property of 'txtPovrsina' text box equals '0'
            Assert.AreEqual(this.KvadratIzračunAssertExpectedValues.UITxtPovrsinaEditText, uITxtPovrsinaEdit.Text);

            // Verify that the 'Text' property of 'txtOpseg' text box equals '0'
            Assert.AreEqual(this.KvadratIzračunAssertExpectedValues.UITxtOpsegEditText, uITxtOpsegEdit.Text);
        }
        
        #region Properties
        public virtual PravokutnikIzracunParams PravokutnikIzracunParams
        {
            get
            {
                if ((this.mPravokutnikIzracunParams == null))
                {
                    this.mPravokutnikIzracunParams = new PravokutnikIzracunParams();
                }
                return this.mPravokutnikIzracunParams;
            }
        }
        
        public virtual PravokutnikIzracunAssertExpectedValues PravokutnikIzracunAssertExpectedValues
        {
            get
            {
                if ((this.mPravokutnikIzracunAssertExpectedValues == null))
                {
                    this.mPravokutnikIzracunAssertExpectedValues = new PravokutnikIzracunAssertExpectedValues();
                }
                return this.mPravokutnikIzracunAssertExpectedValues;
            }
        }
        
        public virtual KvadratIzračunParams KvadratIzračunParams
        {
            get
            {
                if ((this.mKvadratIzračunParams == null))
                {
                    this.mKvadratIzračunParams = new KvadratIzračunParams();
                }
                return this.mKvadratIzračunParams;
            }
        }
        
        public virtual KvadratIzračunAssertExpectedValues KvadratIzračunAssertExpectedValues
        {
            get
            {
                if ((this.mKvadratIzračunAssertExpectedValues == null))
                {
                    this.mKvadratIzračunAssertExpectedValues = new KvadratIzračunAssertExpectedValues();
                }
                return this.mKvadratIzračunAssertExpectedValues;
            }
        }
        
        public UIPočetnaformaWindow UIPočetnaformaWindow
        {
            get
            {
                if ((this.mUIPočetnaformaWindow == null))
                {
                    this.mUIPočetnaformaWindow = new UIPočetnaformaWindow();
                }
                return this.mUIPočetnaformaWindow;
            }
        }
        
        public UIIzračungeometrijskihWindow UIIzračungeometrijskihWindow
        {
            get
            {
                if ((this.mUIIzračungeometrijskihWindow == null))
                {
                    this.mUIIzračungeometrijskihWindow = new UIIzračungeometrijskihWindow();
                }
                return this.mUIIzračungeometrijskihWindow;
            }
        }
        
        public UIFrmKvadratWindow UIFrmKvadratWindow
        {
            get
            {
                if ((this.mUIFrmKvadratWindow == null))
                {
                    this.mUIFrmKvadratWindow = new UIFrmKvadratWindow();
                }
                return this.mUIFrmKvadratWindow;
            }
        }
        #endregion
        
        #region Fields
        private PravokutnikIzracunParams mPravokutnikIzracunParams;
        
        private PravokutnikIzracunAssertExpectedValues mPravokutnikIzracunAssertExpectedValues;
        
        private KvadratIzračunParams mKvadratIzračunParams;
        
        private KvadratIzračunAssertExpectedValues mKvadratIzračunAssertExpectedValues;
        
        private UIPočetnaformaWindow mUIPočetnaformaWindow;
        
        private UIIzračungeometrijskihWindow mUIIzračungeometrijskihWindow;
        
        private UIFrmKvadratWindow mUIFrmKvadratWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'PravokutnikIzracun'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class PravokutnikIzracunParams
    {
        
        #region Fields
        /// <summary>
        /// Type '3' in 'txtStranicaA' text box
        /// </summary>
        public string UITxtStranicaAEditText = "3";
        
        /// <summary>
        /// Type '{Tab}' in 'txtStranicaA' text box
        /// </summary>
        public string UITxtStranicaAEditSendKeys = "{Tab}";
        
        /// <summary>
        /// Type '4' in 'txtStranicaB' text box
        /// </summary>
        public string UITxtStranicaBEditText = "4";
        
        /// <summary>
        /// Type '{Tab}' in 'txtStranicaB' text box
        /// </summary>
        public string UITxtStranicaBEditSendKeys = "{Tab}";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'PravokutnikIzracunAssert'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class PravokutnikIzracunAssertExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'Text' property of 'txtDijagonala' text box equals '5'
        /// </summary>
        public string UITxtDijagonalaEditText = "5";
        
        /// <summary>
        /// Verify that the 'Text' property of 'txtPovrsina' text box equals '12'
        /// </summary>
        public string UITxtPovrsinaEditText = "12";
        
        /// <summary>
        /// Verify that the 'Text' property of 'txtOpseg' text box equals '14'
        /// </summary>
        public string UITxtOpsegEditText = "14";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'KvadratIzračun'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class KvadratIzračunParams
    {
        
        #region Fields
        /// <summary>
        /// Type '0' in 'txtStranicaA' text box
        /// </summary>
        public string UITxtStranicaAEditText = "0";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'KvadratIzračunAssert'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class KvadratIzračunAssertExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'Text' property of 'txtDijagonala' text box equals '0'
        /// </summary>
        public string UITxtDijagonalaEditText = "0";
        
        /// <summary>
        /// Verify that the 'Text' property of 'txtPovrsina' text box equals '0'
        /// </summary>
        public string UITxtPovrsinaEditText = "0";
        
        /// <summary>
        /// Verify that the 'Text' property of 'txtOpseg' text box equals '0'
        /// </summary>
        public string UITxtOpsegEditText = "0";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIPočetnaformaWindow : WinWindow
    {
        
        public UIPočetnaformaWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Početna forma";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Početna forma");
            #endregion
        }
        
        #region Properties
        public UIPravokutnikWindow UIPravokutnikWindow
        {
            get
            {
                if ((this.mUIPravokutnikWindow == null))
                {
                    this.mUIPravokutnikWindow = new UIPravokutnikWindow(this);
                }
                return this.mUIPravokutnikWindow;
            }
        }
        
        public UIKvadratWindow UIKvadratWindow
        {
            get
            {
                if ((this.mUIKvadratWindow == null))
                {
                    this.mUIKvadratWindow = new UIKvadratWindow(this);
                }
                return this.mUIKvadratWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIPravokutnikWindow mUIPravokutnikWindow;
        
        private UIKvadratWindow mUIKvadratWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIPravokutnikWindow : WinWindow
    {
        
        public UIPravokutnikWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "btnPravokutnik";
            this.WindowTitles.Add("Početna forma");
            #endregion
        }
        
        #region Properties
        public WinButton UIPravokutnikButton
        {
            get
            {
                if ((this.mUIPravokutnikButton == null))
                {
                    this.mUIPravokutnikButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIPravokutnikButton.SearchProperties[WinButton.PropertyNames.Name] = "Pravokutnik";
                    this.mUIPravokutnikButton.WindowTitles.Add("Početna forma");
                    #endregion
                }
                return this.mUIPravokutnikButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIPravokutnikButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIKvadratWindow : WinWindow
    {
        
        public UIKvadratWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "btnKvadrat";
            this.WindowTitles.Add("Početna forma");
            #endregion
        }
        
        #region Properties
        public WinButton UIKvadratButton
        {
            get
            {
                if ((this.mUIKvadratButton == null))
                {
                    this.mUIKvadratButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIKvadratButton.SearchProperties[WinButton.PropertyNames.Name] = "Kvadrat";
                    this.mUIKvadratButton.WindowTitles.Add("Početna forma");
                    #endregion
                }
                return this.mUIKvadratButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIKvadratButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIIzračungeometrijskihWindow : WinWindow
    {
        
        public UIIzračungeometrijskihWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Izračun geometrijskih svojstava pravokutnika";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Izračun geometrijskih svojstava pravokutnika");
            #endregion
        }
        
        #region Properties
        public UIItem000Window UIItem000Window
        {
            get
            {
                if ((this.mUIItem000Window == null))
                {
                    this.mUIItem000Window = new UIItem000Window(this);
                }
                return this.mUIItem000Window;
            }
        }
        
        public UIItem000Window1 UIItem000Window1
        {
            get
            {
                if ((this.mUIItem000Window1 == null))
                {
                    this.mUIItem000Window1 = new UIItem000Window1(this);
                }
                return this.mUIItem000Window1;
            }
        }
        
        public UIIzračunajWindow UIIzračunajWindow
        {
            get
            {
                if ((this.mUIIzračunajWindow == null))
                {
                    this.mUIIzračunajWindow = new UIIzračunajWindow(this);
                }
                return this.mUIIzračunajWindow;
            }
        }
        
        public UIItem000Window2 UIItem000Window2
        {
            get
            {
                if ((this.mUIItem000Window2 == null))
                {
                    this.mUIItem000Window2 = new UIItem000Window2(this);
                }
                return this.mUIItem000Window2;
            }
        }
        
        public UIItem000Window3 UIItem000Window3
        {
            get
            {
                if ((this.mUIItem000Window3 == null))
                {
                    this.mUIItem000Window3 = new UIItem000Window3(this);
                }
                return this.mUIItem000Window3;
            }
        }
        
        public UIItem000Window4 UIItem000Window4
        {
            get
            {
                if ((this.mUIItem000Window4 == null))
                {
                    this.mUIItem000Window4 = new UIItem000Window4(this);
                }
                return this.mUIItem000Window4;
            }
        }
        
        public UIIzlazWindow UIIzlazWindow
        {
            get
            {
                if ((this.mUIIzlazWindow == null))
                {
                    this.mUIIzlazWindow = new UIIzlazWindow(this);
                }
                return this.mUIIzlazWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIItem000Window mUIItem000Window;
        
        private UIItem000Window1 mUIItem000Window1;
        
        private UIIzračunajWindow mUIIzračunajWindow;
        
        private UIItem000Window2 mUIItem000Window2;
        
        private UIItem000Window3 mUIItem000Window3;
        
        private UIItem000Window4 mUIItem000Window4;
        
        private UIIzlazWindow mUIIzlazWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItem000Window : WinWindow
    {
        
        public UIItem000Window(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "txtStranicaA";
            this.WindowTitles.Add("Izračun geometrijskih svojstava pravokutnika");
            #endregion
        }
        
        #region Properties
        public WinEdit UITxtStranicaAEdit
        {
            get
            {
                if ((this.mUITxtStranicaAEdit == null))
                {
                    this.mUITxtStranicaAEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUITxtStranicaAEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Stranica B:";
                    this.mUITxtStranicaAEdit.WindowTitles.Add("Izračun geometrijskih svojstava pravokutnika");
                    #endregion
                }
                return this.mUITxtStranicaAEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUITxtStranicaAEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItem000Window1 : WinWindow
    {
        
        public UIItem000Window1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "txtStranicaB";
            this.WindowTitles.Add("Izračun geometrijskih svojstava pravokutnika");
            #endregion
        }
        
        #region Properties
        public WinEdit UITxtStranicaBEdit
        {
            get
            {
                if ((this.mUITxtStranicaBEdit == null))
                {
                    this.mUITxtStranicaBEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUITxtStranicaBEdit.WindowTitles.Add("Izračun geometrijskih svojstava pravokutnika");
                    #endregion
                }
                return this.mUITxtStranicaBEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUITxtStranicaBEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIIzračunajWindow : WinWindow
    {
        
        public UIIzračunajWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "btnIzracunaj";
            this.WindowTitles.Add("Izračun geometrijskih svojstava pravokutnika");
            #endregion
        }
        
        #region Properties
        public WinButton UIIzračunajButton
        {
            get
            {
                if ((this.mUIIzračunajButton == null))
                {
                    this.mUIIzračunajButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIIzračunajButton.SearchProperties[WinButton.PropertyNames.Name] = "Izračunaj";
                    this.mUIIzračunajButton.WindowTitles.Add("Izračun geometrijskih svojstava pravokutnika");
                    #endregion
                }
                return this.mUIIzračunajButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIIzračunajButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItem000Window2 : WinWindow
    {
        
        public UIItem000Window2(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "txtDijagonala";
            this.WindowTitles.Add("Izračun geometrijskih svojstava pravokutnika");
            #endregion
        }
        
        #region Properties
        public WinEdit UITxtDijagonalaEdit
        {
            get
            {
                if ((this.mUITxtDijagonalaEdit == null))
                {
                    this.mUITxtDijagonalaEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUITxtDijagonalaEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Površina:";
                    this.mUITxtDijagonalaEdit.WindowTitles.Add("Izračun geometrijskih svojstava pravokutnika");
                    #endregion
                }
                return this.mUITxtDijagonalaEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUITxtDijagonalaEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItem000Window3 : WinWindow
    {
        
        public UIItem000Window3(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "txtPovrsina";
            this.WindowTitles.Add("Izračun geometrijskih svojstava pravokutnika");
            #endregion
        }
        
        #region Properties
        public WinEdit UITxtPovrsinaEdit
        {
            get
            {
                if ((this.mUITxtPovrsinaEdit == null))
                {
                    this.mUITxtPovrsinaEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUITxtPovrsinaEdit.WindowTitles.Add("Izračun geometrijskih svojstava pravokutnika");
                    #endregion
                }
                return this.mUITxtPovrsinaEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUITxtPovrsinaEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItem000Window4 : WinWindow
    {
        
        public UIItem000Window4(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "txtOpseg";
            this.WindowTitles.Add("Izračun geometrijskih svojstava pravokutnika");
            #endregion
        }
        
        #region Properties
        public WinEdit UITxtOpsegEdit
        {
            get
            {
                if ((this.mUITxtOpsegEdit == null))
                {
                    this.mUITxtOpsegEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUITxtOpsegEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Opseg:";
                    this.mUITxtOpsegEdit.WindowTitles.Add("Izračun geometrijskih svojstava pravokutnika");
                    #endregion
                }
                return this.mUITxtOpsegEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUITxtOpsegEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIIzlazWindow : WinWindow
    {
        
        public UIIzlazWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "btnIzlaz";
            this.WindowTitles.Add("Izračun geometrijskih svojstava pravokutnika");
            #endregion
        }
        
        #region Properties
        public WinButton UIIzlazButton
        {
            get
            {
                if ((this.mUIIzlazButton == null))
                {
                    this.mUIIzlazButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIIzlazButton.SearchProperties[WinButton.PropertyNames.Name] = "Izlaz";
                    this.mUIIzlazButton.WindowTitles.Add("Izračun geometrijskih svojstava pravokutnika");
                    #endregion
                }
                return this.mUIIzlazButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIIzlazButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIFrmKvadratWindow : WinWindow
    {
        
        public UIFrmKvadratWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "FrmKvadrat";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("FrmKvadrat");
            #endregion
        }
        
        #region Properties
        public UIItem000Window5 UIItem000Window
        {
            get
            {
                if ((this.mUIItem000Window == null))
                {
                    this.mUIItem000Window = new UIItem000Window5(this);
                }
                return this.mUIItem000Window;
            }
        }
        
        public UIIzračunajWindow1 UIIzračunajWindow
        {
            get
            {
                if ((this.mUIIzračunajWindow == null))
                {
                    this.mUIIzračunajWindow = new UIIzračunajWindow1(this);
                }
                return this.mUIIzračunajWindow;
            }
        }
        
        public UIItem000Window11 UIItem000Window1
        {
            get
            {
                if ((this.mUIItem000Window1 == null))
                {
                    this.mUIItem000Window1 = new UIItem000Window11(this);
                }
                return this.mUIItem000Window1;
            }
        }
        
        public UIItem000Window21 UIItem000Window2
        {
            get
            {
                if ((this.mUIItem000Window2 == null))
                {
                    this.mUIItem000Window2 = new UIItem000Window21(this);
                }
                return this.mUIItem000Window2;
            }
        }
        
        public UIItem000Window31 UIItem000Window3
        {
            get
            {
                if ((this.mUIItem000Window3 == null))
                {
                    this.mUIItem000Window3 = new UIItem000Window31(this);
                }
                return this.mUIItem000Window3;
            }
        }
        
        public UIIzlazWindow1 UIIzlazWindow
        {
            get
            {
                if ((this.mUIIzlazWindow == null))
                {
                    this.mUIIzlazWindow = new UIIzlazWindow1(this);
                }
                return this.mUIIzlazWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIItem000Window5 mUIItem000Window;
        
        private UIIzračunajWindow1 mUIIzračunajWindow;
        
        private UIItem000Window11 mUIItem000Window1;
        
        private UIItem000Window21 mUIItem000Window2;
        
        private UIItem000Window31 mUIItem000Window3;
        
        private UIIzlazWindow1 mUIIzlazWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItem000Window5 : WinWindow
    {
        
        public UIItem000Window5(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "txtStranicaA";
            this.WindowTitles.Add("FrmKvadrat");
            #endregion
        }
        
        #region Properties
        public WinEdit UITxtStranicaAEdit
        {
            get
            {
                if ((this.mUITxtStranicaAEdit == null))
                {
                    this.mUITxtStranicaAEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUITxtStranicaAEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Stranica A:";
                    this.mUITxtStranicaAEdit.WindowTitles.Add("FrmKvadrat");
                    #endregion
                }
                return this.mUITxtStranicaAEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUITxtStranicaAEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIIzračunajWindow1 : WinWindow
    {
        
        public UIIzračunajWindow1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "btnIzracunaj";
            this.WindowTitles.Add("FrmKvadrat");
            #endregion
        }
        
        #region Properties
        public WinButton UIIzračunajButton
        {
            get
            {
                if ((this.mUIIzračunajButton == null))
                {
                    this.mUIIzračunajButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIIzračunajButton.SearchProperties[WinButton.PropertyNames.Name] = "Izračunaj";
                    this.mUIIzračunajButton.WindowTitles.Add("FrmKvadrat");
                    #endregion
                }
                return this.mUIIzračunajButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIIzračunajButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItem000Window11 : WinWindow
    {
        
        public UIItem000Window11(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "txtDijagonala";
            this.WindowTitles.Add("FrmKvadrat");
            #endregion
        }
        
        #region Properties
        public WinEdit UITxtDijagonalaEdit
        {
            get
            {
                if ((this.mUITxtDijagonalaEdit == null))
                {
                    this.mUITxtDijagonalaEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUITxtDijagonalaEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Površina:";
                    this.mUITxtDijagonalaEdit.WindowTitles.Add("FrmKvadrat");
                    #endregion
                }
                return this.mUITxtDijagonalaEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUITxtDijagonalaEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItem000Window21 : WinWindow
    {
        
        public UIItem000Window21(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "txtPovrsina";
            this.WindowTitles.Add("FrmKvadrat");
            #endregion
        }
        
        #region Properties
        public WinEdit UITxtPovrsinaEdit
        {
            get
            {
                if ((this.mUITxtPovrsinaEdit == null))
                {
                    this.mUITxtPovrsinaEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUITxtPovrsinaEdit.WindowTitles.Add("FrmKvadrat");
                    #endregion
                }
                return this.mUITxtPovrsinaEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUITxtPovrsinaEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItem000Window31 : WinWindow
    {
        
        public UIItem000Window31(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "txtOpseg";
            this.WindowTitles.Add("FrmKvadrat");
            #endregion
        }
        
        #region Properties
        public WinEdit UITxtOpsegEdit
        {
            get
            {
                if ((this.mUITxtOpsegEdit == null))
                {
                    this.mUITxtOpsegEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUITxtOpsegEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Opseg:";
                    this.mUITxtOpsegEdit.WindowTitles.Add("FrmKvadrat");
                    #endregion
                }
                return this.mUITxtOpsegEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUITxtOpsegEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIIzlazWindow1 : WinWindow
    {
        
        public UIIzlazWindow1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "btnIzlaz";
            this.WindowTitles.Add("FrmKvadrat");
            #endregion
        }
        
        #region Properties
        public WinButton UIIzlazButton
        {
            get
            {
                if ((this.mUIIzlazButton == null))
                {
                    this.mUIIzlazButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIIzlazButton.SearchProperties[WinButton.PropertyNames.Name] = "Izlaz";
                    this.mUIIzlazButton.WindowTitles.Add("FrmKvadrat");
                    #endregion
                }
                return this.mUIIzlazButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIIzlazButton;
        #endregion
    }
}

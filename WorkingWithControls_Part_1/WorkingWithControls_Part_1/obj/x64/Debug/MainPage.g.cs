﻿#pragma checksum "D:\WorkingWithControls_Part_1\WorkingWithControls_Part_1\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F868C83F34AC8A4E881E55003B19A5C4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorkingWithControls_Part_1
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.MyComboBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2:
                {
                    this.MyToggleButton = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    #line 110 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.MyToggleButton).Click += this.MyToggleButton_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.ToggleButtonResultTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.MyListBox = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    #line 77 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.MyListBox).SelectionChanged += this.ListBox_SelectionChanged;
                    #line default
                }
                break;
            case 5:
                {
                    this.ListBoxResultTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    global::Windows.UI.Xaml.Controls.ComboBox element6 = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    #line 65 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ComboBox)element6).SelectionChanged += this.ComboBox_SelectionChanged;
                    #line default
                }
                break;
            case 7:
                {
                    this.ComboBoxResultTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.YesRadioButton = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 50 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.YesRadioButton).Checked += this.RadioButton_Checked;
                    #line default
                }
                break;
            case 9:
                {
                    this.NoRadioButton = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    #line 54 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.NoRadioButton).Checked += this.RadioButton_Checked;
                    #line default
                }
                break;
            case 10:
                {
                    this.RadioButtonTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11:
                {
                    this.MyCheckBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 33 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.MyCheckBox).Tapped += this.MyCheckBox_Tapped;
                    #line default
                }
                break;
            case 12:
                {
                    this.CheckBoxResultTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}


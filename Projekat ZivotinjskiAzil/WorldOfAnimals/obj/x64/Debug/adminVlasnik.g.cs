﻿#pragma checksum "C:\Users\nedim\Desktop\OOAD\Grupa7-ZivotinjskiAzil\Projekat ZivotinjskiAzil\WorldOfAnimals\adminVlasnik.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DB44644363865FFAB3382410139F5C64"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorldOfAnimals
{
    partial class adminVlasnik : 
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
                    this.NavView = (global::Windows.UI.Xaml.Controls.NavigationView)(target);
                }
                break;
            case 2:
                {
                    this.AppTitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.backToMain = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 42 "..\..\..\adminVlasnik.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.backToMain).Click += this.backToMain_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.ASB = (global::Windows.UI.Xaml.Controls.AutoSuggestBox)(target);
                }
                break;
            case 5:
                {
                    this.ContentFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
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

